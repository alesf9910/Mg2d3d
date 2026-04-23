namespace Mg2d3d.Renderer3D;

[StructLayout(LayoutKind.Sequential)]
public struct MeshVertex
{
    public Math.Float3 Position;
    public Math.Float3 Normal;
    public Math.Float2 Uv;
    public Math.Float4 Tangent;
}
