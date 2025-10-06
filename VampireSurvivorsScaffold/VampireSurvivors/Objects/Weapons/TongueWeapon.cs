/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TongueWeapon : Weapon // TypeDefIndex: 16218
	{
		// Fields
		public float distanceMultiplier; // 0x158
		private float _baseRange; // 0x15C
		protected Weapon _counterWeapon; // 0x160
		private bool _readyToFire; // 0x168
		private List<EnemyController> aimCache; // 0x170
	
		// Properties
		public virtual float forwardFacing { get => default; } // 0x0000000185C0CCB0-0x0000000185C0CCC0 
		protected virtual WeaponType _counterWeaponType { get => default; } // 0x0000000181E8EF40-0x0000000181E8EF50 
	
		// Constructors
		public TongueWeapon() {} // 0x0000000186F6A2D0-0x0000000186F6A3D0
	
		// Methods
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F69150-0x0000000186F692A0
		public override float PPower() => default; // 0x0000000186F692A0-0x0000000186F69360
		protected virtual bool CanLickBackwards() => default; // 0x0000000180B15290-0x0000000180B152A0
		private List<EnemyController> ChooseEnemiesInRange(float2 position, float radius, bool facingLeft) => default; // 0x0000000186F69360-0x0000000186F69760
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BCD */) {} // 0x0000000186F69760-0x0000000186F69770
		public override void InternalUpdate() {} // 0x0000000186F69770-0x0000000186F697D0
		private void TryFiring() {} // 0x0000000186F697D0-0x0000000186F69E20
		protected virtual bool SupportCounterWeapon() => default; // 0x0000000181958370-0x0000000181958380
		public override void CheckArcanas() {} // 0x0000000186F69E20-0x0000000186F6A130
		public override bool LevelUp() => default; // 0x0000000186F6A130-0x0000000186F6A210
		public override void SetVisible(bool visible) {} // 0x0000000186F6A210-0x0000000186F6A2D0
	}
}
