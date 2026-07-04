using BepInEx;
using BepInEx.Logging;

namespace DinkumAccessibilityToolkit.Infrastructure;

[BepInPlugin(
    PluginInfo.Guid,
    PluginInfo.Name,
    PluginInfo.Version)]
internal sealed class Plugin : BaseUnityPlugin
{
    internal ManualLogSource Log => Logger;

    private void Awake()
    {
        PluginStartup.Start(this);
    }
}