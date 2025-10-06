/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_Dominus4_Weapon : Weapon // TypeDefIndex: 16325
	{
		// Fields
		private bool _totalDamageCalculated; // 0x158
		private bool _initialisedParticles; // 0x159
		private PhaserSprite _cursor; // 0x160
		private TP_Dominus1_Weapon _weaponDominus1; // 0x168
		private TP_Dominus2_Weapon _weaponDominus2; // 0x170
		private TP_Dominus3_Weapon _weaponDominus3; // 0x178
		private BulletPool invisPool; // 0x180
		[SerializeField]
		private Projectile _invisProjectilePrefab; // 0x188
	
		// Properties
		public virtual float PlayerFacing { get => default; } // 0x0000000185C0CCB0-0x0000000185C0CCC0 
		public virtual bool IsPrimaryWeapon { get => default; } // 0x0000000181958370-0x0000000181958380 
	
		// Constructors
		public TP_Dominus4_Weapon() {} // 0x0000000186FA5770-0x0000000186FA57C0
	
		// Methods
		protected override void Awake() {} // 0x0000000186FA3AC0-0x0000000186FA3AE0
		public override float PInterval() => default; // 0x0000000186FA3AE0-0x0000000186FA3B40
		protected override void OnStart() {} // 0x0000000186FA3B40-0x0000000186FA4710
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FA4710-0x0000000186FA4760
		public override void InternalUpdate() {} // 0x0000000186FA4760-0x0000000186FA4A40
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977C5A */) {} // 0x0000000186FA4A40-0x0000000186FA4BC0
		public void FireProjectiles() {} // 0x0000000186FA4BC0-0x0000000186FA4C40
		public void FireDominusWeapons() {} // 0x0000000186FA4C40-0x0000000186FA4CB0
		public override void Cleanup() {} // 0x0000000186FA4CB0-0x0000000186FA4D60
		public override void SetVisible(bool visible) {} // 0x0000000186FA4D60-0x0000000186FA5300
		public override float CalculateTotalDamage() => default; // 0x0000000186FA5300-0x0000000186FA5380
		public void FireInvisibleProjectiles() {} // 0x0000000186FA5380-0x0000000186FA5590
		protected virtual bool OnBulletOverlapsEnemyOHKO(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186FA5590-0x0000000186FA5770
	}
}
