/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_GothMissile_Weapon : Weapon // TypeDefIndex: 16374
	{
		// Fields
		private static float init; // 0x00
		private static float unitX; // 0x04
		private static float unitY; // 0x08
		private List<float> offsetsX; // 0x158
		private List<float> offsetsY; // 0x160
	
		// Constructors
		public TP_GothMissile_Weapon() {} // 0x0000000186FBE3E0-0x0000000186FBF5B0
		static TP_GothMissile_Weapon() {} // 0x0000000186FBF5B0-0x0000000186FBF620
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F9D650-0x0000000186F9D690
		public override void InternalUpdate() {} // 0x0000000186F88E60-0x0000000186F88EE0
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977C82 */) {} // 0x0000000186FBDC20-0x0000000186FBE3E0
	}
}
