namespace Mg2d3d.Core;

public unsafe struct EngineState
{
    public CoreAllocator Allocator;
    public Renderer.RendererContext Renderer;
    public Renderer2D.Renderer2DContext Renderer2D;
    public Renderer3D.Renderer3DContext Renderer3D;
    public Text.TextSystem Text;
}
