using BepInEx.Logging;

namespace DinkumAccessibilityToolkit.Services;

internal static class LoggingService
{
    private static ManualLogSource? _logger;

    internal static void Initialize(ManualLogSource logger)
    {
        _logger = logger;
    }

    internal static void Info(string message)
    {
        _logger?.LogInfo(message);
    }

    internal static void Warning(string message)
    {
        _logger?.LogWarning(message);
    }

    internal static void Error(string message)
    {
        _logger?.LogError(message);
    }
}