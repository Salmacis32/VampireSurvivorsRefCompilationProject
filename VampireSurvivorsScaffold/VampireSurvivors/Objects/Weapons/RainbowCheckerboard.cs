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
	public class RainbowCheckerboard : GameMonoBehaviour // TypeDefIndex: 16116
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
		private float _angle; // 0x68
	
		// Constructors
		public RainbowCheckerboard() {} // 0x0000000186F119D0-0x0000000186F11A20
	
		// Methods
		private void Start() {} // 0x0000000186F12470-0x0000000186F12480
		private void Initialise() {} // 0x0000000186F12480-0x0000000186F12820
		protected override void OnUpdate() {} // 0x0000000186F12820-0x0000000186F12830
		protected void LateUpdate() {} // 0x0000000186F12830-0x0000000186F12980
		private void UpdateShader() {} // 0x0000000186F12980-0x0000000186F12CA0
	}
}
