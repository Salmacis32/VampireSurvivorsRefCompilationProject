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
	public class TP_Lapiste2_Weapon : Weapon // TypeDefIndex: 16418
	{
		// Fields
		[SerializeField]
		private Projectile _InvisibleProjectilePrefab; // 0x158
		[SerializeField]
		private Projectile _BigFistProjectilePrefab; // 0x160
		private BulletPool _invisibleProjectilePool; // 0x168
		private BulletPool _bigFistProjectilePool; // 0x170
		private const int BigFistFireInterval = 14; // Metadata: 0x01977C9E
		private const float BigFistDamageMultiplier = 5f; // Metadata: 0x01977C9F
		private int _fireCounter; // 0x178
	
		// Properties
		public BulletPool InvisibleProjectilePool { get => default; } // 0x00000001829176E0-0x00000001829176F0 
	
		// Constructors
		public TP_Lapiste2_Weapon() {} // 0x0000000186FD58B0-0x0000000186FD5900
	
		// Methods
		protected override void OnStart() {} // 0x0000000186FD48F0-0x0000000186FD4E40
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FD4E40-0x0000000186FD4E70
		public override void ParadoxFire() {} // 0x0000000186FD4E70-0x0000000186FD4FB0
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B209C0-0x0000000180B209D0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977C9D */) {} // 0x0000000186FD4FB0-0x0000000186FD5120
		private void GetTargetTransform() {} // 0x0000000186FD5120-0x0000000186FD53A0
		private void CheckForBigFist() {} // 0x0000000186FD53A0-0x0000000186FD54E0
		private bool OnBulletOverlapsEnemy_BigFist(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186FD54E0-0x0000000186FD5650
		public override void CheckArcanas() {} // 0x0000000186FD5650-0x0000000186FD58B0
	}
}
