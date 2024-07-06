﻿using Ardalis.GuardClauses;
using ShelfApi.Domain.Common;

namespace ShelfApi.Domain.ErrorAggregate;

public class ApiError : BaseModel
{
    public ApiError(ErrorCode code, string title, string message) : base()
    {
        Code = Guard.Against.EnumOutOfRange(code);
        Title = Guard.Against.NullOrWhiteSpace(title);
        Message = Guard.Against.NullOrWhiteSpace(message);
        Code = Guard.Against.EnumOutOfRange(code);
    }

    public ErrorCode Code { get; }
    public string Title { get; }
    public string Message { get; }
}