/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Graphics.Blitters
{
	[Serializable]
	public class Bob : IDisposable // TypeDefIndex: 14547
	{
		// Fields
		private const int GrowAmount = 256; // Metadata: 0x01977174
		private static Stack<Bob> emptyBobs; // 0x00
		private float2 _position; // 0x10
		private float2 _scale; // 0x18
		private Sprite _sprite; // 0x20
		private static Color32 _white; // 0x08
		[NonSerialized]
		internal BobVertexData[] vertexData; // 0x28
		private BobData _bobData; // 0x30
		private bool _disposed; // 0x38
		[NonSerialized]
		public float2 halfSize; // 0x3C
		private Rect spriteRect; // 0x44
	
		// Properties
		public float2 Position { get => default; set {} } // 0x0000000184642A50-0x0000000184642A70 0x0000000182626A90-0x0000000182626AA0
		public float2 Scale { get => default; set {} } // 0x00000001833052F0-0x0000000183305310 0x0000000182759640-0x0000000182759650
		public Sprite Sprite { get => default; } // 0x0000000180B15530-0x0000000180B15540 
		public BobData BobData { get => default; set {} } // 0x0000000180B15550-0x0000000180B15560 0x0000000180B1D520-0x0000000180B1D580
	
		// Constructors
		private Bob() {} // 0x00000001871AD6F0-0x00000001871AD810
		private Bob(Vector2 position, Sprite sprite, Color32 tint1, Color32 tint2, Color32 tint3, Color32 tint4) {} // 0x00000001871ADBA0-0x00000001871ADD10
		static Bob() {} // 0x00000001871AE3B0-0x00000001871AE4B0
	
		// Methods
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Option.NullChecks, false)]
		internal ref BobVertexData GetVertexData(int id) => ref _refReturnTypeForGetVertexData; // 0x00000001871AD6D0-0x00000001871AD6F0
		private ref BobVertexData _refReturnTypeForGetVertexData; // Dummy field
		private void Reset(Vector2 position, Sprite sprite, Color32 tint1, Color32 tint2, Color32 tint3, Color32 tint4) {} // 0x00000001871AD810-0x00000001871ADBA0
		public static Bob Create(Vector2 position, Sprite sprite) => default; // 0x00000001871ADD10-0x00000001871ADD90
		public static Bob Create(Vector2 position, Sprite sprite, Color32 tint) => default; // 0x00000001871ADD90-0x00000001871ADE10
		public static Bob Create(Vector2 position, Sprite sprite, Color32 tint1, Color32 tint2, Color32 tint3, Color32 tint4) => default; // 0x00000001871ADE10-0x00000001871AE0A0
		private void LoadUVs() {} // 0x00000001871AE0A0-0x00000001871AE260
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public void SetAlpha(float alpha) {} // 0x0000000186989630-0x00000001869896A0
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public void SetAlpha(float alpha, int vertIndex) {} // 0x00000001871AE260-0x00000001871AE280
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public void SetTint(Color32 tint) {} // 0x00000001871AE280-0x00000001871AE2A0
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public void SetTint(Color32 tint1, Color32 tint2, Color32 tint3, Color32 tint4) {} // 0x00000001871AE2A0-0x00000001871AE2D0
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public void SetTint(Color32 tint, int vertIndex) {} // 0x00000001871AE2D0-0x00000001871AE2F0
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public Color32 GetTint() => default; // 0x00000001871AE2F0-0x00000001871AE300
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public float GetAlpha() => default; // 0x00000001871AE300-0x00000001871AE310
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public Color32 GetTint(int vertIndex) => default; // 0x00000001871AE310-0x00000001871AE320
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public void Dispose() {} // 0x00000001871AE320-0x00000001871AE3B0
	}
}
