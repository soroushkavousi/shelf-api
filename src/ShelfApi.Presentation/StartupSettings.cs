﻿using Bitiano.DevKit;
using Microsoft.EntityFrameworkCore;
using ShelfApi.Domain.BaseDataAggregate;
using ShelfApi.Domain.Common;
using ShelfApi.Domain.Common.Extensions;
using ShelfApi.Infrastructure.Data.ShelfApiDb;
using ShelfApi.Presentation.Tools;

namespace ShelfApi.Presentation.SettingAggregate;

public record StartupSettings
{
    private readonly static MainSettingsCategory[] StartupSettingCategories =
    [
        MainSettingsCategory.JWT
    ];

    private StartupSettings() { }

    public AppEnvironmentName EnvironmentName { get; private set; }
    public string ShelfApiDbConnectionString { get; private set; }
    public JwtSettings JwtSettings { get; private set; } = new("hj4EvE7fdZrliSByeJfD5vErKXkdIBSV", "http://localhost", "http://localhost");

    public static async Task<StartupSettings> InitializeAsync()
    {
        StartupSettings startupSettings = new();
        startupSettings.LoadFromEnvironmentVariables();
        await startupSettings.LoadFromDatabaseAsync();
        return startupSettings;
    }

    private void LoadFromEnvironmentVariables()
    {
        EnvironmentName = EnvironmentVariables.EnvironmentName.Value.ToEnum<AppEnvironmentName>()
                ?? AppEnvironmentName.DEVELOPMENT;

        ShelfApiDbConnectionString = EnvironmentVariables.ConnectionString.Value;
        if (string.IsNullOrWhiteSpace(ShelfApiDbConnectionString))
        {
            string message = "Please provide connection string!";
            Console.WriteLine($"Error: {message}");
            throw new ArgumentNullException(nameof(ShelfApiDbConnectionString), message);
        }
    }

    private async Task LoadFromDatabaseAsync()
    {
        ShelfApiDbContext shelfApiDbContext = new(ShelfApiDbConnectionString);
        try
        {
            Dictionary<MainSettingsCategory, string> mainSettings = await shelfApiDbContext.MainSettings
                .Where(x => StartupSettingCategories.Contains(x.Category))
                .ToDictionaryAsync(x => x.Category, x => x.Data);

            JwtSettings = mainSettings[MainSettingsCategory.JWT].FromJson<JwtSettings>();
        }
        catch (Exception ex)
        {
            await Console.Out.WriteLineAsync($"Could not load MainSettings because of {ex.GetType().Name} {ex.Message}");
        }
        finally
        {
            shelfApiDbContext.Dispose();
        }
    }
}