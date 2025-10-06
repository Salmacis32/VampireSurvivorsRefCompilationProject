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
	public class TP_Pocket2_Weapon : Weapon // TypeDefIndex: 16443
	{
		// Fields
		[SerializeField]
		private Projectile _InvisibleProjectilePrefab; // 0x158
		private const float MaxBonusPower = 0.5f; // Metadata: 0x01977CB7
		private const float MaxBonusArmor = 5f; // Metadata: 0x01977CBB
		private const float MaxBonusCritMul = 1f; // Metadata: 0x01977CBF
		private float _bonusPower; // 0x160
		private float _bonusArmor; // 0x164
		private float _bonusCritMul; // 0x168
		private bool _bonusStatsApplied; // 0x16C
		private BulletPool _invisibleProjectilePool; // 0x170
	
		// Properties
		public BulletPool InvisibleProjectilePool { get => default; } // 0x0000000182917880-0x0000000182917890 
	
		// Constructors
		public TP_Pocket2_Weapon() {} // 0x0000000186FDE220-0x0000000186FDE270
	
		// Methods
		protected override void OnStart() {} // 0x0000000186FDD2E0-0x0000000186FDD5D0
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B209C0-0x0000000180B209D0
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FDD5D0-0x0000000186FDD5F0
		private void LateUpdate() {} // 0x0000000186FDD5F0-0x0000000186FDD600
		private void UpdateStatBonuses() {} // 0x0000000186FDD600-0x0000000186FDD930
		private void RemoveCurrentStatBonuses() {} // 0x0000000186FDD930-0x0000000186FDDB90
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977CB6 */) {} // 0x0000000186FDDB90-0x0000000186FDDEE0
		private void FireProjectile(int index, bool flipped) {} // 0x0000000186FDDEE0-0x0000000186FDE200
		public override void CheckArcanas() {} // 0x0000000186FDD1D0-0x0000000186FDD290
		public override void Cleanup() {} // 0x0000000186FDE200-0x0000000186FDE220
	}
}
