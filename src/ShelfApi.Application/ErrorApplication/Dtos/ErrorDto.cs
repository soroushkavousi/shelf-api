using ShelfApi.Domain.ErrorAggregate;

namespace ShelfApi.Application.ErrorApplication;

public record ErrorDto
{
    public ErrorDto(ErrorCode errorCode)
    {
        Code = errorCode;
    }

    public ErrorCode Code { get; }
    public ErrorType Type { get; private set; }
    public ErrorField Field { get; private set; }
    public string Message { get; private set; }

    public void SetDetails(ErrorType type, ErrorField field, string message)
    {
        Type = type;
        Field = field;
        Message = message;
    }
}