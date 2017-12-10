
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
		/// [GL] Value of GL_VERTEX_ARRAY_RANGE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_array_range")]
		public const int VERTEX_ARRAY_RANGE_NV = 0x851D;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ARRAY_RANGE_LENGTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_array_range")]
		public const int VERTEX_ARRAY_RANGE_LENGTH_NV = 0x851E;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ARRAY_RANGE_VALID_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_array_range")]
		public const int VERTEX_ARRAY_RANGE_VALID_NV = 0x851F;

		/// <summary>
		/// [GL] Value of GL_MAX_VERTEX_ARRAY_RANGE_ELEMENT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_array_range")]
		public const int MAX_VERTEX_ARRAY_RANGE_ELEMENT_NV = 0x8520;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ARRAY_RANGE_POINTER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_array_range")]
		public const int VERTEX_ARRAY_RANGE_POINTER_NV = 0x8521;

		/// <summary>
		/// [GL] glFlushVertexArrayRangeNV: Binding for glFlushVertexArrayRangeNV.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_array_range")]
		public static void FlushVertexArrayRangeNV()
		{
			Debug.Assert(Delegates.pglFlushVertexArrayRangeNV != null, "pglFlushVertexArrayRangeNV not implemented");
			Delegates.pglFlushVertexArrayRangeNV();
			LogCommand("glFlushVertexArrayRangeNV", null			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVertexArrayRangeNV: Binding for glVertexArrayRangeNV.
		/// </summary>
		/// <param name="length">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_array_range")]
		public static void VertexArrayRangeNV(int length, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglVertexArrayRangeNV != null, "pglVertexArrayRangeNV not implemented");
			Delegates.pglVertexArrayRangeNV(length, pointer);
			LogCommand("glVertexArrayRangeNV", null, length, pointer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVertexArrayRangeNV: Binding for glVertexArrayRangeNV.
		/// </summary>
		/// <param name="length">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:object"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_array_range")]
		public static void VertexArrayRangeNV(int length, object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				VertexArrayRangeNV(length, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_vertex_array_range")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFlushVertexArrayRangeNV();

			[RequiredByFeature("GL_NV_vertex_array_range")]
			[ThreadStatic]
			internal static glFlushVertexArrayRangeNV pglFlushVertexArrayRangeNV;

			[RequiredByFeature("GL_NV_vertex_array_range")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexArrayRangeNV(int length, IntPtr pointer);

			[RequiredByFeature("GL_NV_vertex_array_range")]
			[ThreadStatic]
			internal static glVertexArrayRangeNV pglVertexArrayRangeNV;

		}
	}

}
