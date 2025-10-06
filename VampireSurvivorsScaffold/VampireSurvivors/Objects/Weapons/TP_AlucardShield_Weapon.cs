/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_AlucardShield_Weapon : WeaponSelector // TypeDefIndex: 16269
	{
		// Fields
		public int SlotNumber; // 0x158
	
		// Constructors
		public TP_AlucardShield_Weapon() {} // 0x0000000186F86770-0x0000000186F867D0
	
		// Methods
		public override float PPower() => default; // 0x0000000186F85F40-0x0000000186F85F50
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F85F50-0x0000000186F86460
		public override void Cleanup() {} // 0x0000000186F86460-0x0000000186F864D0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BF2 */) {} // 0x0000000186F864D0-0x0000000186F86610
		protected override float CalcCritMul() => default; // 0x0000000186F86610-0x0000000186F86770
	}
}
