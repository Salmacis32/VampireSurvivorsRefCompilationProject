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
	public class TP_Universitas_Weapon : Weapon // TypeDefIndex: 16507
	{
		// Fields
		private BulletPool _invisibleProjectilePool; // 0x158
		[SerializeField]
		private Projectile _invisibleProjectilePrefab; // 0x160
	
		// Constructors
		public TP_Universitas_Weapon() {} // 0x0000000186FFBEA0-0x0000000186FFBEF0
	
		// Methods
		protected override void Awake() {} // 0x0000000186F6AB60-0x0000000186F6AB70
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000181F01BA0-0x0000000181F01BB0
		public override void OnWeaponAdded() {} // 0x0000000186FFB5C0-0x0000000186FFB760
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FFB760-0x0000000186FFBA60
		public override void InternalUpdate() {} // 0x0000000186F88E60-0x0000000186F88EE0
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977D0A */) {} // 0x0000000186FFBA60-0x0000000186FFBBC0
		public void FireMeteors() {} // 0x0000000186FFBBC0-0x0000000186FFBEA0
	}
}
