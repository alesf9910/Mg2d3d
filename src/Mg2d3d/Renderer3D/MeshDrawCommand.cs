using Mg2d3d.Core;

namespace Mg2d3d.Renderer3D;

public struct MeshDrawCommand
{
    public Mat4 Transform;
    public uint FirstIndex;
    public uint IndexCount;
    public uint MaterialId;
}
