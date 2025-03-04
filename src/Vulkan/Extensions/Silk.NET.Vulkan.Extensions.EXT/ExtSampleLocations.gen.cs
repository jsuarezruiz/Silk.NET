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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_sample_locations")]
    public unsafe partial class ExtSampleLocations : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_sample_locations";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetSampleLocationsEXT")]
        public unsafe partial void CmdSetSampleLocation([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] SampleLocationsInfoEXT* pSampleLocationsInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetSampleLocationsEXT")]
        public partial void CmdSetSampleLocation([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in SampleLocationsInfoEXT pSampleLocationsInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceMultisamplePropertiesEXT")]
        public unsafe partial void GetPhysicalDeviceMultisampleProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SampleCountFlags samples, [Count(Count = 0), Flow(FlowDirection.Out)] MultisamplePropertiesEXT* pMultisampleProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMultisampleProperties = new(StructureType.MultisamplePropertiesExt);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceMultisamplePropertiesEXT")]
        public partial void GetPhysicalDeviceMultisampleProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SampleCountFlags samples, [Count(Count = 0), Flow(FlowDirection.Out)] out MultisamplePropertiesEXT pMultisampleProperties);

        public ExtSampleLocations(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

