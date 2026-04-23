using Mg2d3d.Core;
using Mg2d3d.Memory;

namespace Mg2d3d.Renderer3D;

public unsafe struct Renderer3DContext
{
    public MeshVertex* Vertices;
    public uint* Indices;
    public MeshDrawCommand* Commands;

    public int VertexCount;
    public int IndexCount;
    public int CommandCount;

    public int VertexCapacity;
    public int IndexCapacity;
    public int CommandCapacity;

    public ResultCode Initialize(int vertexCapacity, int indexCapacity, int commandCapacity)
    {
        VertexCapacity = vertexCapacity;
        IndexCapacity = indexCapacity;
        CommandCapacity = commandCapacity;

        Vertices = (MeshVertex*)NativeAllocator.Alloc((nuint)(sizeof(MeshVertex) * vertexCapacity));
        Indices = (uint*)NativeAllocator.Alloc((nuint)(sizeof(uint) * indexCapacity));
        Commands = (MeshDrawCommand*)NativeAllocator.Alloc((nuint)(sizeof(MeshDrawCommand) * commandCapacity));

        if (Vertices is null || Indices is null || Commands is null)
        {
            return ResultCode.OutOfMemory;
        }

        return ResultCode.Success;
    }

    public void ResetFrame()
    {
        VertexCount = 0;
        IndexCount = 0;
        CommandCount = 0;
    }

    public void Shutdown()
    {
        NativeAllocator.Free(Vertices);
        NativeAllocator.Free(Indices);
        NativeAllocator.Free(Commands);
        Vertices = null;
        Indices = null;
        Commands = null;
    }
}
