namespace Mg2d3d.Math;

[StructLayout(LayoutKind.Sequential)]
public struct Float3
{
    public float X;
    public float Y;
    public float Z;

    public Float3(float x, float y, float z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}
