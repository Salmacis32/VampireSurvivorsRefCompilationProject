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
	public class SpellstringWeapon : Weapon // TypeDefIndex: 16178
	{
		// Fields
		private float _range; // 0x158
		private int _sourceIndex; // 0x15C
		private float _maxSources; // 0x160
		private List<Transform> _sources; // 0x168
	
		// Constructors
		public SpellstringWeapon() {} // 0x0000000186F42740-0x0000000186F427A0
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F41B20-0x0000000186F41BF0
		public void SetSources(List<Transform> array) {} // 0x0000000186F41BF0-0x0000000186F41CA0
		public override float PPower() => default; // 0x0000000186F41CA0-0x0000000186F41D50
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BAF */) {} // 0x0000000186F41D50-0x0000000186F425D0
		public override void SetVisible(bool visible) {} // 0x0000000186F425D0-0x0000000186F42690
		private Transform GetSource() => default; // 0x0000000186F42690-0x0000000186F42740
	}
}
