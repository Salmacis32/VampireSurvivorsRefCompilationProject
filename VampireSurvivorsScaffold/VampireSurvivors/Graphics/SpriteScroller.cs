/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Graphics
{
	public class SpriteScroller : GameMonoBehaviour // TypeDefIndex: 14537
	{
		// Fields
		[SerializeField]
		private float _ScrollSpeedX; // 0x28
		[SerializeField]
		private float _ScrollSpeedY; // 0x2C
		[SerializeField]
		private float _ScrollOffsetX; // 0x30
		[SerializeField]
		private float _ScrollOffsetY; // 0x34
		[SerializeField]
		private float _TextureOffsetX; // 0x38
		[SerializeField]
		private float _TextureOffsetY; // 0x3C
		private SpriteRenderer _spriteRenderer; // 0x40
		private float _prevScrollSpeedX; // 0x48
		private float _prevScrollSpeedY; // 0x4C
		private float _spriteWidthUnits; // 0x50
		private float _spriteHeightUnits; // 0x54
		private float _textureWidthUnits; // 0x58
		private float _textureHeightUnits; // 0x5C
	
		// Properties
		public SpriteRenderer Renderer { get => default; } // 0x0000000180B15750-0x0000000180B15760 
	
		// Constructors
		public SpriteScroller() {} // 0x0000000184C44C90-0x0000000184C44CE0
	
		// Methods
		private new void Awake() {} // 0x00000001871A3D80-0x00000001871A3E10
		private void Start() {} // 0x00000001871A3E10-0x00000001871A41A0
		protected override void OnPause() {} // 0x00000001871A41A0-0x00000001871A41E0
		protected override void OnResume() {} // 0x00000001871A41E0-0x00000001871A4220
		public void SetScrollSpeedX(float speed) {} // 0x00000001871A4220-0x00000001871A42B0
		public void SetScrollSpeedY(float speed) {} // 0x00000001871A42B0-0x00000001871A4340
		public void SetScrollOffsetX(float offset) {} // 0x00000001871A4340-0x00000001871A43D0
		public void SetScrollOffsetY(float offset) {} // 0x00000001871A43D0-0x00000001871A4460
		public void SetTextureOffsetX(float offset) {} // 0x00000001871A4460-0x00000001871A44F0
		public void SetTextureOffsetY(float offset) {} // 0x00000001871A44F0-0x00000001871A4580
		public void SpriteUpdated() {} // 0x00000001871A4580-0x00000001871A4D40
	}
}
