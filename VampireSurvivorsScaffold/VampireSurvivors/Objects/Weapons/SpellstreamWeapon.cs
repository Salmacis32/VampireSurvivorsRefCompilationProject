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
	public class SpellstreamWeapon : Weapon // TypeDefIndex: 16174
	{
		// Fields
		private int _sourceIndex; // 0x158
		private List<Vector3> _sources; // 0x160
	
		// Constructors
		public SpellstreamWeapon() {} // 0x0000000186F41050-0x0000000186F410A0
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F40A00-0x0000000186F40C40
		private void SetSources(List<Vector3> array) {} // 0x00000001827668F0-0x0000000182766950
		private Vector3 GetSource() => default; // 0x0000000186F40C40-0x0000000186F40D10
		public override float PPower() => default; // 0x0000000186F40D10-0x0000000186F40DC0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BAD */) {} // 0x0000000186F40DC0-0x0000000186F41050
	}
}
