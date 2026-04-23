namespace Mg2d3d.Core;

public unsafe struct EngineApi
{
    public static int Initialize(ref EngineState state, in EngineConfiguration configuration)
    {
        state.Allocator = CoreAllocator.Create(64UL * 1024UL * 1024UL);

        state.Renderer = default;
        state.Renderer.Backend = configuration.Backend;
        state.Renderer.IsInitialized = 0;

        if (configuration.Backend == GraphicsBackend.Vulkan)
        {
            Interop.Vulkan.VkHandle instance = default;
            Interop.Vulkan.VkResult result = Interop.Vulkan.VulkanNative.vkCreateInstance((void*)0, (void*)0, &instance);
            if (result != Interop.Vulkan.VkResult.Success)
            {
                return (int)result;
            }

            state.Renderer.Instance = instance;
            state.Renderer.IsInitialized = 1;
        }

        state.Text = default;
        state.Text.FactoryIid = Text.DirectWriteIids.IdWriteFactory();
        int hr = state.Text.Initialize();
        if (hr != 0)
        {
            return hr;
        }

        state.Renderer2D = default;
        state.Renderer2D.MaxQuads = 262144;

        state.Renderer3D = default;
        state.Renderer3D.Camera.View = Math.Float4x4.Identity();
        state.Renderer3D.Camera.Projection = Math.Float4x4.Identity();

        return 0;
    }

    public static void Shutdown(ref EngineState state)
    {
        if (state.Renderer.Instance.Value != 0)
        {
            Interop.Vulkan.VulkanNative.vkDestroyInstance(state.Renderer.Instance, (void*)0);
            state.Renderer.Instance = default;
        }

        state.Allocator.Release();
    }
}
