/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Tools
{
	public class PhaserSpline // TypeDefIndex: 14279
	{
		// Fields
		private List<Vector2> _points; // 0x10
	
		// Constructors
		public PhaserSpline() {} // Dummy constructor
		public PhaserSpline(List<Vector2> points) {} // 0x0000000181958310-0x0000000181958370
		public PhaserSpline(List<float> points) {} // 0x00000001870493D0-0x0000000187049530
	
		// Methods
		public Vector2 GetPoint(float t) => default; // 0x0000000187049530-0x0000000187049840
		public void Dispose() {} // 0x0000000187049840-0x00000001870498D0
		private float CatmullRom(float t, float p0, float p1, float p2, float p3) => default; // 0x00000001870498D0-0x0000000187049990
	}
}
