/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class FB_WaveWeapon : Weapon // TypeDefIndex: 16259
	{
		// Fields
		private float _mainCooldownTimer; // 0x158
		private float _chargeCooldownTimer; // 0x15C
		private ParticleEmitterManager _particlesManager; // 0x160
		private ParticleSystem _pfxEmitter; // 0x168
		private ParticleEmitterManager _chargingParticlesManager; // 0x170
		private ParticleSystem _chargingPfxEmitter; // 0x178
		private PhaserSprite _chargingBall; // 0x180
		private GravityWellConfig _gravityWellConfig; // 0x188
		private PhaserSprite _smokeBoom; // 0x190
	
		// Constructors
		public FB_WaveWeapon() {} // 0x0000000186F81920-0x0000000186F81970
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F7E150-0x0000000186F7E750
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B21570-0x0000000180B21580
		private void GenerateParticleSystems() {} // 0x0000000186F7E750-0x0000000186F7FDB0
		public override void InternalUpdate() {} // 0x0000000186F7FDB0-0x0000000186F80530
		public override void ResetFiringTimer() {} // 0x0000000186F292B0-0x0000000186F292D0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BED */) {} // 0x0000000186F80530-0x0000000186F80990
		public Projectile CustomFireOneProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null, bool isCharged = false /* Metadata: 0x01977BEE */) => default; // 0x0000000186F80990-0x0000000186F81790
		public override void CheckArcanas() {} // 0x0000000186F59CD0-0x0000000186F59E40
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F81790-0x0000000186F81920
	}
}
