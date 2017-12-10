
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
		/// [GL] glMultiDrawArraysIndirectBindlessCountNV: Binding for glMultiDrawArraysIndirectBindlessCountNV.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:PrimitiveType"/>.
		/// </param>
		/// <param name="indirect">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawCount">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="maxDrawCount">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="vertexBufferCount">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_NV_bindless_multi_draw_indirect_count", Api = "gl|glcore")]
		public static void MultiDrawArraysIndirectBindNV(PrimitiveType mode, IntPtr indirect, int drawCount, int maxDrawCount, int stride, int vertexBufferCount)
		{
			Debug.Assert(Delegates.pglMultiDrawArraysIndirectBindlessCountNV != null, "pglMultiDrawArraysIndirectBindlessCountNV not implemented");
			Delegates.pglMultiDrawArraysIndirectBindlessCountNV((int)mode, indirect, drawCount, maxDrawCount, stride, vertexBufferCount);
			LogCommand("glMultiDrawArraysIndirectBindlessCountNV", null, mode, indirect, drawCount, maxDrawCount, stride, vertexBufferCount			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glMultiDrawArraysIndirectBindlessCountNV: Binding for glMultiDrawArraysIndirectBindlessCountNV.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:PrimitiveType"/>.
		/// </param>
		/// <param name="indirect">
		/// A <see cref="T:object"/>.
		/// </param>
		/// <param name="drawCount">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="maxDrawCount">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="vertexBufferCount">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_NV_bindless_multi_draw_indirect_count", Api = "gl|glcore")]
		public static void MultiDrawArraysIndirectBindNV(PrimitiveType mode, object indirect, int drawCount, int maxDrawCount, int stride, int vertexBufferCount)
		{
			GCHandle pin_indirect = GCHandle.Alloc(indirect, GCHandleType.Pinned);
			try {
				MultiDrawArraysIndirectBindNV(mode, pin_indirect.AddrOfPinnedObject(), drawCount, maxDrawCount, stride, vertexBufferCount);
			} finally {
				pin_indirect.Free();
			}
		}

		/// <summary>
		/// [GL] glMultiDrawElementsIndirectBindlessCountNV: Binding for glMultiDrawElementsIndirectBindlessCountNV.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:PrimitiveType"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:DrawElementsType"/>.
		/// </param>
		/// <param name="indirect">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawCount">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="maxDrawCount">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="vertexBufferCount">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_NV_bindless_multi_draw_indirect_count", Api = "gl|glcore")]
		public static void MultiDrawElementsIndirectBindNV(PrimitiveType mode, DrawElementsType type, IntPtr indirect, int drawCount, int maxDrawCount, int stride, int vertexBufferCount)
		{
			Debug.Assert(Delegates.pglMultiDrawElementsIndirectBindlessCountNV != null, "pglMultiDrawElementsIndirectBindlessCountNV not implemented");
			Delegates.pglMultiDrawElementsIndirectBindlessCountNV((int)mode, (int)type, indirect, drawCount, maxDrawCount, stride, vertexBufferCount);
			LogCommand("glMultiDrawElementsIndirectBindlessCountNV", null, mode, type, indirect, drawCount, maxDrawCount, stride, vertexBufferCount			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glMultiDrawElementsIndirectBindlessCountNV: Binding for glMultiDrawElementsIndirectBindlessCountNV.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:PrimitiveType"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:DrawElementsType"/>.
		/// </param>
		/// <param name="indirect">
		/// A <see cref="T:object"/>.
		/// </param>
		/// <param name="drawCount">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="maxDrawCount">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="vertexBufferCount">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_NV_bindless_multi_draw_indirect_count", Api = "gl|glcore")]
		public static void MultiDrawElementsIndirectBindNV(PrimitiveType mode, DrawElementsType type, object indirect, int drawCount, int maxDrawCount, int stride, int vertexBufferCount)
		{
			GCHandle pin_indirect = GCHandle.Alloc(indirect, GCHandleType.Pinned);
			try {
				MultiDrawElementsIndirectBindNV(mode, type, pin_indirect.AddrOfPinnedObject(), drawCount, maxDrawCount, stride, vertexBufferCount);
			} finally {
				pin_indirect.Free();
			}
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_bindless_multi_draw_indirect_count", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiDrawArraysIndirectBindlessCountNV(int mode, IntPtr indirect, int drawCount, int maxDrawCount, int stride, int vertexBufferCount);

			[RequiredByFeature("GL_NV_bindless_multi_draw_indirect_count", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glMultiDrawArraysIndirectBindlessCountNV pglMultiDrawArraysIndirectBindlessCountNV;

			[RequiredByFeature("GL_NV_bindless_multi_draw_indirect_count", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiDrawElementsIndirectBindlessCountNV(int mode, int type, IntPtr indirect, int drawCount, int maxDrawCount, int stride, int vertexBufferCount);

			[RequiredByFeature("GL_NV_bindless_multi_draw_indirect_count", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glMultiDrawElementsIndirectBindlessCountNV pglMultiDrawElementsIndirectBindlessCountNV;

		}
	}

}
