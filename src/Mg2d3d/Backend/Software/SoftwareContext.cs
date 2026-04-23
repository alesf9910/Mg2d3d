using Mg2d3d.Core;
using Mg2d3d.Memory;

namespace Mg2d3d.Backend.Software;

public unsafe struct SoftwareContext
{
    public byte* ColorBuffer;
    public int Width;
    public int Height;

    public ResultCode Initialize(int width, int height)
    {
        Width = width;
        Height = height;
        nuint size = (nuint)(width * height * 4);
        ColorBuffer = (byte*)NativeAllocator.Alloc(size);

        return NativeAllocator.EnsureNotNull(ColorBuffer);
    }

    public void Shutdown()
    {
        NativeAllocator.Free(ColorBuffer);
        ColorBuffer = null;
        Width = 0;
        Height = 0;
    }
}
