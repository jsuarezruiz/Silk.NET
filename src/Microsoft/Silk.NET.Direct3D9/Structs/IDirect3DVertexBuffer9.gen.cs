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
    [Guid("b64bb1b5-fd70-4df6-bf91-19d0a12455e3")]
    [NativeName("Name", "IDirect3DVertexBuffer9")]
    public unsafe partial struct IDirect3DVertexBuffer9
    {
        public static readonly Guid Guid = new("b64bb1b5-fd70-4df6-bf91-19d0a12455e3");

        public static implicit operator IDirect3DResource9(IDirect3DVertexBuffer9 val)
            => Unsafe.As<IDirect3DVertexBuffer9, IDirect3DResource9>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirect3DVertexBuffer9 val)
            => Unsafe.As<IDirect3DVertexBuffer9, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDirect3DVertexBuffer9
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
            var @this = (IDirect3DVertexBuffer9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexBuffer9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDirect3DVertexBuffer9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexBuffer9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDirect3DVertexBuffer9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexBuffer9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDirect3DVertexBuffer9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexBuffer9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirect3DVertexBuffer9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexBuffer9*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDirect3DVertexBuffer9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexBuffer9*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(IDirect3DDevice9** ppDevice)
        {
            var @this = (IDirect3DVertexBuffer9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexBuffer9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref IDirect3DDevice9* ppDevice)
        {
            var @this = (IDirect3DVertexBuffer9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DDevice9** ppDevicePtr = &ppDevice)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexBuffer9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* refguid, void* pData, uint SizeOfData, uint Flags)
        {
            var @this = (IDirect3DVertexBuffer9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexBuffer9*, Guid*, void*, uint, uint, int>)LpVtbl[4])(@this, refguid, pData, SizeOfData, Flags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* refguid, ref T0 pData, uint SizeOfData, uint Flags) where T0 : unmanaged
        {
            var @this = (IDirect3DVertexBuffer9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexBuffer9*, Guid*, T0*, uint, uint, int>)LpVtbl[4])(@this, refguid, pDataPtr, SizeOfData, Flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid refguid, void* pData, uint SizeOfData, uint Flags)
        {
            var @this = (IDirect3DVertexBuffer9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexBuffer9*, Guid*, void*, uint, uint, int>)LpVtbl[4])(@this, refguidPtr, pData, SizeOfData, Flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid refguid, ref T0 pData, uint SizeOfData, uint Flags) where T0 : unmanaged
        {
            var @this = (IDirect3DVertexBuffer9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexBuffer9*, Guid*, T0*, uint, uint, int>)LpVtbl[4])(@this, refguidPtr, pDataPtr, SizeOfData, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* refguid, void* pData, uint* pSizeOfData)
        {
            var @this = (IDirect3DVertexBuffer9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexBuffer9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguid, pData, pSizeOfData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* refguid, void* pData, ref uint pSizeOfData)
        {
            var @this = (IDirect3DVertexBuffer9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pSizeOfDataPtr = &pSizeOfData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexBuffer9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguid, pData, pSizeOfDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* refguid, ref T0 pData, uint* pSizeOfData) where T0 : unmanaged
        {
            var @this = (IDirect3DVertexBuffer9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexBuffer9*, Guid*, T0*, uint*, int>)LpVtbl[5])(@this, refguid, pDataPtr, pSizeOfData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* refguid, ref T0 pData, ref uint pSizeOfData) where T0 : unmanaged
        {
            var @this = (IDirect3DVertexBuffer9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexBuffer9*, Guid*, T0*, uint*, int>)LpVtbl[5])(@this, refguid, pDataPtr, pSizeOfDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid refguid, void* pData, uint* pSizeOfData)
        {
            var @this = (IDirect3DVertexBuffer9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexBuffer9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pData, pSizeOfData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid refguid, void* pData, ref uint pSizeOfData)
        {
            var @this = (IDirect3DVertexBuffer9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexBuffer9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pData, pSizeOfDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid refguid, ref T0 pData, uint* pSizeOfData) where T0 : unmanaged
        {
            var @this = (IDirect3DVertexBuffer9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexBuffer9*, Guid*, T0*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pDataPtr, pSizeOfData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid refguid, ref T0 pData, ref uint pSizeOfData) where T0 : unmanaged
        {
            var @this = (IDirect3DVertexBuffer9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexBuffer9*, Guid*, T0*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pDataPtr, pSizeOfDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FreePrivateData(Guid* refguid)
        {
            var @this = (IDirect3DVertexBuffer9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexBuffer9*, Guid*, int>)LpVtbl[6])(@this, refguid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FreePrivateData(ref Guid refguid)
        {
            var @this = (IDirect3DVertexBuffer9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexBuffer9*, Guid*, int>)LpVtbl[6])(@this, refguidPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint SetPriority(uint PriorityNew)
        {
            var @this = (IDirect3DVertexBuffer9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexBuffer9*, uint, uint>)LpVtbl[7])(@this, PriorityNew);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetPriority()
        {
            var @this = (IDirect3DVertexBuffer9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexBuffer9*, uint>)LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void PreLoad()
        {
            var @this = (IDirect3DVertexBuffer9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IDirect3DVertexBuffer9*, void>)LpVtbl[9])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly Resourcetype GetType()
        {
            var @this = (IDirect3DVertexBuffer9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Resourcetype ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexBuffer9*, Resourcetype>)LpVtbl[10])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Lock(uint OffsetToLock, uint SizeToLock, void** ppbData, uint Flags)
        {
            var @this = (IDirect3DVertexBuffer9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexBuffer9*, uint, uint, void**, uint, int>)LpVtbl[11])(@this, OffsetToLock, SizeToLock, ppbData, Flags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Lock(uint OffsetToLock, uint SizeToLock, ref void* ppbData, uint Flags)
        {
            var @this = (IDirect3DVertexBuffer9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppbDataPtr = &ppbData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexBuffer9*, uint, uint, void**, uint, int>)LpVtbl[11])(@this, OffsetToLock, SizeToLock, ppbDataPtr, Flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Unlock()
        {
            var @this = (IDirect3DVertexBuffer9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexBuffer9*, int>)LpVtbl[12])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesc(VertexbufferDesc* pDesc)
        {
            var @this = (IDirect3DVertexBuffer9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexBuffer9*, VertexbufferDesc*, int>)LpVtbl[13])(@this, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDesc(ref VertexbufferDesc pDesc)
        {
            var @this = (IDirect3DVertexBuffer9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VertexbufferDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexBuffer9*, VertexbufferDesc*, int>)LpVtbl[13])(@this, pDescPtr);
            }
            return ret;
        }

    }
}
