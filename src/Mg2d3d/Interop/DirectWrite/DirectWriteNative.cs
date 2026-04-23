namespace Mg2d3d.Interop.DirectWrite;

public unsafe partial struct DirectWriteNative
{
    [LibraryImport("dwrite", EntryPoint = "DWriteCreateFactory")]
    public static partial int DWriteCreateFactory(DWriteFactoryType factoryType, in Guid iid, out nint factory);
}
