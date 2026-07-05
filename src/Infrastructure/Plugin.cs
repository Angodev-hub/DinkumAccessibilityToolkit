using BepInEx;
using BepInEx.Logging;
using DinkumAccessibilityToolkit.Kernel;

namespace DinkumAccessibilityToolkit.Infrastructure;

[BepInPlugin(
    PluginInfo.Guid,
    PluginInfo.Name,
    PluginInfo.Version)]
internal sealed class Plugin : BaseUnityPlugin
{
    private readonly DatKernel _kernel = new();
    internal ManualLogSource Log => Logger;

    internal DatKernel Kernel => _kernel;

    private void Awake()
    {
        PluginStartup.Start(this);
    }
}