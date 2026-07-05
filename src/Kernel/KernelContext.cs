using DinkumAccessibilityToolkit.Services;

namespace DinkumAccessibilityToolkit.Kernel;

/// <summary>
/// Contains the shared resources used by the Kernel and framework components.
/// </summary>
internal sealed class KernelContext
{
    internal ConfigurationService Configuration { get; }

    internal KernelContext(ConfigurationService configuration)
    {
        Configuration = configuration;
    }
}