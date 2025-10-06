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
	public class EME_PunchWeapon : Weapon // TypeDefIndex: 16617
	{
		// Fields
		private float _range; // 0x158
		private int _sourceIndex; // 0x15C
		private float _maxSources; // 0x160
		private List<Transform> _sources; // 0x168
	
		// Constructors
		public EME_PunchWeapon() {} // 0x0000000187024800-0x0000000187024860
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000187023C10-0x0000000187023D60
		public void SetSources(List<Transform> array) {} // 0x0000000187023D60-0x0000000187023E10
		public override float PPower() => default; // 0x0000000186F41CA0-0x0000000186F41D50
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977D84 */) {} // 0x0000000187023E10-0x0000000187024690
		public override void SetVisible(bool visible) {} // 0x0000000187024690-0x0000000187024750
		private Transform GetSource() => default; // 0x0000000187024750-0x0000000187024800
	}
}
