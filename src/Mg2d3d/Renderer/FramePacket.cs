namespace Mg2d3d.Renderer;

public unsafe struct FramePacket
{
    public Renderer2D.SpriteDrawCommand* Sprites;
    public uint SpriteCount;
    public Renderer3D.MeshDrawCommand* Meshes;
    public uint MeshCount;
    public Text.TextGlyphRun* TextRuns;
    public uint TextRunCount;
}
