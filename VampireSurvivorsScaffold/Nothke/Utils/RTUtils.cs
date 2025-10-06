/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace Nothke.Utils
{
	public static class RTUtils // TypeDefIndex: 13907
	{
		// Fields
		private static Mesh quad; // 0x00
		private static Shader blitShader; // 0x08
		private static Material blitMaterial; // 0x10
		private static RenderTexture prevRT; // 0x18
	
		// Methods
		public static Mesh GetQuad() => default; // 0x00000001865BD2A0-0x00000001865BD680
		public static Shader GetBlitShader() => default; // 0x00000001865BD680-0x00000001865BD8D0
		public static Material GetBlitMaterial() => default; // 0x00000001865BD8D0-0x00000001865BDA10
		public static void DrawTextureGUI(Texture texture) {} // 0x00000001865BFB50-0x00000001865BFC20
	
		// Extension methods
		public static void BeginOrthoRendering(this RenderTexture rt, float zBegin = -100f /* Metadata: 0x01976B09 */, float zEnd = 100f /* Metadata: 0x01976B0D */) {} // 0x00000001865BDA10-0x00000001865BDB10
		public static void BeginPixelRendering(this RenderTexture rt, float zBegin = -100f /* Metadata: 0x01976B11 */, float zEnd = 100f /* Metadata: 0x01976B15 */) {} // 0x00000001865BDB10-0x00000001865BDC70
		public static void BeginPerspectiveRendering(this RenderTexture rt, float fov, [IsReadOnly] in Vector3 position, [IsReadOnly] in Quaternion rotation, float zNear = 0.01f /* Metadata: 0x01976B19 */, float zFar = 1000f /* Metadata: 0x01976B1D */) {} // 0x00000001865BDC70-0x00000001865BDF30
		public static void BeginRendering(this RenderTexture rt, Matrix4x4 projectionMatrix) {} // 0x00000001865BDF30-0x00000001865BE380
		public static void EndRendering(this RenderTexture rt) {} // 0x00000001865BE380-0x00000001865BE4D0
		public static void DrawMesh(this RenderTexture rt, Mesh mesh, Material material, [IsReadOnly] in Matrix4x4 objectMatrix, int pass = 0 /* Metadata: 0x01976B21 */) {} // 0x00000001865BE4D0-0x00000001865BE600
		public static void DrawTMPText(this RenderTexture rt, TMP_Text text, [IsReadOnly] in Vector2 position, float size) {} // 0x00000001865BE600-0x00000001865BE850
		public static void DrawTMPText(this RenderTexture rt, TMP_Text text, [IsReadOnly] in Matrix4x4 matrix) {} // 0x00000001865BE850-0x00000001865BE8E0
		public static void BlitTMPText(this RenderTexture rt, TMP_Text text, [IsReadOnly] in Vector2 pos, float size, bool clear = true /* Metadata: 0x01976B22 */, Color clearColor = default) {} // 0x00000001865BE8E0-0x00000001865BEB40
		public static void BlitTMPText(this RenderTexture rt, TMP_Text text, Matrix4x4 objectMatrix, bool clear = true /* Metadata: 0x01976B23 */, Color clearColor = default) {} // 0x00000001865BEB40-0x00000001865BEC30
		public static void BlitMesh(this RenderTexture rt, Matrix4x4 objectMatrix, Mesh mesh, Material material, bool invertCulling = true /* Metadata: 0x01976B24 */, bool clear = true /* Metadata: 0x01976B25 */, Color clearColor = default) {} // 0x00000001865BEC30-0x00000001865BF370
		public static void DrawQuad(this RenderTexture rt, Material material, [IsReadOnly] in Rect rect) {} // 0x00000001865BF370-0x00000001865BF510
		public static void DrawSprite(this RenderTexture rt, Texture texture, [IsReadOnly] in Rect rect) {} // 0x00000001865BF510-0x00000001865BF810
		public static float Aspect(this Texture rt) => default; // 0x00000001865BF810-0x00000001865BF880
		public static Texture2D ConvertToTexture2D(this RenderTexture rt, TextureFormat format = TextureFormat.RGB24 /* Metadata: 0x01976B26 */, UnityEngine.FilterMode filterMode = UnityEngine.FilterMode.Bilinear /* Metadata: 0x01976B27 */) => default; // 0x00000001865BF880-0x00000001865BFB50
	}
}
