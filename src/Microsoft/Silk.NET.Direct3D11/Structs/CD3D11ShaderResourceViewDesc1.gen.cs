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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "CD3D11_SHADER_RESOURCE_VIEW_DESC1")]
    public unsafe partial struct CD3D11ShaderResourceViewDesc1
    {
        public CD3D11ShaderResourceViewDesc1
        (
            Silk.NET.DXGI.Format? format = null,
            Silk.NET.Core.Native.D3DSrvDimension? viewDimension = null,
            ShaderResourceViewDesc1Union? anonymous = null,
            BufferSrv? buffer = null,
            Tex1DSrv? texture1D = null,
            Tex1DArraySrv? texture1DArray = null,
            Tex2DSrv1? texture2D = null,
            Tex2DArraySrv1? texture2DArray = null,
            Tex2DmsSrv? texture2DMS = null,
            Tex2DmsArraySrv? texture2DMSArray = null,
            Tex3DSrv? texture3D = null,
            TexcubeSrv? textureCube = null,
            TexcubeArraySrv? textureCubeArray = null,
            BufferexSrv? bufferEx = null
        ) : this()
        {
            if (format is not null)
            {
                Format = format.Value;
            }

            if (viewDimension is not null)
            {
                ViewDimension = viewDimension.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (buffer is not null)
            {
                Buffer = buffer.Value;
            }

            if (texture1D is not null)
            {
                Texture1D = texture1D.Value;
            }

            if (texture1DArray is not null)
            {
                Texture1DArray = texture1DArray.Value;
            }

            if (texture2D is not null)
            {
                Texture2D = texture2D.Value;
            }

            if (texture2DArray is not null)
            {
                Texture2DArray = texture2DArray.Value;
            }

            if (texture2DMS is not null)
            {
                Texture2DMS = texture2DMS.Value;
            }

            if (texture2DMSArray is not null)
            {
                Texture2DMSArray = texture2DMSArray.Value;
            }

            if (texture3D is not null)
            {
                Texture3D = texture3D.Value;
            }

            if (textureCube is not null)
            {
                TextureCube = textureCube.Value;
            }

            if (textureCubeArray is not null)
            {
                TextureCubeArray = textureCubeArray.Value;
            }

            if (bufferEx is not null)
            {
                BufferEx = bufferEx.Value;
            }
        }


        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "Format")]
        public Silk.NET.DXGI.Format Format;

        [NativeName("Type", "D3D11_SRV_DIMENSION")]
        [NativeName("Type.Name", "D3D11_SRV_DIMENSION")]
        [NativeName("Name", "ViewDimension")]
        public Silk.NET.Core.Native.D3DSrvDimension ViewDimension;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d11_3_L886_C5")]
        [NativeName("Name", "anonymous1")]
        public ShaderResourceViewDesc1Union Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref BufferSrv Buffer
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Buffer;
        }
#else
        public BufferSrv Buffer
        {
            get => Anonymous.Buffer;
            set => Anonymous.Buffer = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Tex1DSrv Texture1D
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Texture1D;
        }
#else
        public Tex1DSrv Texture1D
        {
            get => Anonymous.Texture1D;
            set => Anonymous.Texture1D = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Tex1DArraySrv Texture1DArray
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Texture1DArray;
        }
#else
        public Tex1DArraySrv Texture1DArray
        {
            get => Anonymous.Texture1DArray;
            set => Anonymous.Texture1DArray = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Tex2DSrv1 Texture2D
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Texture2D;
        }
#else
        public Tex2DSrv1 Texture2D
        {
            get => Anonymous.Texture2D;
            set => Anonymous.Texture2D = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Tex2DArraySrv1 Texture2DArray
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Texture2DArray;
        }
#else
        public Tex2DArraySrv1 Texture2DArray
        {
            get => Anonymous.Texture2DArray;
            set => Anonymous.Texture2DArray = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Tex2DmsSrv Texture2DMS
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Texture2DMS;
        }
#else
        public Tex2DmsSrv Texture2DMS
        {
            get => Anonymous.Texture2DMS;
            set => Anonymous.Texture2DMS = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Tex2DmsArraySrv Texture2DMSArray
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Texture2DMSArray;
        }
#else
        public Tex2DmsArraySrv Texture2DMSArray
        {
            get => Anonymous.Texture2DMSArray;
            set => Anonymous.Texture2DMSArray = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Tex3DSrv Texture3D
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Texture3D;
        }
#else
        public Tex3DSrv Texture3D
        {
            get => Anonymous.Texture3D;
            set => Anonymous.Texture3D = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref TexcubeSrv TextureCube
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].TextureCube;
        }
#else
        public TexcubeSrv TextureCube
        {
            get => Anonymous.TextureCube;
            set => Anonymous.TextureCube = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref TexcubeArraySrv TextureCubeArray
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].TextureCubeArray;
        }
#else
        public TexcubeArraySrv TextureCubeArray
        {
            get => Anonymous.TextureCubeArray;
            set => Anonymous.TextureCubeArray = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref BufferexSrv BufferEx
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].BufferEx;
        }
#else
        public BufferexSrv BufferEx
        {
            get => Anonymous.BufferEx;
            set => Anonymous.BufferEx = value;
        }
#endif

    }
}
