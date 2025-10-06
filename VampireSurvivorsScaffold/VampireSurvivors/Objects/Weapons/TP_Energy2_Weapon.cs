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
	public class TP_Energy2_Weapon : Weapon // TypeDefIndex: 16352
	{
		// Fields
		private bool _initialisedParticles; // 0x159
		private float _totalTimeCounterWeapon; // 0x15C
		protected WeaponType _counterWeaponType; // 0x160
		protected Weapon _counterWeapon; // 0x168
		protected SantaJavelinCounterWeapon _counterSet; // 0x170
		protected bool _hasCounterSet; // 0x178
	
		// Properties
		public virtual float PlayerFacing { get => default; } // 0x0000000185C0CCB0-0x0000000185C0CCC0 
		public virtual bool IsPrimaryWeapon { get => default; } // 0x0000000181958370-0x0000000181958380 
		public bool IsBeamActive { get; set; } // 0x0000000184F54D70-0x0000000184F54D80 0x000000018675C9B0-0x000000018675C9C0
	
		// Constructors
		public TP_Energy2_Weapon() {} // 0x0000000186FB27B0-0x0000000186FB2810
	
		// Methods
		protected override void Awake() {} // 0x0000000186F6AB60-0x0000000186F6AB70
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FB1DF0-0x0000000186FB1E50
		public override void InternalUpdate() {} // 0x0000000186FB1E50-0x0000000186FB1F40
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977C67 */) {} // 0x0000000186FB1F40-0x0000000186FB2080
		public override Projectile FireOneProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) => default; // 0x0000000186FB2080-0x0000000186FB21C0
		protected void Fire_FireCounter(bool skipTriggers = false /* Metadata: 0x01977C68 */) {} // 0x0000000186FB21C0-0x0000000186FB2440
		public override bool LevelUp() => default; // 0x0000000186FB2440-0x0000000186FB2560
		public override void CheckArcanas() {} // 0x0000000186FB2560-0x0000000186FB27B0
	}
}
