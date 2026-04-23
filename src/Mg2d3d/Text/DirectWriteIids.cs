namespace Mg2d3d.Text;

public struct DirectWriteIids
{
    public static Guid IdWriteFactory()
    {
        ReadOnlySpan<byte> bytes =
        [
            0x5A, 0xEE, 0x59, 0xB8,
            0x38, 0xD8,
            0x5B, 0x4B,
            0xA2, 0xE8,
            0x1A, 0xDC, 0x7D, 0x93, 0xDB, 0x48
        ];

        return MemoryMarshal.Read<Guid>(bytes);
    }
}
