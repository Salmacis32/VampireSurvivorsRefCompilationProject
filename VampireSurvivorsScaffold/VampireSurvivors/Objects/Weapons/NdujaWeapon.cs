/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class NdujaWeapon : Weapon // TypeDefIndex: 16739
	{
		// Fields
		public Vector3 FiringOffset; // 0x158
		private const WeaponType COUNTER_WEAPON_TYPE = WeaponType.NDUJA_COUNTER; // Metadata: 0x01977E09
		private Weapon _counterWeapon; // 0x168
	
		// Constructors
		public NdujaWeapon() {} // 0x00000001870A10B0-0x00000001870A1150
	
		// Methods
		protected override void Awake() {} // 0x00000001870099F0-0x0000000187009A10
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x00000001870A0C70-0x00000001870A0CD0
		public override void CheckArcanas() {} // 0x00000001870A0CD0-0x00000001870A0F80
		public override void InternalUpdate() {} // 0x00000001870A0F80-0x00000001870A10B0
	}
}
