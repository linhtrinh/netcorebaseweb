namespace LT.Core.Commands.Interfaces
{
    public interface ICommandContext
    {
         string CurrentCommandChain { get; set; }
        Dictionary<string, object> CommandData { get; }
        CommandChainResult CommandChainResult { get; }
        ServiceContext ServiceContext { get; }
        Product_SMARTContext DbContext { get; }
        IDbContextTransaction DbTransaction { get; }
        ILoggerFactory LoggerFactory { get; }
        Common.Entities.ActivityLog.ActivityLog ActivityLogData { get; }

        ApplicationContext ApplicationContext { get; }

        IServiceProvider ServiceProvider { get; }

        SmartAppSettings SmartAppSettings { get; }

        ICommandContext SetCommandData(string key, object data);

        T GetData<T>(string key, bool isNullable = false);

        T GetService<T>();

        T GetDbContextWithTransaction<T>();
        void SetActivityLog(string actionCategory, string actionName, string data);
        void SetActivityLog(string data);
    }
}