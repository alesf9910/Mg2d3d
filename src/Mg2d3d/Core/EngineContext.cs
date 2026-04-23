using Mg2d3d.Backend.Software;
using Mg2d3d.Backend.Vulkan;
using Mg2d3d.Renderer2D;
using Mg2d3d.Renderer3D;
using Mg2d3d.Text;

namespace Mg2d3d.Core;

public struct EngineContext
{
    public BackendKind ActiveBackend;
    public VulkanContext Vulkan;
    public SoftwareContext Software;
    public Renderer2DContext Renderer2D;
    public Renderer3DContext Renderer3D;
    public DirectWriteContext Text;

    public ResultCode Initialize(EngineConfig config)
    {
        ActiveBackend = config.Backend;

        ResultCode backendCode = config.Backend switch
        {
            BackendKind.Vulkan => Vulkan.Initialize(),
            BackendKind.Software => Software.Initialize(config.FrameWidth, config.FrameHeight),
            _ => ResultCode.Unsupported
        };

        if (backendCode != ResultCode.Success)
        {
            return backendCode;
        }

        ResultCode code2D = Renderer2D.Initialize(config.Max2DVertices, config.Max2DIndices, config.Max2DCommands);
        if (code2D != ResultCode.Success)
        {
            return code2D;
        }

        ResultCode code3D = Renderer3D.Initialize(config.Max3DVertices, config.Max3DIndices, config.Max3DCommands);
        if (code3D != ResultCode.Success)
        {
            return code3D;
        }

        return Text.Initialize();
    }

    public void BeginFrame()
    {
        Renderer2D.ResetFrame();
        Renderer3D.ResetFrame();
    }

    public void Shutdown()
    {
        Text.Shutdown();
        Renderer3D.Shutdown();
        Renderer2D.Shutdown();

        if (ActiveBackend == BackendKind.Vulkan)
        {
            Vulkan.Shutdown();
        }
        else if (ActiveBackend == BackendKind.Software)
        {
            Software.Shutdown();
        }
    }
}
