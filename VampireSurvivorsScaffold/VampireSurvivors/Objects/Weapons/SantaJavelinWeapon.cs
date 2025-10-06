/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class SantaJavelinWeapon : Weapon // TypeDefIndex: 16764
	{
		// Fields
		[NonSerialized]
		public bool _doFiring; // 0x158
		private float _mul; // 0x15C
		protected bool _cooldownAffectedByMovement; // 0x160
		protected WeaponType _counterWeaponType; // 0x164
		protected Weapon _counterWeapon; // 0x168
		protected SantaJavelinCounterWeapon _counterSet; // 0x170
		protected bool _hasCounterSet; // 0x178
	
		// Properties
		public virtual float PitchCorrection { get => default; } // 0x00000001826256C0-0x00000001826256D0 
		public virtual bool SingleProjectile { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
	
		// Constructors
		public SantaJavelinWeapon() {} // 0x00000001870B1D90-0x00000001870B1E00
	
		// Methods
		public override float PAmount() => default; // 0x00000001870B05B0-0x00000001870B06A0
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x00000001870B06A0-0x00000001870B06C0
		public override void CheckArcanas() {} // 0x00000001870B06C0-0x00000001870B0BF0
		public override void InternalUpdate() {} // 0x00000001870B0BF0-0x00000001870B0CF0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977E2B */) {} // 0x00000001870B0CF0-0x00000001870B0D70
		public virtual void ForcedFire(bool hasTarget, Vector3 position, bool skipTriggers = false /* Metadata: 0x01977E2C */) {} // 0x00000001870B0D70-0x00000001870B0E00
		protected virtual Vector3 Fire_FireProjectiles(bool hasTarget, Vector3 position, bool skipTriggers = false /* Metadata: 0x01977E2D */) => default; // 0x00000001870B0E00-0x00000001870B1710
		protected void Fire_FireCounter(Vector3 cachedPos, bool skipTriggers = false /* Metadata: 0x01977E2E */) {} // 0x00000001870B1710-0x00000001870B1AD0
		public virtual Projectile FireOneProjectileTo(Vector2 pos, int index, Vector3 target) => default; // 0x00000001870B1AD0-0x00000001870B1C70
		public override void ResetFiringTimer() {} // 0x0000000186F292B0-0x0000000186F292D0
		public override bool LevelUp() => default; // 0x00000001870B1C70-0x00000001870B1D90
	}
}
