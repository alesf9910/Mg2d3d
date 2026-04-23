namespace Mg2d3d.Renderer2D;

public unsafe struct Renderer2DContext
{
    public Resources.GpuBuffer VertexBuffer;
    public Resources.GpuBuffer IndexBuffer;
    public Pipeline.GraphicsPipeline Pipeline;
    public uint MaxQuads;
}
