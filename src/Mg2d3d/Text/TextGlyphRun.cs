namespace Mg2d3d.Text;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct TextGlyphRun
{
    public FontFaceId Face;
    public ushort* Indices;
    public float* Advances;
    public uint GlyphCount;
    public float FontSize;
}
