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
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_RapierProjectile_Crystalline : Projectile // TypeDefIndex: 15833
	{
		// Fields
		private MultiTargetTween _tween; // 0xD0
		private MultiTargetTween _tween2; // 0xD8
		private EME_RapierWeapon _trueWeapon; // 0xE0
		private ParticleSystem _pfxEmitter; // 0xE8
		private bool _initialisedParticles; // 0xF0
		private readonly SfxType[] _sounds; // 0xF8
		private int _sfxIndex; // 0x100
		private PhaserSprite crystalSprite; // 0x108
		private bool isInitialised; // 0x110
		private PhaserSprite impactSprite; // 0x118
		private MultiTargetTween _tween3; // 0x120
		private MultiTargetTween _tween4; // 0x128
		protected bool hasHit; // 0x130
	
		// Properties
		protected virtual uint _pfxTint { get => default; } // 0x0000000186DDDC50-0x0000000186DDDC60 
	
		// Constructors
		public EME_RapierProjectile_Crystalline() {} // 0x0000000186DDFF50-0x0000000186DE0040
	
		// Methods
		public virtual void makeSprites() {} // 0x0000000186DDDC60-0x0000000186DDE140
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DDE140-0x0000000186DDEAB0
		private void PlaySfx() {} // 0x0000000186DDEAB0-0x0000000186DDEBC0
		public virtual void DespawnNow() {} // 0x0000000186DDEBC0-0x0000000186DDEC70
		public override void Despawn() {} // 0x0000000186DDEC70-0x0000000186DDED80
		public override void SetNullTarget() {} // 0x0000000186DDED80-0x0000000186DDEDA0
		public override void SetTarget(Transform target) {} // 0x0000000186DDEDA0-0x0000000186DDFF50
	}
}
