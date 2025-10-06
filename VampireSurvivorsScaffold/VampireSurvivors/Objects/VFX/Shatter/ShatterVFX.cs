/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.VFX.Shatter
{
	[DisallowMultipleComponent]
	[RequireComponent(typeof(SpriteRenderer))]
	public class ShatterVFX : GameMonoBehaviour // TypeDefIndex: 15200
	{
		// Fields
		public ShatterDetails shatterDetails; // 0x28
		private Vector3[] originalShatterPieceLocations; // 0x30
		private Quaternion[] originalShatterPieceRotations; // 0x38
		private Transform shatterGameObjectTransform; // 0x40
		private bool error; // 0x48
	
		// Nested types
		public enum ShatterType // TypeDefIndex: 15198
		{
			Grid = 0,
			Radial = 1
		}
	
		[Serializable]
		public class ShatterDetails // TypeDefIndex: 15199
		{
			// Fields
			public ShatterType shatterType; // 0x10
			public int horizontalCuts; // 0x14
			public int verticalCuts; // 0x18
			public int horizontalZigzagPoints; // 0x1C
			public float horizontalZigzagSize; // 0x20
			public int verticalZigzagPoints; // 0x24
			public float verticalZigzagSize; // 0x28
			public int radialSectors; // 0x2C
			public int radials; // 0x30
			public Vector2 radialCentre; // 0x34
			public bool randomizeAtRunTime; // 0x3C
			public int randomSeed; // 0x40
			public float randomness; // 0x44
	
			// Constructors
			public ShatterDetails() {} // 0x0000000186A8F830-0x0000000186A8F870
		}
	
		// Constructors
		public ShatterVFX() {} // 0x0000000184C44C90-0x0000000184C44CE0
	
		// Methods
		private void Reset() {} // 0x0000000186A8B1B0-0x0000000186A8B270
		public SpriteRenderer[] Shatter() => default; // 0x0000000186A8B270-0x0000000186A8D0D0
		public Vector2[][] generateShatterShapes() => default; // 0x0000000186A8D0D0-0x0000000186A8E950
		private static bool transformArrayContainsGameObject(Transform[] transformArray, string gameObjectName) => default; // 0x0000000186A8E950-0x0000000186A8EA10
		private void shatter() {} // 0x0000000186A8EA10-0x0000000186A8ED20
		public void Destroy() {} // 0x0000000186A8ED20-0x0000000186A8F050
		private ushort[] generateMeshTriangles(Vector2[] vertices) => default; // 0x0000000186A8F050-0x0000000186A8F830
	}
}
