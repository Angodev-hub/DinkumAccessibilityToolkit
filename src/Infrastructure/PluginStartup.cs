using DinkumAccessibilityToolkit.Services;

namespace DinkumAccessibilityToolkit.Infrastructure;

internal static class PluginStartup
{
    internal static void Start(Plugin plugin)
    {
        LoggingService.Initialize(plugin.Log);

        LoggingService.Info($"{PluginInfo.Name} {PluginInfo.Version} loaded.");

        LoggingService.Info($"Game ready: {GameService.IsReady()}");
    }
}