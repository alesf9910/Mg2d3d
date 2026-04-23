namespace Mg2d3d.Resources;

public struct GpuTexture
{
    public Interop.Vulkan.VkHandle Image;
    public Interop.Vulkan.VkHandle View;
    public Interop.Vulkan.VkHandle Sampler;
    public uint Width;
    public uint Height;
    public GpuTextureFormat Format;
}
