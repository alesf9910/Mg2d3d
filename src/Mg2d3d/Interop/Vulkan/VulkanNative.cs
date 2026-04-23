namespace Mg2d3d.Interop.Vulkan;

public unsafe partial struct VulkanNative
{
    [LibraryImport("vulkan-1", EntryPoint = "vkCreateInstance")]
    public static partial VkResult vkCreateInstance(void* createInfo, void* allocator, VkHandle* instance);

    [LibraryImport("vulkan-1", EntryPoint = "vkDestroyInstance")]
    public static partial void vkDestroyInstance(VkHandle instance, void* allocator);

    [LibraryImport("vulkan-1", EntryPoint = "vkDeviceWaitIdle")]
    public static partial VkResult vkDeviceWaitIdle(VkHandle device);
}
