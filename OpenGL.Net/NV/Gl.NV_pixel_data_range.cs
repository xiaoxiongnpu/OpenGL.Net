
// MIT License
// 
// Copyright (c) 2009-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 
// This file is automatically generated

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

using Khronos;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// [GL] Value of GL_WRITE_PIXEL_DATA_RANGE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_pixel_data_range")]
		public const int WRITE_PIXEL_DATA_RANGE_NV = 0x8878;

		/// <summary>
		/// [GL] Value of GL_READ_PIXEL_DATA_RANGE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_pixel_data_range")]
		public const int READ_PIXEL_DATA_RANGE_NV = 0x8879;

		/// <summary>
		/// [GL] Value of GL_WRITE_PIXEL_DATA_RANGE_LENGTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_pixel_data_range")]
		public const int WRITE_PIXEL_DATA_RANGE_LENGTH_NV = 0x887A;

		/// <summary>
		/// [GL] Value of GL_READ_PIXEL_DATA_RANGE_LENGTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_pixel_data_range")]
		public const int READ_PIXEL_DATA_RANGE_LENGTH_NV = 0x887B;

		/// <summary>
		/// [GL] Value of GL_WRITE_PIXEL_DATA_RANGE_POINTER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_pixel_data_range")]
		public const int WRITE_PIXEL_DATA_RANGE_POINTER_NV = 0x887C;

		/// <summary>
		/// [GL] Value of GL_READ_PIXEL_DATA_RANGE_POINTER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_pixel_data_range")]
		public const int READ_PIXEL_DATA_RANGE_POINTER_NV = 0x887D;

		/// <summary>
		/// [GL] glPixelDataRangeNV: Binding for glPixelDataRangeNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_NV_pixel_data_range")]
		public static void PixelDataRangeNV(int target, int length, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglPixelDataRangeNV != null, "pglPixelDataRangeNV not implemented");
			Delegates.pglPixelDataRangeNV(target, length, pointer);
			LogCommand("glPixelDataRangeNV", null, target, length, pointer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glPixelDataRangeNV: Binding for glPixelDataRangeNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:object"/>.
		/// </param>
		[RequiredByFeature("GL_NV_pixel_data_range")]
		public static void PixelDataRangeNV(int target, int length, object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				PixelDataRangeNV(target, length, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// [GL] glFlushPixelDataRangeNV: Binding for glFlushPixelDataRangeNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_NV_pixel_data_range")]
		public static void FlushPixelDataRangeNV(int target)
		{
			Debug.Assert(Delegates.pglFlushPixelDataRangeNV != null, "pglFlushPixelDataRangeNV not implemented");
			Delegates.pglFlushPixelDataRangeNV(target);
			LogCommand("glFlushPixelDataRangeNV", null, target			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_pixel_data_range")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPixelDataRangeNV(int target, int length, IntPtr pointer);

			[RequiredByFeature("GL_NV_pixel_data_range")]
			[ThreadStatic]
			internal static glPixelDataRangeNV pglPixelDataRangeNV;

			[RequiredByFeature("GL_NV_pixel_data_range")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFlushPixelDataRangeNV(int target);

			[RequiredByFeature("GL_NV_pixel_data_range")]
			[ThreadStatic]
			internal static glFlushPixelDataRangeNV pglFlushPixelDataRangeNV;

		}
	}

}
