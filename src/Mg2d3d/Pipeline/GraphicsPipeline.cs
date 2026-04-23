namespace Mg2d3d.Pipeline;

public struct GraphicsPipeline
{
    public Interop.Vulkan.VkHandle Layout;
    public Interop.Vulkan.VkHandle Handle;
    public BlendMode BlendMode;
    public CullMode CullMode;
}
