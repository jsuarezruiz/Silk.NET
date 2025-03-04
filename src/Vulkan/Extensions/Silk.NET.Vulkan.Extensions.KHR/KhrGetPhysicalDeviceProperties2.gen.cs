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
    [Extension("VK_KHR_get_physical_device_properties2")]
    public unsafe partial class KhrGetPhysicalDeviceProperties2 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_get_physical_device_properties2";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFeatures2KHR")]
        public unsafe partial void GetPhysicalDeviceFeatures2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] PhysicalDeviceFeatures2* pFeatures);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pFeatures = new(StructureType.PhysicalDeviceFeatures2);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFeatures2KHR")]
        public partial void GetPhysicalDeviceFeatures2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] out PhysicalDeviceFeatures2 pFeatures);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFormatProperties2KHR")]
        public unsafe partial void GetPhysicalDeviceFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0), Flow(FlowDirection.Out)] FormatProperties2* pFormatProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pFormatProperties = new(StructureType.FormatProperties2);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFormatProperties2KHR")]
        public partial void GetPhysicalDeviceFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0), Flow(FlowDirection.Out)] out FormatProperties2 pFormatProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2KHR")]
        public unsafe partial Result GetPhysicalDeviceImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceImageFormatInfo2* pImageFormatInfo, [Count(Count = 0), Flow(FlowDirection.Out)] ImageFormatProperties2* pImageFormatProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pImageFormatProperties = new(StructureType.ImageFormatProperties2);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2KHR")]
        public unsafe partial Result GetPhysicalDeviceImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceImageFormatInfo2* pImageFormatInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out ImageFormatProperties2 pImageFormatProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2KHR")]
        public unsafe partial Result GetPhysicalDeviceImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] in PhysicalDeviceImageFormatInfo2 pImageFormatInfo, [Count(Count = 0), Flow(FlowDirection.Out)] ImageFormatProperties2* pImageFormatProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pImageFormatProperties = new(StructureType.ImageFormatProperties2);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2KHR")]
        public partial Result GetPhysicalDeviceImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] in PhysicalDeviceImageFormatInfo2 pImageFormatInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out ImageFormatProperties2 pImageFormatProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceMemoryProperties2KHR")]
        public unsafe partial void GetPhysicalDeviceMemoryProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] PhysicalDeviceMemoryProperties2* pMemoryProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryProperties = new(StructureType.PhysicalDeviceMemoryProperties2);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceMemoryProperties2KHR")]
        public partial void GetPhysicalDeviceMemoryProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] out PhysicalDeviceMemoryProperties2 pMemoryProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceProperties2KHR")]
        public unsafe partial void GetPhysicalDeviceProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] PhysicalDeviceProperties2* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.PhysicalDeviceProperties2);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceProperties2KHR")]
        public partial void GetPhysicalDeviceProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] out PhysicalDeviceProperties2 pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2KHR")]
        public unsafe partial void GetPhysicalDeviceQueueFamilyProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pQueueFamilyPropertyCount, [Count(Parameter = "pQueueFamilyPropertyCount"), Flow(FlowDirection.Out)] QueueFamilyProperties2* pQueueFamilyProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pQueueFamilyProperties = new(StructureType.QueueFamilyProperties2);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2KHR")]
        public unsafe partial void GetPhysicalDeviceQueueFamilyProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pQueueFamilyPropertyCount, [Count(Parameter = "pQueueFamilyPropertyCount"), Flow(FlowDirection.Out)] out QueueFamilyProperties2 pQueueFamilyProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2KHR")]
        public unsafe partial void GetPhysicalDeviceQueueFamilyProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pQueueFamilyPropertyCount, [Count(Parameter = "pQueueFamilyPropertyCount"), Flow(FlowDirection.Out)] QueueFamilyProperties2* pQueueFamilyProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pQueueFamilyProperties = new(StructureType.QueueFamilyProperties2);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2KHR")]
        public partial void GetPhysicalDeviceQueueFamilyProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pQueueFamilyPropertyCount, [Count(Parameter = "pQueueFamilyPropertyCount"), Flow(FlowDirection.Out)] out QueueFamilyProperties2 pQueueFamilyProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2KHR")]
        public unsafe partial void GetPhysicalDeviceSparseImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceSparseImageFormatInfo2* pFormatInfo, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(FlowDirection.Out)] SparseImageFormatProperties2* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.SparseImageFormatProperties2);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2KHR")]
        public unsafe partial void GetPhysicalDeviceSparseImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceSparseImageFormatInfo2* pFormatInfo, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(FlowDirection.Out)] out SparseImageFormatProperties2 pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2KHR")]
        public unsafe partial void GetPhysicalDeviceSparseImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceSparseImageFormatInfo2* pFormatInfo, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(FlowDirection.Out)] SparseImageFormatProperties2* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.SparseImageFormatProperties2);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2KHR")]
        public unsafe partial void GetPhysicalDeviceSparseImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceSparseImageFormatInfo2* pFormatInfo, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(FlowDirection.Out)] out SparseImageFormatProperties2 pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2KHR")]
        public unsafe partial void GetPhysicalDeviceSparseImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] in PhysicalDeviceSparseImageFormatInfo2 pFormatInfo, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(FlowDirection.Out)] SparseImageFormatProperties2* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.SparseImageFormatProperties2);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2KHR")]
        public unsafe partial void GetPhysicalDeviceSparseImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] in PhysicalDeviceSparseImageFormatInfo2 pFormatInfo, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(FlowDirection.Out)] out SparseImageFormatProperties2 pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2KHR")]
        public unsafe partial void GetPhysicalDeviceSparseImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] in PhysicalDeviceSparseImageFormatInfo2 pFormatInfo, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(FlowDirection.Out)] SparseImageFormatProperties2* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.SparseImageFormatProperties2);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2KHR")]
        public partial void GetPhysicalDeviceSparseImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] in PhysicalDeviceSparseImageFormatInfo2 pFormatInfo, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(FlowDirection.Out)] out SparseImageFormatProperties2 pProperties);

        /// <summary>To be documented.</summary>
        public unsafe PhysicalDeviceFeatures2 GetPhysicalDeviceFeatures2([Count(Count = 0)] PhysicalDevice physicalDevice)
        {
            // ReturnTypeOverloader
            PhysicalDeviceFeatures2 ret = default;
            GetPhysicalDeviceFeatures2(physicalDevice, &ret);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public unsafe PhysicalDeviceMemoryProperties2 GetPhysicalDeviceMemoryProperties2([Count(Count = 0)] PhysicalDevice physicalDevice)
        {
            // ReturnTypeOverloader
            PhysicalDeviceMemoryProperties2 ret = default;
            GetPhysicalDeviceMemoryProperties2(physicalDevice, &ret);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public unsafe PhysicalDeviceProperties2 GetPhysicalDeviceProperties2([Count(Count = 0)] PhysicalDevice physicalDevice)
        {
            // ReturnTypeOverloader
            PhysicalDeviceProperties2 ret = default;
            GetPhysicalDeviceProperties2(physicalDevice, &ret);
            return ret;
        }

        public KhrGetPhysicalDeviceProperties2(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

