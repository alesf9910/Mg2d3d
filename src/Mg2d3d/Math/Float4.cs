namespace Mg2d3d.Math;

[StructLayout(LayoutKind.Sequential)]
public struct Float4
{
    public float X;
    public float Y;
    public float Z;
    public float W;

    public Float4(float x, float y, float z, float w)
    {
        X = x;
        Y = y;
        Z = z;
        W = w;
    }
}
