using LT.Core.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;

namespace LT.Core.Commands.Interfaces
{
    public interface ICommandContext
    {
        Dictionary<string, object> CommandData { get; }
        CommandChainResult CommandChainResult { get; }
        ServiceContext ServiceContext { get; }
        DbContext DbContext { get; }
        IDbContextTransaction DbTransaction { get; }
        ILoggerFactory LoggerFactory { get; }
        ApplicationContext ApplicationContext { get; }
        IServiceProvider ServiceProvider { get; }
        ICommandContext SetCommandData(string key, object data);
        T GetData<T>(string key, bool isNullable = false);
        T GetService<T>();
        T GetDbContextWithTransaction<T>();
    }
}