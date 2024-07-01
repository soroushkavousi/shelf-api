using Microsoft.AspNetCore.Identity;
using ShelfApi.Domain.UserAggregate;

namespace ShelfApi.Application.AuthApplication;

public class LogInWithEmailCommandHandler : IRequestHandler<LogInWithEmailCommand, ResultDto<UserCredentialDto>>
{
    private readonly UserManager<User> _userManager;
    private readonly TokenService _tokenService;

    public LogInWithEmailCommandHandler(UserManager<User> userManager,
        TokenService tokenService)
    {
        _userManager = userManager;
        _tokenService = tokenService;
    }

    public async Task<ResultDto<UserCredentialDto>> Handle(LogInWithEmailCommand request, CancellationToken cancellationToken)
    {
        User user = await _userManager.FindByEmailAsync(request.EmailAddress);
        if (user is null)
            return ErrorCode.AuthenticationError;

        if (!await _userManager.CheckPasswordAsync(user, request.Password))
            return ErrorCode.AuthenticationError;

        var userCredential = await _tokenService.GenerateAccessTokenAsync(user);
        return userCredential;
    }
}