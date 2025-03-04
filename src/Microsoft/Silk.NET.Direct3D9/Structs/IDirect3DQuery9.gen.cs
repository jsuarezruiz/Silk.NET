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

namespace Silk.NET.Direct3D9
{
    [Guid("d9771460-a695-4f26-bbd3-27b840b541cc")]
    [NativeName("Name", "IDirect3DQuery9")]
    public unsafe partial struct IDirect3DQuery9
    {
        public static readonly Guid Guid = new("d9771460-a695-4f26-bbd3-27b840b541cc");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirect3DQuery9 val)
            => Unsafe.As<IDirect3DQuery9, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDirect3DQuery9
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IDirect3DQuery9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DQuery9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDirect3DQuery9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DQuery9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDirect3DQuery9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DQuery9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDirect3DQuery9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DQuery9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirect3DQuery9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DQuery9*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDirect3DQuery9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DQuery9*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(IDirect3DDevice9** ppDevice)
        {
            var @this = (IDirect3DQuery9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DQuery9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref IDirect3DDevice9* ppDevice)
        {
            var @this = (IDirect3DQuery9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DDevice9** ppDevicePtr = &ppDevice)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DQuery9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Querytype GetType()
        {
            var @this = (IDirect3DQuery9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Querytype ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DQuery9*, Querytype>)LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetDataSize()
        {
            var @this = (IDirect3DQuery9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DQuery9*, uint>)LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Issue(uint dwIssueFlags)
        {
            var @this = (IDirect3DQuery9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DQuery9*, uint, int>)LpVtbl[6])(@this, dwIssueFlags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetData(void* pData, uint dwSize, uint dwGetDataFlags)
        {
            var @this = (IDirect3DQuery9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DQuery9*, void*, uint, uint, int>)LpVtbl[7])(@this, pData, dwSize, dwGetDataFlags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetData<T0>(ref T0 pData, uint dwSize, uint dwGetDataFlags) where T0 : unmanaged
        {
            var @this = (IDirect3DQuery9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DQuery9*, T0*, uint, uint, int>)LpVtbl[7])(@this, pDataPtr, dwSize, dwGetDataFlags);
            }
            return ret;
        }

    }
}
