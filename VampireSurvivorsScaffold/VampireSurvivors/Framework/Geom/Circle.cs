/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Geom
{
	public class Circle : BaseGeom // TypeDefIndex: 18310
	{
		// Fields
		private float _x; // 0x10
		private float _y; // 0x14
		private float _radius; // 0x18
		private float _diameter; // 0x1C
	
		// Properties
		public float X { get => default; set {} } // 0x0000000182740170-0x0000000182740180 0x0000000182740190-0x00000001827401A0
		public float Y { get => default; set {} } // 0x00000001828A3D30-0x00000001828A3D40 0x00000001828A3D40-0x00000001828A3D50
		public float Radius { get => default; set {} } // 0x000000018264AEB0-0x000000018264AEC0 0x000000018672D480-0x000000018672D490
		public float Diameter { get => default; set {} } // 0x0000000182A6AC90-0x0000000182A6ACA0 0x000000018672D490-0x000000018672D4B0
		public Vector2 Position { get => default; set {} } // 0x0000000184642A50-0x0000000184642A70 0x0000000185B7F100-0x0000000185B7F120
		public bool IsEmpty { get => default; } // 0x000000018672D4B0-0x000000018672D4C0 
		public float Left { get => default; } // 0x000000018672D4C0-0x000000018672D4D0 
		public float Right { get => default; } // 0x000000018672D4D0-0x000000018672D4E0 
		public float Top { get => default; } // 0x000000018672D4E0-0x000000018672D4F0 
		public float Bottom { get => default; } // 0x000000018672D4F0-0x000000018672D500 
	
		// Constructors
		public Circle() {} // 0x0000000180B15170-0x0000000180B15180
		public Circle(float x, float y, float radius) {} // 0x00000001827EFFF0-0x00000001827F0000
	
		// Methods
		public List<Vector2> GetPoints(int quantity) => default; // 0x000000018672D500-0x000000018672D6A0
		public Vector2 CircumferencePoint(float angle) => default; // 0x000000018672D6A0-0x000000018672D700
		public void SetPosition(float x, float y) {} // 0x00000001828A3D20-0x00000001828A3D30
		public Vector2 GetRandomPoint() => default; // 0x000000018672D700-0x000000018672D860
		public bool Contains(Vector2 point) => default; // 0x000000018672D860-0x000000018672D900
	}
}
