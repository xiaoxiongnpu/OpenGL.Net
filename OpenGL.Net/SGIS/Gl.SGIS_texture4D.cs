
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
		/// [GL] Value of GL_PACK_SKIP_VOLUMES_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		public const int PACK_SKIP_VOLUMES_SGIS = 0x8130;

		/// <summary>
		/// [GL] Value of GL_PACK_IMAGE_DEPTH_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		public const int PACK_IMAGE_DEPTH_SGIS = 0x8131;

		/// <summary>
		/// [GL] Value of GL_UNPACK_SKIP_VOLUMES_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		public const int UNPACK_SKIP_VOLUMES_SGIS = 0x8132;

		/// <summary>
		/// [GL] Value of GL_UNPACK_IMAGE_DEPTH_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		public const int UNPACK_IMAGE_DEPTH_SGIS = 0x8133;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_4D_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		public const int TEXTURE_4D_SGIS = 0x8134;

		/// <summary>
		/// [GL] Value of GL_PROXY_TEXTURE_4D_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		public const int PROXY_TEXTURE_4D_SGIS = 0x8135;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_4DSIZE_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		public const int TEXTURE_4DSIZE_SGIS = 0x8136;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_WRAP_Q_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		public const int TEXTURE_WRAP_Q_SGIS = 0x8137;

		/// <summary>
		/// [GL] Value of GL_MAX_4D_TEXTURE_SIZE_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		public const int MAX_4D_TEXTURE_SIZE_SGIS = 0x8138;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_4D_BINDING_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		public const int TEXTURE_4D_BINDING_SGIS = 0x814F;

		/// <summary>
		/// [GL] glTexImage4DSGIS: Binding for glTexImage4DSGIS.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:InternalFormat"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="size4d">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_texture4D")]
		public static void TexImage4DSGIS(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int size4d, int border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTexImage4DSGIS != null, "pglTexImage4DSGIS not implemented");
			Delegates.pglTexImage4DSGIS((int)target, level, (int)internalformat, width, height, depth, size4d, border, (int)format, (int)type, pixels);
			LogCommand("glTexImage4DSGIS", null, target, level, internalformat, width, height, depth, size4d, border, format, type, pixels			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glTexImage4DSGIS: Binding for glTexImage4DSGIS.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:InternalFormat"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="size4d">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:object"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_texture4D")]
		public static void TexImage4DSGIS(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int size4d, int border, PixelFormat format, PixelType type, object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				TexImage4DSGIS(target, level, internalformat, width, height, depth, size4d, border, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// [GL] glTexSubImage4DSGIS: Binding for glTexSubImage4DSGIS.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="woffset">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="size4d">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_texture4D")]
		public static void TexSubImage4DSGIS(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int woffset, int width, int height, int depth, int size4d, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTexSubImage4DSGIS != null, "pglTexSubImage4DSGIS not implemented");
			Delegates.pglTexSubImage4DSGIS((int)target, level, xoffset, yoffset, zoffset, woffset, width, height, depth, size4d, (int)format, (int)type, pixels);
			LogCommand("glTexSubImage4DSGIS", null, target, level, xoffset, yoffset, zoffset, woffset, width, height, depth, size4d, format, type, pixels			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glTexSubImage4DSGIS: Binding for glTexSubImage4DSGIS.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="woffset">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="size4d">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:object"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_texture4D")]
		public static void TexSubImage4DSGIS(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int woffset, int width, int height, int depth, int size4d, PixelFormat format, PixelType type, object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				TexSubImage4DSGIS(target, level, xoffset, yoffset, zoffset, woffset, width, height, depth, size4d, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_SGIS_texture4D")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexImage4DSGIS(int target, int level, int internalformat, int width, int height, int depth, int size4d, int border, int format, int type, IntPtr pixels);

			[RequiredByFeature("GL_SGIS_texture4D")]
			[ThreadStatic]
			internal static glTexImage4DSGIS pglTexImage4DSGIS;

			[RequiredByFeature("GL_SGIS_texture4D")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexSubImage4DSGIS(int target, int level, int xoffset, int yoffset, int zoffset, int woffset, int width, int height, int depth, int size4d, int format, int type, IntPtr pixels);

			[RequiredByFeature("GL_SGIS_texture4D")]
			[ThreadStatic]
			internal static glTexSubImage4DSGIS pglTexSubImage4DSGIS;

		}
	}

}
