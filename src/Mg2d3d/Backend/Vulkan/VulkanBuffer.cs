namespace Mg2d3d.Backend.Vulkan;

public unsafe struct VulkanBuffer
{
    public void* Handle;
    public nuint Size;
    public VulkanBufferUsage Usage;
}
