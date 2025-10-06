/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Geom
{
	[Serializable]
	public class Polygon : BaseGeom // TypeDefIndex: 18313
	{
		// Fields
		public List<float2> _points; // 0x10
	
		// Constructors
		public Polygon() {} // Dummy constructor
		public Polygon(List<float2> points) {} // 0x0000000181958310-0x0000000181958370
	
		// Methods
		public void DrawDebug(Color c) {} // 0x000000018672DC50-0x000000018672DE20
		public bool IsPointInside(float2 point) => default; // 0x000000018672DE20-0x000000018672E0D0
		public float2 ClosestPositionOnAnyEdge(float2 point) => default; // 0x000000018672E0D0-0x000000018672E340
		public bool LineToPolygonIntersection(float2 lineStart, float2 lineEnd, out float2 intersectionPoint) {
			intersectionPoint = default;
			return default;
		} // 0x000000018672E340-0x000000018672E5B0
		private float2 ClosestPositionOnEdge(float2 pointA, float2 pointB, float2 point) => default; // 0x000000018672E5B0-0x000000018672E660
	}
}
