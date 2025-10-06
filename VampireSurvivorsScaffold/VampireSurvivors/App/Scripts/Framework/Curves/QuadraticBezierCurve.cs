/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Scripts.Framework.Curves
{
	public class QuadraticBezierCurve // TypeDefIndex: 18833
	{
		// Fields
		private Vector2 _p0; // 0x10
		private Vector2 _p1; // 0x18
		private Vector2 _p2; // 0x20
	
		// Constructors
		public QuadraticBezierCurve() {} // Dummy constructor
		public QuadraticBezierCurve(Vector2 p0, Vector2 p1, Vector2 p2) {} // 0x00000001868488A0-0x00000001868488B0
	
		// Methods
		public Vector2 GetPoint(float t) => default; // 0x00000001868488B0-0x0000000186848930
		public Vector3[] GetPoints(int points) => default; // 0x0000000186848930-0x0000000186848B30
		private float P0(float t, float p) => default; // 0x0000000186848B30-0x0000000186848B50
		private float P1(float t, float p) => default; // 0x0000000186848B50-0x0000000186848B70
		private float P2(float t, float p) => default; // 0x0000000186848B70-0x0000000186848B80
		private float QuadraticBezierInterpolation(float t, float p0, float p1, float p2) => default; // 0x0000000186848B80-0x0000000186848BC0
	}
}
