namespace Mg2d3d.Interop.Vulkan;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkHandle
{
    public readonly nint Value;

    public VkHandle(nint value)
    {
        Value = value;
    }
}
