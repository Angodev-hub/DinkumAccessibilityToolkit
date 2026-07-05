using System;
using System.Collections.Generic;

namespace DinkumAccessibilityToolkit.Kernel;

/// <summary>
/// Orchestre le cycle de vie des composants du framework.
/// </summary>
internal sealed class DatKernel
{
    private readonly List<IKernelComponent> _components = new();

    private KernelState _state = KernelState.Created;

    internal void Register(IKernelComponent component)
    {
        if (_state != KernelState.Created)
        {
            throw new InvalidOperationException(
                "Cannot register components after the Kernel has started.");
        }

        _components.Add(component);
    }

    internal void Start()
    {
        if (_state != KernelState.Created)
        {
            throw new InvalidOperationException(
                "The Kernel can only be started once.");
        }

        _state = KernelState.Started;

        foreach (IKernelComponent component in _components)
        {
            component.Start();
        }
    }

    internal void Stop()
    {
        if (_state != KernelState.Started)
        {
            throw new InvalidOperationException(
                "The Kernel can only be stopped after it has started.");
        }

        _state = KernelState.Stopped;

        foreach (IKernelComponent component in _components)
        {
            component.Stop();
        }
    }
}