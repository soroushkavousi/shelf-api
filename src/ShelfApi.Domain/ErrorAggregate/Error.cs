namespace ShelfApi.Domain.ErrorAggregate;

public record Error
{
    public Error(ErrorCode errorCode)
    {
        Code = errorCode;
    }

    public ErrorCode Code { get; }
    public string Type { get; private set; }
    public string Field { get; private set; }
    public string Message { get; private set; }

    public void SetDetails(string type, string field, string message)
    {
        Type = type;
        Field = field;
        Message = message;
    }
}