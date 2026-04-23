namespace Mg2d3d.Renderer3D;

public unsafe struct Renderer3DContext
{
    public Resources.GpuBuffer VertexBuffer;
    public Resources.GpuBuffer IndexBuffer;
    public Pipeline.GraphicsPipeline Pipeline;
    public Scene.Camera Camera;
}
