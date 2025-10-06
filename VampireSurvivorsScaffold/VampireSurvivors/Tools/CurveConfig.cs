/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Dreamteck.Splines;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Tools
{
	public class CurveConfig : MonoBehaviour // TypeDefIndex: 14270
	{
		// Fields
		private SplineComputer _spline; // 0x20
		[SerializeField]
		private float Scale; // 0x28
		[SerializeField]
		private bool InvertPositiveNegative; // 0x2C
		[SerializeField]
		private bool Mirror; // 0x2D
		[SerializeField]
		private List<CurvePoint> Points; // 0x30
	
		// Constructors
		public CurveConfig() {} // 0x0000000187046850-0x0000000187046950
	
		// Methods
		public void Generate() {} // 0x0000000187046150-0x0000000187046720
		public void Clear() {} // 0x0000000187046720-0x0000000187046850
	}
}
