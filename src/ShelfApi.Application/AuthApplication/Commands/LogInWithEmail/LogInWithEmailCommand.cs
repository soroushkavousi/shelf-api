namespace ShelfApi.Application.AuthApplication;

public class LogInWithEmailCommand : IRequest<ResultDto<UserCredentialDto>>
{
    public string EmailAddress { get; init; }
    public string Password { get; init; }
}