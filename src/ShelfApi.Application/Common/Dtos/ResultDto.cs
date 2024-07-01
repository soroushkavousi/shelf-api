namespace ShelfApi.Application.Common;

public abstract record ResultDto
{
    public Error Error { get; set; }
}

public record ResultDto<TData> : ResultDto
{
    public ResultDto(ErrorCode errorCode)
    {
        Error = new(errorCode);
    }

    public ResultDto(TData data)
    {
        if (!EqualityComparer<TData>.Default.Equals(data, default))
            throw new InvalidOperationException();

        Data = data;
    }

    public TData Data { get; init; }

    public static implicit operator ResultDto<TData>(ErrorCode errorCode) => new(errorCode);
    public static implicit operator ResultDto<TData>(ErrorCode? errorCode) => new(errorCode.Value);
    public static implicit operator ResultDto<TData>(TData data) => new(data);
}

//public record ResultDto<TData> : ResultDto
//{
//    public ResultDto() { }

//    private ResultDto(TData data)
//    {
//        Data = data;
//    }

//    public static ResultDto<TData> Success(TData data)
//        => new(data);

//    public override void SetError(ErrorDto error)
//    {
//        if (!EqualityComparer<TData>.Default.Equals(Data, default))
//            throw new InvalidOperationException();

//        Errors = errors;
//    }
//}