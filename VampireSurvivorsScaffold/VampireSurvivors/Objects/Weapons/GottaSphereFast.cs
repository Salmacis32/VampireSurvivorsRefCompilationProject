/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	[DefaultExecutionOrder(960)]
	public class GottaSphereFast : GameMonoBehaviour // TypeDefIndex: 16114
	{
		// Fields
		public float alpha; // 0x28
		private bool _initialised; // 0x2C
		private Transform _cachedTransform; // 0x30
		private Camera _mainCam; // 0x38
		private Material _shaderRTMaterial; // 0x40
		[SerializeField]
		private Mesh _quadMesh; // 0x48
		[SerializeField]
		private RenderTexture _renderTexture; // 0x50
		[SerializeField]
		private MeshRenderer _shaderMesh; // 0x58
		[SerializeField]
		private MeshRenderer _blitRenderer; // 0x60
		private float _scrollX; // 0x68
		private float _scrollY; // 0x6C
	
		// Constructors
		public GottaSphereFast() {} // 0x0000000186F119D0-0x0000000186F11A20
	
		// Methods
		private void Start() {} // 0x0000000186F10F00-0x0000000186F10F10
		private void Initialise() {} // 0x0000000186F10F10-0x0000000186F112B0
		protected override void OnUpdate() {} // 0x0000000186F112B0-0x0000000186F112C0
		protected void LateUpdate() {} // 0x0000000186F112C0-0x0000000186F114E0
		private void UpdateShader() {} // 0x0000000186F114E0-0x0000000186F119D0
	}
}
