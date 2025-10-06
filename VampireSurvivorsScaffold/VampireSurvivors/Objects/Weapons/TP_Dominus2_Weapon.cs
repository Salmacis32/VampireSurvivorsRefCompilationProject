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
	public class TP_Dominus2_Weapon : Weapon // TypeDefIndex: 16323
	{
		// Fields
		private bool _initialisedParticles; // 0x158
		private BulletPool _centralProjectilePool; // 0x160
		[SerializeField]
		private Projectile _centralProjectilePrefab; // 0x168
	
		// Properties
		public virtual float PlayerFacing { get => default; } // 0x0000000185C0CCB0-0x0000000185C0CCC0 
		public virtual bool IsPrimaryWeapon { get => default; } // 0x0000000181958370-0x0000000181958380 
		public bool Inverted { get; set; } // 0x0000000184F6B640-0x0000000184F6B650 0x0000000186FA0AA0-0x0000000186FA0AB0
	
		// Constructors
		public TP_Dominus2_Weapon() {} // 0x0000000186FA1600-0x0000000186FA1650
	
		// Methods
		protected override void Awake() {} // 0x0000000186FA0AB0-0x0000000186FA0AD0
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FA0AD0-0x0000000186FA0DD0
		public override void InternalUpdate() {} // 0x0000000186FA0DD0-0x0000000186FA0E70
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977C4B */) {} // 0x0000000186FA0E70-0x0000000186FA1070
		public void FireProjectiles() {} // 0x0000000186FA1070-0x0000000186FA1500
		public override void SetVisible(bool visible) {} // 0x0000000186FA1500-0x0000000186FA15C0
		public override void Cleanup() {} // 0x0000000186FA15C0-0x0000000186FA1600
		public override void CheckArcanas() {} // 0x0000000186F6A610-0x0000000186F6A620
	}
}
