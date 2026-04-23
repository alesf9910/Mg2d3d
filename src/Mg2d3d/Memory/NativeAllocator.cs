using System;
using System.Runtime.InteropServices;
using Mg2d3d.Core;

namespace Mg2d3d.Memory;

public unsafe struct NativeAllocator
{
    public static void* Alloc(nuint size)
    {
        return NativeMemory.Alloc(size);
    }

    public static void* AllocZeroed(nuint count, nuint size)
    {
        return NativeMemory.AllocZeroed(count, size);
    }

    public static void* Realloc(void* memory, nuint size)
    {
        return NativeMemory.Realloc(memory, size);
    }

    public static void Free(void* memory)
    {
        NativeMemory.Free(memory);
    }

    public static ResultCode EnsureNotNull(void* memory)
    {
        return memory is null ? ResultCode.OutOfMemory : ResultCode.Success;
    }
}
