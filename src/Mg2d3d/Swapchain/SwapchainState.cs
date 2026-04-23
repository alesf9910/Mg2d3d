namespace Mg2d3d.Swapchain;

public unsafe struct SwapchainState
{
    public Interop.Vulkan.VkHandle Handle;
    public Interop.Vulkan.VkHandle Surface;
    public uint Width;
    public uint Height;
    public uint ImageCount;
}
