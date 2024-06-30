using ShelfApi.Domain.ErrorAggregate;

namespace ShelfApi.Application.Common.ValueObjects;

public record Result<TData>
{
    public Result(ErrorCode errorCode)
    {
        ErrorCode = errorCode;
    }

    public Result(TData data)
    {
        if (!EqualityComparer<TData>.Default.Equals(data, default))
            throw new InvalidOperationException();

        Data = data;
    }

    public TData Data { get; init; }
    public ErrorCode? ErrorCode { get; set; }

    public static implicit operator Result<TData>(ErrorCode errorCode) => new(errorCode);
    public static implicit operator Result<TData>(TData data) => new(data);
}