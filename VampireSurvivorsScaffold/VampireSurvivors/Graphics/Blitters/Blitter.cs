/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.IL2CPP.CompilerServices;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Rendering;
using VampireSurvivors.Framework.Particles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Graphics.Blitters
{
	[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
	public class Blitter : GameMonoBehaviour // TypeDefIndex: 14545
	{
		// Fields
		private MeshFilter _meshFilter; // 0x28
		private MeshRenderer _meshRenderer; // 0x30
		private BlitterRenderMode _renderMode; // 0x38
		private readonly List<Bob> _bobs; // 0x40
		private Texture2D _atlasTexture; // 0x48
		private Mesh _mesh; // 0x50
		private static Transform _blittersSceneParent; // 0x00
		private NativeArray<BobFullVertex> vertices; // 0x58
		private NativeArray<ushort> indices; // 0x68
		private VertexAttributeDescriptor[] meshDescriptor; // 0x78
		private static readonly ProfilerMarker s_updateMarker; // 0x08
		private static readonly ProfilerMarker s_updateClearMarker; // 0x10
		private static readonly ProfilerMarker s_updateApplyMeshMarker; // 0x18
	
		// Properties
		public List<Bob> Children { get => default; } // 0x0000000180B15750-0x0000000180B15760 
		public Mesh Mesh { get => default; } // 0x000000018197EAB0-0x000000018197EAC0 
		public Material Material { get => default; } // 0x00000001871ABAA0-0x00000001871ABAC0 
	
		// Nested types
		private struct Index // TypeDefIndex: 14544
		{
			// Fields
			public ushort b1; // 0x00
			public ushort b2; // 0x02
			public ushort b3; // 0x04
			public ushort b4; // 0x06
			public ushort b5; // 0x08
			public ushort b6; // 0x0A
	
			// Methods
			public void Setup() {} // 0x00000001871AD690-0x00000001871AD6B0
			public void Increment() {} // 0x00000001871AD6B0-0x00000001871AD6D0
		}
	
		// Constructors
		public Blitter() {} // 0x00000001871AD3D0-0x00000001871AD5B0
		static Blitter() {} // 0x00000001871AD5B0-0x00000001871AD690
	
		// Methods
		private new void Awake() {} // 0x00000001871ABAC0-0x00000001871ABBF0
		private void Start() {} // 0x00000001871ABBF0-0x00000001871ABC00
		protected override void OnUpdate() {} // 0x00000001871ABC00-0x00000001871ABC10
		protected override void OnDestroy() {} // 0x00000001871ABC10-0x00000001871ABCB0
		private void OnDrawGizmosSelected() {} // 0x0000000180B15170-0x0000000180B15180
		public static Blitter CreateBlitter(VampireSurvivors.Framework.Particles.BlendMode blendMode = VampireSurvivors.Framework.Particles.BlendMode.Normal /* Metadata: 0x01977171 */, Texture2D atlasTexture = null) => default; // 0x00000001871ABCB0-0x00000001871ABF40
		public Bob CreateBob(Vector2 pos, Sprite sprite) => default; // 0x00000001871ABF40-0x00000001871AC030
		public void RemoveBob(Bob bob) {} // 0x00000001871AC030-0x00000001871AC100
		public void SetAtlasTexture(Texture2D atlasTexture) {} // 0x00000001871AC100-0x00000001871AC180
		public void SetRenderMode(BlitterRenderMode renderMode) {} // 0x0000000181E091B0-0x0000000181E091C0
		public void SetBlendMode(VampireSurvivors.Framework.Particles.BlendMode blendMode) {} // 0x00000001871AC180-0x00000001871AC210
		public void SetDepth(int depth) {} // 0x00000001871AC210-0x00000001871AC230
		public void ForceUpdate() {} // 0x00000001871AC230-0x00000001871AC240
		private void GrabComponents() {} // 0x00000001871AC240-0x00000001871AC360
		private void EnsureArraySizes(int numQuads) {} // 0x00000001871AC360-0x00000001871AC730
		private void Init() {} // 0x00000001871AC730-0x00000001871AC930
		[Il2CppSetOption(Option.NullChecks, false)]
		private ref BobVertexData GetBobVertexData(Bob bob, int idx) => ref _refReturnTypeForGetBobVertexData; // 0x00000001871AC930-0x00000001871AC950
		private ref BobVertexData _refReturnTypeForGetBobVertexData; // Dummy field
		public void ManualUpdate() {} // 0x00000001871AC230-0x00000001871AC240
		private void UpdateBobs() {} // 0x00000001871AC950-0x00000001871AD0E0
		private bool IsMeshOk(Mesh mesh) => default; // 0x00000001871AD0E0-0x00000001871AD1C0
		private static void EnsureSceneParent() {} // 0x00000001871AD1C0-0x00000001871AD3D0
	}
}
