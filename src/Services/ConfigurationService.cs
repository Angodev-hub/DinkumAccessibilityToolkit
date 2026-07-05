using BepInEx.Configuration;
using DinkumAccessibilityToolkit.Models.Configuration;

namespace DinkumAccessibilityToolkit.Services;

/// <summary>
/// Provides centralized access to the framework configuration.
/// </summary>
internal sealed class ConfigurationService
{
    private readonly ConfigFile _configFile;

    internal DatConfiguration Configuration { get; } = new();

    internal ConfigurationService(ConfigFile configFile)
    {
        _configFile = configFile;
    }
}