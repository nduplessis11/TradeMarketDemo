using Microsoft.Extensions.DependencyInjection;

namespace TradeMarketDemo.Common.Cqrs;

public class CommandDispatcher(IServiceProvider serviceProvider)
{
    public async Task DispatchAsync<TCommand>(TCommand command, CancellationToken cancellationToken = default)
        where TCommand : ICommand
    {
        var handler = serviceProvider.GetService<ICommandHandler<TCommand>>();
        if (handler == null)
        {
            throw new InvalidOperationException($"No handler registered for type {typeof(TCommand).Name}");
        }
        
        await handler.HandleAsync(command, cancellationToken);
    }

    public async Task<TResponse> DispatchAsync<TCommand, TResponse>(TCommand command,
        CancellationToken cancellationToken = default)
            where TCommand : ICommand<TResponse>
    {
        var handler = serviceProvider.GetService<ICommandHandler<TCommand, TResponse>>();
        if (handler == null)
        {
            throw new InvalidOperationException($"No handler registered for type {typeof(TCommand).Name}");
        }
        
        return await handler.HandleAsync(command, cancellationToken);
    }
}