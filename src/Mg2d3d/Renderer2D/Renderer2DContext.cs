using Mg2d3d.Core;
using Mg2d3d.Memory;

namespace Mg2d3d.Renderer2D;

public unsafe struct Renderer2DContext
{
    public SpriteVertex* Vertices;
    public uint* Indices;
    public SpriteDrawCommand* Commands;

    public int VertexCapacity;
    public int IndexCapacity;
    public int CommandCapacity;

    public int VertexCount;
    public int IndexCount;
    public int CommandCount;

    public ResultCode Initialize(int vertexCapacity, int indexCapacity, int commandCapacity)
    {
        VertexCapacity = vertexCapacity;
        IndexCapacity = indexCapacity;
        CommandCapacity = commandCapacity;

        Vertices = (SpriteVertex*)NativeAllocator.Alloc((nuint)(sizeof(SpriteVertex) * vertexCapacity));
        Indices = (uint*)NativeAllocator.Alloc((nuint)(sizeof(uint) * indexCapacity));
        Commands = (SpriteDrawCommand*)NativeAllocator.Alloc((nuint)(sizeof(SpriteDrawCommand) * commandCapacity));

        if (Vertices is null || Indices is null || Commands is null)
        {
            return ResultCode.OutOfMemory;
        }

        VertexCount = 0;
        IndexCount = 0;
        CommandCount = 0;
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
