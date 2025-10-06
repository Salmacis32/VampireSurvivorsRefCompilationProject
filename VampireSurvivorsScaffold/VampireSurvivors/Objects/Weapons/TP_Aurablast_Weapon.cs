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
	public class TP_Aurablast_Weapon : Weapon // TypeDefIndex: 16279
	{
		// Fields
		[SerializeField]
		private Projectile _bigProjectile; // 0x158
		protected BulletPool _bigPool; // 0x160
	
		// Constructors
		public TP_Aurablast_Weapon() {} // 0x0000000186F89680-0x0000000186F896D0
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F88B40-0x0000000186F88E60
		public override void InternalUpdate() {} // 0x0000000186F88E60-0x0000000186F88EE0
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BFC */) {} // 0x0000000186F88EE0-0x0000000186F89550
		public Projectile FireBigAssProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) => default; // 0x0000000186F89550-0x0000000186F89680
		public override void CheckArcanas() {} // 0x0000000186F71380-0x0000000186F71480
	}
}
