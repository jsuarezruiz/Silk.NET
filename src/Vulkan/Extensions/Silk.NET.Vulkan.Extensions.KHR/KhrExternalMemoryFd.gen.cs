// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.Vulkan;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_external_memory_fd")]
    public unsafe partial class KhrExternalMemoryFd : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_external_memory_fd";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryFdKHR")]
        public unsafe partial Result GetMemoryF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] MemoryGetFdInfoKHR* pGetFdInfo, [Count(Count = 0), Flow(FlowDirection.Out)] int* pFd);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryFdKHR")]
        public unsafe partial Result GetMemoryF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] MemoryGetFdInfoKHR* pGetFdInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out int pFd);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryFdKHR")]
        public unsafe partial Result GetMemoryF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in MemoryGetFdInfoKHR pGetFdInfo, [Count(Count = 0), Flow(FlowDirection.Out)] int* pFd);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryFdKHR")]
        public partial Result GetMemoryF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in MemoryGetFdInfoKHR pGetFdInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out int pFd);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryFdPropertiesKHR")]
        public unsafe partial Result GetMemoryFdProperties([Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] int fd, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryFdPropertiesKHR* pMemoryFdProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryFdProperties = new(StructureType.MemoryFDPropertiesKhr);")]
        [NativeApi(EntryPoint = "vkGetMemoryFdPropertiesKHR")]
        public partial Result GetMemoryFdProperties([Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] int fd, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryFdPropertiesKHR pMemoryFdProperties);

        public KhrExternalMemoryFd(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

