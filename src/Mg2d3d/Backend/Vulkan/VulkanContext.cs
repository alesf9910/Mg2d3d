using Mg2d3d.Core;
using Mg2d3d.Interop;

namespace Mg2d3d.Backend.Vulkan;

public unsafe struct VulkanContext
{
    public void* Instance;

    public ResultCode Initialize()
    {
        void* createInfo = null;
        void* allocator = null;
        void* instance = null;

        int vk = VulkanNative.VkCreateInstance(createInfo, allocator, &instance);
        if (vk != 0 || instance is null)
        {
            return ResultCode.BackendFailure;
        }

        Instance = instance;
        return ResultCode.Success;
    }

    public void Shutdown()
    {
        if (Instance is not null)
        {
            VulkanNative.VkDestroyInstance(Instance, null);
            Instance = null;
        }
    }
}
