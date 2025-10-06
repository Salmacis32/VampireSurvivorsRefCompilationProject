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
	public class TP_Cerestros_Weapon : TP_Custos_Weapon // TypeDefIndex: 16285
	{
		// Fields
		private BulletPool _firePool_; // 0x1B8
		private BulletPool _fireExplosionPool_; // 0x1C0
		private BulletPool _icePool_; // 0x1C8
		private BulletPool _iceExplosionPool_; // 0x1D0
		private BulletPool _sinistroPool_; // 0x1D8
	
		// Constructors
		public TP_Cerestros_Weapon() {} // 0x0000000186F8EA60-0x0000000186F8EAB0
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F8D500-0x0000000186F8E1D0
		public override Projectile AddFireTrailAt(Vector2 pos) => default; // 0x0000000186F8E1D0-0x0000000186F8E2E0
		public override Projectile AddFireExplosionAt(Vector2 pos) => default; // 0x0000000186F8E2E0-0x0000000186F8E3F0
		public override Projectile AddIceTrailAt(Vector2 pos) => default; // 0x0000000186F8E3F0-0x0000000186F8E500
		public override Projectile AddIceExplosionAt(Vector2 pos) => default; // 0x0000000186F8E500-0x0000000186F8E630
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977C24 */) {} // 0x0000000186F8E630-0x0000000186F8E930
		public override void CheckArcanas() {} // 0x0000000186F8E930-0x0000000186F8E9F0
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B209C0-0x0000000180B209D0
		public override void Cleanup() {} // 0x0000000186F8E9F0-0x0000000186F8EA60
	}
}
