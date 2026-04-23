namespace Mg2d3d;

public unsafe struct CoreAllocator
{
    public byte* Base;
    public nuint Capacity;
    public nuint Offset;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static CoreAllocator Create(nuint capacity)
    {
        CoreAllocator allocator = default;
        allocator.Base = (byte*)NativeMemory.AlignedAlloc(capacity, 64);
        allocator.Capacity = capacity;
        allocator.Offset = 0;
        return allocator;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void* Allocate(nuint size, nuint alignment)
    {
        nuint current = (nuint)Base + Offset;
        nuint aligned = (current + (alignment - 1)) & ~(alignment - 1);
        nuint nextOffset = aligned - (nuint)Base + size;

        if (nextOffset > Capacity)
        {
            return (void*)0;
        }

        Offset = nextOffset;
        return (void*)aligned;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void ResetFrame()
    {
        Offset = 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Release()
    {
        if (Base != (byte*)0)
        {
            NativeMemory.AlignedFree(Base);
            Base = (byte*)0;
            Capacity = 0;
            Offset = 0;
        }
    }
}
