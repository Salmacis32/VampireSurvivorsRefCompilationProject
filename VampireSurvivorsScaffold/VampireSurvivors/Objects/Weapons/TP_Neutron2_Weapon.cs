/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Signals;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_Neutron2_Weapon : Weapon // TypeDefIndex: 16429
	{
		// Fields
		private const float _explosionDamageMultiplier = 2f; // Metadata: 0x01977CA8
		private int _exploIndex; // 0x158
		private bool _canExplode; // 0x15C
		private Tween _explodeTimer; // 0x160
		private bool _generatedPools; // 0x168
		private BulletPool _onGetHitExplosionPool; // 0x170
		private BulletPool _neutronExplosionPool; // 0x178
	
		// Properties
		public BulletPool NeutronExplosionPool { get => default; } // 0x0000000182917A20-0x0000000182917A30 
	
		// Constructors
		public TP_Neutron2_Weapon() {} // 0x0000000186FDAD30-0x0000000186FDAD90
	
		// Methods
		protected override void OnStart() {} // 0x0000000186FD9A50-0x0000000186FD9FE0
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FD9FE0-0x0000000186FDA110
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977CA7 */) {} // 0x0000000186FDA110-0x0000000186FDA440
		public override void CheckArcanas() {} // 0x0000000186F2A920-0x0000000186F2AA90
		public override int ActiveProjectileCount() => default; // 0x0000000186F2AA90-0x0000000186F2AB10
		public override void Cleanup() {} // 0x0000000186FDA440-0x0000000186FDA580
		private void ExplodeOnPlayerDamage(GameplaySignals.CharacterReceivedDamageSignal signal) {} // 0x0000000186FDA580-0x0000000186FDA6B0
		private void ExplodeOnPlayerShield(GameplaySignals.CharacterLostShieldSignal signal) {} // 0x0000000186FDA6B0-0x0000000186FDA7E0
		private void ExplodeOnPlayer() {} // 0x0000000186FDA7E0-0x0000000186FDABC0
		private bool OnBulletOverlapsEnemy_Explosion(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186FDABC0-0x0000000186FDAD30
	}
}
