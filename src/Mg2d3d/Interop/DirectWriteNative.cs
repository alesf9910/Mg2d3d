using System;
using System.Runtime.InteropServices;

namespace Mg2d3d.Interop;

public unsafe partial struct DirectWriteNative
{
    public const uint DWriteFactoryTypeShared = 0;

    [LibraryImport("dwrite", EntryPoint = "DWriteCreateFactory")]
    public static partial int DWriteCreateFactory(uint factoryType, ref Guid iid, void** factory);
}
