/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Tools
{
	public static class CameraExtensions // TypeDefIndex: 14266
	{
		// Fields
		private static Bounds _cachedCamBounds; // 0x00
	
		// Constructors
		static CameraExtensions() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Extension methods
		public static Bounds OrthographicBounds(this Camera camera) => default; // 0x00000001870441B0-0x0000000187044350
		public static Bounds OrthographicBoundsIgnoringBorders(this Camera camera) => default; // 0x0000000187044350-0x0000000187044470
		public static bool IsObjectVisible(this Camera camera, UnityEngine.Renderer renderer) => default; // 0x0000000187044470-0x0000000187044660
		public static Vector2 GetScreenBounds(this Camera camera, bool usePixels = false /* Metadata: 0x01977121 */) => default; // 0x0000000187044660-0x0000000187044700
		public static float GetRtZoomScaling(this Camera camera) => default; // 0x0000000187044700-0x0000000187044710
		public static int2 GetRenderTextureSize(this Camera camera) => default; // 0x0000000187044710-0x0000000187044970
		public static void ResetOrthographicSize(this Camera camera) {} // 0x0000000187044970-0x00000001870449F0
		public static void ResetOrthographicAndRenderTextureSize(this Camera camera) {} // 0x00000001870449F0-0x0000000187044B80
	}
}
