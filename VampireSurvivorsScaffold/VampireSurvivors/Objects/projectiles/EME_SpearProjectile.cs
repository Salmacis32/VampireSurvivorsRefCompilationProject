/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_SpearProjectile : Projectile // TypeDefIndex: 15841
	{
		// Fields
		[SerializeField]
		protected SpriteRenderer _SpearSprite; // 0xD0
		[SerializeField]
		protected TrailRenderer _LineTrail; // 0xD8
		protected string _spearSpriteName; // 0xE0
		protected float _area; // 0xE8
		private Vector2 _velocity; // 0xEC
		private EME_Spear1Weapon _trueWeapon; // 0xF8
		private MultiTargetTween _fadeTween; // 0x100
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x108
		private PhaserSprite _portalSprite; // 0x110
		private MultiTargetTween _portalTween; // 0x118
	
		// Properties
		protected virtual float Radius { get => default; } // 0x0000000186DE50A0-0x0000000186DE50B0 
		protected virtual float ScaleMultiplier { get => default; } // 0x0000000186DE50B0-0x0000000186DE50C0 
		protected virtual float InitialSpeed { get => default; } // 0x0000000186DE50C0-0x0000000186DE50D0 
		protected virtual float DecelRate { get => default; } // 0x0000000185C62C10-0x0000000185C62C20 
		protected virtual bool UsesPortalVFX { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		protected virtual float PortalVFXScale { get => default; } // 0x0000000185C0CCB0-0x0000000185C0CCC0 
	
		// Constructors
		public EME_SpearProjectile() {} // 0x0000000186DE6BC0-0x0000000186DE6C10
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DE50D0-0x0000000186DE5500
		public override void InternalUpdate() {} // 0x0000000186DE5500-0x0000000186DE55B0
		public void SetVelocityForTriumvirate(float rotation) {} // 0x0000000186DE55B0-0x0000000186DE58F0
		private void UpdateVelocity() {} // 0x0000000186DE5500-0x0000000186DE55B0
		protected virtual void SetupTrail() {} // 0x0000000186DE58F0-0x0000000186DE5B90
		private void SetupSpearSprite() {} // 0x0000000186DE5B90-0x0000000186DE5D50
		protected virtual string GetSpearSpriteName(WeaponType weapon = WeaponType.VOID /* Metadata: 0x019778E8 */) => default; // 0x0000000186DE5D50-0x0000000186DE5DE0
		private void DoSpearFadeIn() {} // 0x0000000186DE5DE0-0x0000000186DE60E0
		private void DoPortalVfx() {} // 0x0000000186DE60E0-0x0000000186DE66A0
		protected virtual void PlaySfx() {} // 0x0000000186DE66A0-0x0000000186DE6780
		private void StartDespawn() {} // 0x0000000186DE6780-0x0000000186DE6A80
		public override void Despawn() {} // 0x0000000186DE6A80-0x0000000186DE6BC0
	}
}
