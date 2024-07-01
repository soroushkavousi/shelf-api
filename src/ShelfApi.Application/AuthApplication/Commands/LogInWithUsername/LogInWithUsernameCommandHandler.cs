using Microsoft.AspNetCore.Identity;
using ShelfApi.Domain.UserAggregate;

namespace ShelfApi.Application.AuthApplication;

public class LogInWithUsernameCommandHandler : IRequestHandler<LogInWithUsernameCommand, ResultDto<UserCredentialDto>>
{
    private readonly UserManager<User> _userManager;
    private readonly TokenService _tokenService;

    public LogInWithUsernameCommandHandler(UserManager<User> userManager,
        TokenService tokenService)
    {
        _userManager = userManager;
        _tokenService = tokenService;
    }

    public async Task<ResultDto<UserCredentialDto>> Handle(LogInWithUsernameCommand request, CancellationToken cancellationToken)
    {
        User user = await _userManager.FindByNameAsync(request.Username);
        if (user is null)
            return ErrorCode.AuthenticationError;

        if (!await _userManager.CheckPasswordAsync(user, request.Password))
            return ErrorCode.AuthenticationError;

        var userCredential = await _tokenService.GenerateAccessTokenAsync(user);
        return userCredential;
    }
}