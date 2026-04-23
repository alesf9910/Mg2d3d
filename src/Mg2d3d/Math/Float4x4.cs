namespace Mg2d3d.Math;

[StructLayout(LayoutKind.Sequential)]
public struct Float4x4
{
    public Float4 C0;
    public Float4 C1;
    public Float4 C2;
    public Float4 C3;

    public static Float4x4 Identity()
    {
        Float4x4 matrix = default;
        matrix.C0.X = 1f;
        matrix.C1.Y = 1f;
        matrix.C2.Z = 1f;
        matrix.C3.W = 1f;
        return matrix;
    }
}
