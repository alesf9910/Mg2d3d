namespace Mg2d3d.Renderer;

public unsafe struct RendererContext
{
    public Core.GraphicsBackend Backend;
    public Interop.Vulkan.VkHandle Instance;
    public Interop.Vulkan.VkHandle Device;
    public Swapchain.SwapchainState Swapchain;
    public Command.CommandQueue GraphicsQueue;
    public uint IsInitialized;
}
