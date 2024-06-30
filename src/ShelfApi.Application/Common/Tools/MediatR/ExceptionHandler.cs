using MediatR.Pipeline;
using Microsoft.Extensions.Logging;
using ShelfApi.Domain.ErrorAggregate;

namespace ShelfApi.Application.Common.Tools.MediatR;

public class ExceptionHandler<TRequest, TResponse, TException>
    (ILogger<ExceptionHandler<TRequest, TResponse, TException>> logger)
    : IRequestExceptionHandler<TRequest, TResponse, TException>
    where TException : Exception
    where TResponse : ResultDto, new()
{
    private readonly ILogger<ExceptionHandler<TRequest, TResponse, TException>> _logger = logger;

    public Task Handle(TRequest request,
        TException exception,
        RequestExceptionHandlerState<TResponse> state,
        CancellationToken cancellationToken)
    {
        _logger.LogError(exception, "Command failed! request type: {RequestType}", request.GetType().FullName);

        TResponse response = new()
        {
            Error = new(ErrorCode.InternalServerError)
        };

        state.SetHandled(response);

        return Task.CompletedTask;
    }
}