namespace ShelfApi.Application.AuthApplication;

public class LogInWithUsernameCommand : IRequest<ResultDto<UserCredentialDto>>
{
    public string Username { get; init; }
    public string Password { get; init; }
}