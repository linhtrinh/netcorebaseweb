namespace LT.Core.Commands.Interfaces
{
    public interface ICommandManager
    {
        ICommandManager SetCommandData(string key, object data);

        CommandChainResult Execute(string commandChainName);
        Task Publish<TNotification>(TNotification notification, CancellationToken cancellationToken = default);
    }
}