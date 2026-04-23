namespace Mg2d3d.Command;

public struct CommandBuffer
{
    public Interop.Vulkan.VkHandle Handle;
    public uint IsRecording;
}
