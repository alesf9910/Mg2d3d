namespace Mg2d3d.Resources;

[Flags]
public enum GpuBufferUsage : uint
{
    None = 0,
    Vertex = 1,
    Index = 2,
    Uniform = 4,
    Storage = 8,
    TransferSrc = 16,
    TransferDst = 32
}
