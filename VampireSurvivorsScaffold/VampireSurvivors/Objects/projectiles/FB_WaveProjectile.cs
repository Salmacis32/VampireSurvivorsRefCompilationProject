/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class FB_WaveProjectile : Projectile // TypeDefIndex: 15490
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _SpriteRenderer; // 0xD0
		[SerializeField]
		private SpriteTrail _Trail; // 0xD8
		private MultiTargetTween _scaleTween; // 0xE0
		private MultiTargetTween _fadeTween; // 0xE8
		private PhaserSprite _sonicSprite; // 0xF0
		private SpriteAnimation _spriteAnim; // 0xF8
		private bool _isFadingOut; // 0x100
		public bool IsCharged; // 0x101
	
		// Constructors
		public FB_WaveProjectile() {} // 0x0000000186C33840-0x0000000186C33890
	
		// Methods
		protected override void Awake() {} // 0x0000000186C323C0-0x0000000186C326E0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C326E0-0x0000000186C32C50
		public void MakeBasicProjectile() {} // 0x0000000186C32C50-0x0000000186C32EB0
		public void MakeChargedProjectile() {} // 0x0000000186C32EB0-0x0000000186C33110
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186C33110-0x0000000186C33120
		protected override void OnHasHitAnotherPlayerObject(IDamageable other) {} // 0x0000000186C33120-0x0000000186C331D0
		protected void OnHasHitAnObjectLogic(IDamageable other, bool triggerHit) {} // 0x0000000186C331D0-0x0000000186C332C0
		public override void InternalUpdate() {} // 0x0000000186C332C0-0x0000000186C33410
		public override void Despawn() {} // 0x0000000186C33410-0x0000000186C33550
		private void FadeOut() {} // 0x0000000186C33550-0x0000000186C33840
	}
}
