/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Unity.Mathematics;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class FB_MetalClawProjectile : Projectile // TypeDefIndex: 15476
	{
		// Fields
		private MultiTargetTween _tweenOffSetIn; // 0xD0
		private MultiTargetTween _tweenOffSetOut; // 0xD8
		private float _previousArea; // 0xE0
		private float _detuneMul; // 0xE4
		private float2 startOffsetRight; // 0xE8
		private float2 finishOffsetRight; // 0xF0
		private float2 startOffsetLeft; // 0xF8
		private float2 finishOffsetLeft; // 0x100
		public float offsetX; // 0x108
		public float offsetY; // 0x10C
		private float _areaScale; // 0x110
		private float _hitboxRadius; // 0x114
		private PhaserSprite _displaySprite; // 0x118
	
		// Constructors
		public FB_MetalClawProjectile() {} // 0x0000000186C26320-0x0000000186C263C0
	
		// Methods
		public void SetDetune(float value = 0f /* Metadata: 0x01977645 */) {} // 0x0000000185138430-0x0000000185138440
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C25570-0x0000000186C26230
		public override void InternalUpdate() {} // 0x0000000186C26230-0x0000000186C262D0
		public override void Despawn() {} // 0x0000000186C262D0-0x0000000186C26320
	}
}
