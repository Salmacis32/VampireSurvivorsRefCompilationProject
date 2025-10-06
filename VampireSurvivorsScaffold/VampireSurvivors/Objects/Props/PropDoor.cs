/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Props
{
	public class PropDoor : GameMonoBehaviour // TypeDefIndex: 15365
	{
		// Fields
		[SerializeField]
		private ArcadeSprite _sideA; // 0x28
		[SerializeField]
		private ArcadeSprite _sideB; // 0x30
		[SerializeField]
		private ArcadeSprite _openingZone; // 0x38
		[SerializeField]
		private Vector3 _openingScaleA; // 0x40
		[SerializeField]
		private Vector3 _openingScaleB; // 0x4C
		[SerializeField]
		private Vector2 _originA; // 0x58
		[SerializeField]
		private Vector2 _originB; // 0x60
		[SerializeField]
		private float _openingSpeed; // 0x68
		[SerializeField]
		private float _closingSpeed; // 0x6C
		[SerializeField]
		private SpriteRenderer _sideARenderer; // 0x70
		[SerializeField]
		private SpriteRenderer _sideBRenderer; // 0x78
		private Material _sideAMaterial; // 0x80
		private Material _sideBMaterial; // 0x88
		private float _proportionClosed; // 0x90
		private Vector3 _startingScaleA; // 0x94
		private Vector3 _startingScaleB; // 0xA0
		private bool _anyoneInRange; // 0xAC
	
		// Constructors
		public PropDoor() {} // 0x0000000186B9B4F0-0x0000000186B9B5A0
	
		// Methods
		private void Start() {} // 0x0000000186B9A100-0x0000000186B9A390
		protected override void OnEnable() {} // 0x0000000186B9A390-0x0000000186B9A400
		protected override void OnDisable() {} // 0x0000000186B9A400-0x0000000186B9A4F0
		protected override void OnUpdate() {} // 0x0000000186B9A4F0-0x0000000186B9A940
		private void AddSide(ArcadeSprite side, Vector2 origin) {} // 0x0000000186B9A940-0x0000000186B9AF80
		private void RemoveSide(ArcadeSprite side) {} // 0x0000000186B9AF80-0x0000000186B9B060
		private void AddOpeningZone(ArcadeSprite zone) {} // 0x0000000186B9B060-0x0000000186B9B420
		private bool OnPlayerOverlapsZone(CallbackContext context, ArcadeColliderType zone, ArcadeColliderType player) => default; // 0x0000000186B9B420-0x0000000186B9B430
		private void RemoveOpeningZone(ArcadeSprite zone) {} // 0x0000000186B9B430-0x0000000186B9B4F0
	}
}
