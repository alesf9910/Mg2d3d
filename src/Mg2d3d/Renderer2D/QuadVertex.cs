namespace Mg2d3d.Renderer2D;

[StructLayout(LayoutKind.Sequential)]
public struct QuadVertex
{
    public Math.Float3 Position;
    public Math.Float2 Uv;
    public uint ColorRgba;
}
