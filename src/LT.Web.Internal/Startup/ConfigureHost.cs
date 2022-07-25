namespace LT.Web.Internal
{
    /// <summary>
    /// Configure app to read from app settings sealed file.
    /// Sealed file is where all share configure entries in
    /// Configure app to read from command settings file.
    /// Command setting file is where we configure the command under command chain
    /// </summary>
    public static class ConfigureHost
    {
        public static void ConfigureSmartHost(this ConfigureHostBuilder host){
            host.ConfigureAppConfiguration((ctx, config) =>
                config.SetBasePath(ctx.HostingEnvironment.ContentRootPath)
                .AddJsonFile($"appsettingsSealed.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettingsExtended.{ctx.HostingEnvironment.EnvironmentName}.json", optional: true, reloadOnChange: true)
                .AddJsonFile(Path.Combine("Settings", "commandsettings.json"))
            );
        }
    }
}