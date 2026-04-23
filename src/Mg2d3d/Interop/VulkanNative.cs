using System;
using System.Runtime.InteropServices;

namespace Mg2d3d.Interop;

public unsafe partial struct VulkanNative
{
    [LibraryImport("vulkan-1", EntryPoint = "vkCreateInstance")]
    public static partial int VkCreateInstance(void* createInfo, void* allocator, void** instance);

    [LibraryImport("vulkan-1", EntryPoint = "vkDestroyInstance")]
    public static partial void VkDestroyInstance(void* instance, void* allocator);

    [LibraryImport("vulkan-1", EntryPoint = "vkGetInstanceProcAddr")]
    public static partial IntPtr VkGetInstanceProcAddr(void* instance, byte* name);
}
