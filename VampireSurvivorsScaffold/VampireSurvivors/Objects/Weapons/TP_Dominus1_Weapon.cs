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
	public class TP_Dominus1_Weapon : Weapon // TypeDefIndex: 16320
	{
		// Fields
		private BulletPool _invisibleProjectilePool; // 0x158
		[SerializeField]
		private Projectile _invisibleProjectilePrefab; // 0x160
		private bool _initialisedParticles; // 0x169
		private bool _isManualFire; // 0x16A
	
		// Properties
		public virtual float PlayerFacing { get => default; } // 0x0000000185C0CCB0-0x0000000185C0CCC0 
		public virtual bool IsPrimaryWeapon { get => default; } // 0x0000000181958370-0x0000000181958380 
		public bool Inverted { get; set; } // 0x0000000182766960-0x0000000182766970 0x00000001847A8F00-0x00000001847A8F10
	
		// Constructors
		public TP_Dominus1_Weapon() {} // 0x0000000186F9FBE0-0x0000000186F9FC30
	
		// Methods
		protected override void Awake() {} // 0x0000000186F9EF20-0x0000000186F9EF40
		public void SetManualFire() {} // 0x0000000186F9EF40-0x0000000186F9EF60
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F9EF60-0x0000000186F9F260
		public override void InternalUpdate() {} // 0x0000000186F9F260-0x0000000186F9F310
		public override bool LevelUp() => default; // 0x0000000186F9F310-0x0000000186F9F360
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977C4A */) {} // 0x0000000186F9F360-0x0000000186F9F510
		public void FireProjectiles() {} // 0x0000000186F9F510-0x0000000186F9F840
		protected Vector2 GetVelocityToNearestEnemy() => default; // 0x0000000186F9F840-0x0000000186F9FBE0
		public override void CheckArcanas() {} // 0x0000000186F6A610-0x0000000186F6A620
	}
}
