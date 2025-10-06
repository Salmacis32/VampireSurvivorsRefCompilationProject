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
	public class Guns2Weapon : Weapon // TypeDefIndex: 16700
	{
		// Fields
		[NonSerialized]
		public bool _doFiring; // 0x158
		protected WeaponType _counterWeaponType; // 0x15C
		protected Weapon _counterWeapon; // 0x160
		protected WeaponType _secondSetType; // 0x168
	
		// Constructors
		public Guns2Weapon() {} // 0x0000000187089B40-0x0000000187089BA0
	
		// Methods
		public override void ResetFiringTimer() {} // 0x0000000187089BA0-0x0000000187089BC0
		public void ResetFiringTimerPublic() {} // 0x0000000186FD6800-0x0000000186FD6820
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000187089BC0-0x0000000187089CA0
		public override void CheckArcanas() {} // 0x0000000187089CA0-0x000000018708A1D0
		public override Projectile FireOneProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) => default; // 0x000000018708A1D0-0x000000018708A6A0
		public override bool LevelUp() => default; // 0x000000018708A6A0-0x000000018708A7C0
	}
}
