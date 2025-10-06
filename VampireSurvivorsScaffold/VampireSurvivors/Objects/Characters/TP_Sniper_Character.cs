/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Graphics;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class TP_Sniper_Character : TP_Character // TypeDefIndex: 17117
	{
		// Fields
		[SerializeField]
		private Vector2 _whipOffset; // 0x3F0
		[SerializeField]
		private float _spriteWhipOffset; // 0x3F8
		private SpriteRenderer _back2Sprite; // 0x400
		private SpriteAnimation _back2Anim; // 0x408
		private const string IdleAnimName = "idle"; // Metadata: 0x01978009
		private const string SniperTextureName = "character_tp_sniper"; // Metadata: 0x0197800E
	
		// Properties
		public override float2 GetVectorWhipOffset { get => default; } // 0x000000018716FFA0-0x0000000187170060 
		public override float GetSpriteWhipOffset { get => default; } // 0x0000000187170060-0x0000000187170070 
	
		// Constructors
		public TP_Sniper_Character() {} // 0x0000000187107F90-0x0000000187107FA0
	
		// Methods
		public override bool ShouldCollideWithWalls() => default; // 0x0000000180B15290-0x0000000180B152A0
		protected override void OnStop() {} // 0x0000000180B15170-0x0000000180B15180
		public override void AfterFullInitialization() {} // 0x0000000187179CD0-0x000000018717A310
		private void LateUpdate() {} // 0x000000018717A310-0x000000018717A390
	}
}
