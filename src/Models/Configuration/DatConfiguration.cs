namespace DinkumAccessibilityToolkit.Models.Configuration;

/// <summary>
/// Represents the configuration of the Dinkum Accessibility Toolkit.
/// </summary>
internal sealed class DatConfiguration
{
    /// <summary>
    /// Gets the debug configuration.
    /// </summary>
    internal DebugConfiguration Debug { get; } = new();
}