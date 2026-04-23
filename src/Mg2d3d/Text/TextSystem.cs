namespace Mg2d3d.Text;

public unsafe struct TextSystem
{
    public nint DWriteFactory;
    public Guid FactoryIid;
    public uint IsInitialized;

    public int Initialize()
    {
        int hr = Interop.DirectWrite.DirectWriteNative.DWriteCreateFactory(Interop.DirectWrite.DWriteFactoryType.Shared, in FactoryIid, out DWriteFactory);
        IsInitialized = (uint)(hr == 0 ? 1 : 0);
        return hr;
    }
}
