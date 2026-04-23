namespace Mg2d3d.Text;

public unsafe struct TextLayoutRequest
{
    public char* Text;
    public int TextLength;
    public float FontSize;
    public float MaxWidth;
    public float MaxHeight;
}
