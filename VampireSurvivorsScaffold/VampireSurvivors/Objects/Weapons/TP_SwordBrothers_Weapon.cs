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
	public class TP_SwordBrothers_Weapon : Weapon // TypeDefIndex: 16506
	{
		// Fields
		[SerializeField]
		private Projectile _fireballPrefab; // 0x158
		private BulletPool _fireballPool; // 0x160
		private bool _isManualFire; // 0x168
	
		// Constructors
		public TP_SwordBrothers_Weapon() {} // 0x0000000186FFB570-0x0000000186FFB5C0
	
		// Methods
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000181BA4B30-0x0000000181BA4B40
		public override float PPower() => default; // 0x0000000186FFAF00-0x0000000186FFAF70
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FFAF70-0x0000000186FFAFB0
		public void SetManualFire() {} // 0x0000000186FF8CA0-0x0000000186FF8CC0
		protected override void OnStart() {} // 0x0000000186FFAFB0-0x0000000186FFB2C0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977D09 */) {} // 0x0000000186FFB2C0-0x0000000186FFB450
		public override void ResetFiringTimer() {} // 0x0000000186FF9E80-0x0000000186FF9EB0
		public TP_SwordBrothers_Firing_Projectile FireSwordProjectile() => default; // 0x0000000186FFB450-0x0000000186FFB540
		protected override void OnDestroy() {} // 0x0000000186FD77A0-0x0000000186FD7820
		public override void Cleanup() {} // 0x0000000186FFB540-0x0000000186FFB570
	}
}
