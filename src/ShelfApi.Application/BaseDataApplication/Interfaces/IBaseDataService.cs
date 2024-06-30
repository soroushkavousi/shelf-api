using ShelfApi.Application.ErrorApplication;
using ShelfApi.Domain.BaseDataAggregate;
using ShelfApi.Domain.ErrorAggregate;

namespace ShelfApi.Application.BaseDataApplication.Interfaces;

public interface IBaseDataService
{
    JwtSettings JwtSettings { get; }
    FinancialSettings FinancialSettings { get; }
    Dictionary<ErrorCode, ErrorDto> Errors { get; }

    Task InitializeAsync(IShelfApiDbContext shelfApiDbContext);
}