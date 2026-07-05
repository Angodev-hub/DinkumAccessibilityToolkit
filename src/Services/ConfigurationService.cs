using DinkumAccessibilityToolkit.Models.Configuration;

namespace DinkumAccessibilityToolkit.Services;

/// <summary>
/// Provides centralized access to the framework configuration.
/// </summary>
internal sealed class ConfigurationService
{
    /// <summary>
    /// Gets the current DAT configuration.
    /// </summary>
    internal DatConfiguration Configuration { get; } = new();
}