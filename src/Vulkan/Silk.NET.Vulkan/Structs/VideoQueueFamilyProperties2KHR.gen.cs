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

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkVideoQueueFamilyProperties2KHR")]
    public unsafe partial struct VideoQueueFamilyProperties2KHR
    {
        public VideoQueueFamilyProperties2KHR
        (
            StructureType? sType = StructureType.VideoQueueFamilyProperties2Khr,
            void* pNext = null,
            VideoCodecOperationFlagsKHR? videoCodecOperations = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (videoCodecOperations is not null)
            {
                VideoCodecOperations = videoCodecOperations.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkVideoCodecOperationFlagsKHR")]
        [NativeName("Type.Name", "VkVideoCodecOperationFlagsKHR")]
        [NativeName("Name", "videoCodecOperations")]
        public VideoCodecOperationFlagsKHR VideoCodecOperations;
    }
}
