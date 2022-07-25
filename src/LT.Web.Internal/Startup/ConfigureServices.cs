namespace LT.Web.Internal
{
    /// <summary>
    /// Configure common services for API
    /// </summary>
    public static class ConfigureServices
    {
        public static IServiceCollection ConfigureSmartServices(this IServiceCollection builder){
            return builder;
        }
    }
}