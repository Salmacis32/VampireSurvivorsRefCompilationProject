/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_Mace1_Weapon : Weapon // TypeDefIndex: 16423
	{
		// Fields
		private float maxCooldownOffset; // 0x158
		private float cooldownOffset; // 0x15C
		private BulletPool _lingerPool; // 0x160
		[NonSerialized]
		public int ExtraBodyAmount; // 0x168
	
		// Constructors
		public TP_Mace1_Weapon() {} // 0x0000000186FD7820-0x0000000186FD7890
	
		// Methods
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FD6E60-0x0000000186FD7190
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B209C0-0x0000000180B209D0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977CA4 */) {} // 0x0000000186FD7190-0x0000000186FD72D0
		protected override void OnUpdate() {} // 0x0000000186F75E70-0x0000000186F75EE0
		public override float PInterval() => default; // 0x0000000186FD72D0-0x0000000186FD74D0
		public override void Cleanup() {} // 0x0000000186FD74D0-0x0000000186FD7500
		protected override bool OnSecondaryBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186FD7500-0x0000000186FD7710
		public Projectile CreateLingerProjectile(int index) => default; // 0x0000000186FD7710-0x0000000186FD77A0
		protected override void OnDestroy() {} // 0x0000000186FD77A0-0x0000000186FD7820
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F33A30-0x0000000186F33A80
	}
}
