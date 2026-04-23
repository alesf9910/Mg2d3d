using System;
using Mg2d3d.Core;

namespace Mg2d3d.Memory;

public unsafe struct LinearArena
{
    public byte* Base;
    public nuint Capacity;
    public nuint Offset;

    public ResultCode Initialize(nuint capacity)
    {
        Base = (byte*)NativeAllocator.Alloc(capacity);
        if (Base is null)
        {
            Capacity = 0;
            Offset = 0;
            return ResultCode.OutOfMemory;
        }

        Capacity = capacity;
        Offset = 0;
        return ResultCode.Success;
    }

    public void* Alloc(nuint size, nuint alignment)
    {
        nuint current = (nuint)(Base + Offset);
        nuint aligned = (current + (alignment - 1)) & ~(alignment - 1);
        nuint nextOffset = (aligned - (nuint)Base) + size;

        if (nextOffset > Capacity)
        {
            return null;
        }

        Offset = nextOffset;
        return (void*)aligned;
    }

    public void Reset()
    {
        Offset = 0;
    }

    public void Dispose()
    {
        NativeAllocator.Free(Base);
        Base = null;
        Capacity = 0;
        Offset = 0;
    }
}
