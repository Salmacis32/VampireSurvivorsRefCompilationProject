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
	public class PrismaticMissileWeapon : Weapon // TypeDefIndex: 16171
	{
		// Fields
		private int _currentIndex; // 0x158
		[NonSerialized]
		public float FiredTimes; // 0x15C
		[NonSerialized]
		public ArcanaType FirstArcana; // 0x160
	
		// Constructors
		public PrismaticMissileWeapon() {} // 0x0000000186F3EE10-0x0000000186F3EE70
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F3E770-0x0000000186F3E7A0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BAB */) {} // 0x0000000186F3E7A0-0x0000000186F3E7D0
		public override Projectile FireOneProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) => default; // 0x0000000186F3E7D0-0x0000000186F3EAD0
		public override void CheckArcanas() {} // 0x0000000186F3EAD0-0x0000000186F3EE10
	}
}
