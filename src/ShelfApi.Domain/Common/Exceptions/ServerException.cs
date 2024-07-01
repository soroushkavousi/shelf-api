using ShelfApi.Domain.ErrorAggregate;

namespace ShelfApi.Domain.Common.Exceptions;

public class ServerException : Exception
{
    public ServerException(ErrorCode errorCode) : base($"Faced error {errorCode}")
    {
        ErrorCode = errorCode;
    }

    public ServerException(ErrorCode errorCode, object value) : base($"Faced error {errorCode} with value {value}")
    {
        ErrorCode = errorCode;
    }

    public ServerException(string message) : base(message)
    {
    }

    public ErrorCode ErrorCode { get; set; }
}