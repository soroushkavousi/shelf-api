namespace ShelfApi.Domain.ErrorAggregate;

public enum ErrorCode : byte
{
    InternalServerError,
    AuthenticationError,

    NotFound,
    EmailNotFound,
    UsernameNotFound,

    EmailExists,
    UsernameExists,

    InvalidEncodedId,
    InvalidPassword,
    InvalidPrice,
}