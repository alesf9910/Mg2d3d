namespace Mg2d3d.Shaders;

public unsafe struct ShaderModule
{
    public Interop.Vulkan.VkHandle Handle;
    public ShaderStage Stage;
    public uint* SpirvCode;
    public nuint WordCount;
}
