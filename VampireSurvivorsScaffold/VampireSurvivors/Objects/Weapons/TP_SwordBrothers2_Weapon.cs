/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_SwordBrothers2_Weapon : Weapon // TypeDefIndex: 16505
	{
		// Fields
		[SerializeField]
		private Projectile _FiringPrefab; // 0x158
		private bool _cooldownAffectedByMovement; // 0x160
		private const float Mul = 166.66667f; // Metadata: 0x01977D01
		private const float ExplosionDamageMultiplier = 0.3f; // Metadata: 0x01977D05
		private BulletPool _explosionPool; // 0x168
	
		// Properties
		public BulletPool ExplosionPool { get => default; } // 0x00000001829176E0-0x00000001829176F0 
	
		// Constructors
		public TP_SwordBrothers2_Weapon() {} // 0x0000000186FFAEB0-0x0000000186FFAF00
	
		// Methods
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000181BA4B30-0x0000000181BA4B40
		protected override void OnStart() {} // 0x0000000186FFA640-0x0000000186FFA930
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F28A70-0x0000000186F28A90
		public override void InternalUpdate() {} // 0x0000000186FFA930-0x0000000186FFAA10
		public override void ResetFiringTimer() {} // 0x0000000186F292B0-0x0000000186F292D0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977D00 */) {} // 0x0000000186FFAA10-0x0000000186FFAA80
		protected override void OnDestroy() {} // 0x0000000186FFAA80-0x0000000186FFAB00
		public override void Cleanup() {} // 0x0000000186FFAB00-0x0000000186FFAB30
		public override void CheckArcanas() {} // 0x0000000186FFAB30-0x0000000186FFAD40
		private bool OnBulletOverlapsEnemy_Explosion(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186FFAD40-0x0000000186FFAEB0
	}
}
