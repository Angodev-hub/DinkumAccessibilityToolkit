namespace DinkumAccessibilityToolkit.Kernel;

/// <summary>
/// Représente un composant pouvant être piloté par le Kernel.
/// </summary>
internal interface IKernelComponent
{
    /// <summary>
    /// Appelé lors du démarrage du framework.
    /// </summary>
    void Start();

    /// <summary>
    /// Appelé lors de l'arrêt du framework.
    /// </summary>
    void Stop();
}