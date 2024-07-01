using ShelfApi.Domain.BaseDataAggregate;

namespace ShelfApi.Application.BaseDataApplication.Interfaces;

public interface IBaseDataService
{
    JwtSettings JwtSettings { get; }
    FinancialSettings FinancialSettings { get; }
    Dictionary<ErrorCode, Error> Errors { get; }

    Task InitializeAsync(IShelfApiDbContext shelfApiDbContext);
}