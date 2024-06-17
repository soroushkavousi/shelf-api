﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShelfApi.Domain.BaseDataAggregate;
using ShelfApi.Infrastructure.Extensions;

namespace ShelfApi.Infrastructure.Data.ShelfApiDb.BaseDataConfigurations;

public class ProjectSettingsConfiguration : IEntityTypeConfiguration<ProjectSetting>
{
    public void Configure(EntityTypeBuilder<ProjectSetting> builder)
    {
        builder.ConfigureKey(x => x.Id, autoGenerated: false);

        builder.Property(x => x.Id)
            .HasColumnOrder(101)
            .IsRequired();

        builder.Property(x => x.Data)
            .HasDefaultValue("{}")
            .HasColumnOrder(102)
            .IsRequired();

        builder.Property(x => x.CreatedAt)
            .ConfigureCreatedAt();

        builder.Property(x => x.ModifiedAt)
            .ConfigureModifiedAt();
    }
}