namespace Mg2d3d.Core;

public readonly struct EngineConfiguration
{
    public readonly uint Width;
    public readonly uint Height;
    public readonly uint FramesInFlight;
    public readonly GraphicsBackend Backend;
    public readonly nint NativeWindowHandle;
    public readonly uint EnableValidation;

    public EngineConfiguration(uint width, uint height, uint framesInFlight, GraphicsBackend backend, nint nativeWindowHandle, uint enableValidation)
    {
        Width = width;
        Height = height;
        FramesInFlight = framesInFlight;
        Backend = backend;
        NativeWindowHandle = nativeWindowHandle;
        EnableValidation = enableValidation;
    }
}
