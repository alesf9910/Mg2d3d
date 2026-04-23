namespace Mg2d3d.Resources;

public unsafe struct GpuBuffer
{
    public Interop.Vulkan.VkHandle Handle;
    public Interop.Vulkan.VkHandle Memory;
    public ulong Size;
    public GpuBufferUsage Usage;
    public void* Mapped;
}
