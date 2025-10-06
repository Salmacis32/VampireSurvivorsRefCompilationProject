/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

public static class UIGradientUtils // TypeDefIndex: 13876
{
	// Fields
	private static Vector2[] ms_verticesPositions; // 0x00

	// Properties
	public static Vector2[] VerticePositions { get; } // 0x00000001865B8AD0-0x00000001865B8B30 

	// Nested types
	public struct Matrix2x3 // TypeDefIndex: 13875
	{
		// Fields
		public float m00; // 0x00
		public float m01; // 0x04
		public float m02; // 0x08
		public float m10; // 0x0C
		public float m11; // 0x10
		public float m12; // 0x14

		// Constructors
		public Matrix2x3(float m00, float m01, float m02, float m10, float m11, float m12) {
			this.m00 = default;
			this.m01 = default;
			this.m02 = default;
			this.m10 = default;
			this.m11 = default;
			this.m12 = default;
		} // 0x00000001865B91A0-0x00000001865B91D0

		// Methods
		public static Vector2 operator *(Matrix2x3 m, Vector2 v) => default; // 0x00000001865B91D0-0x00000001865B9260
	}

	// Constructors
	static UIGradientUtils() {} // 0x00000001865B8FA0-0x00000001865B91A0

	// Methods
	public static Matrix2x3 LocalPositionMatrix(Rect rect, Vector2 dir) => default; // 0x00000001865B89F0-0x00000001865B8AD0
	public static Vector2 RotationDir(float angle) => default; // 0x00000001865B8B30-0x00000001865B8B80
	public static Vector2 CompensateAspectRatio(Rect rect, Vector2 dir) => default; // 0x00000001865B8B80-0x00000001865B8BB0
	public static float InverseLerp(float a, float b, float v) => default; // 0x00000001865B8BB0-0x00000001865B8BD0
	public static Color Bilerp(Color a1, Color a2, Color b1, Color b2, Vector2 t) => default; // 0x00000001865B8BD0-0x00000001865B8D50
	public static void Lerp(UIVertex a, UIVertex b, float t, ref UIVertex c) {} // 0x00000001865B8D50-0x00000001865B8FA0
}

