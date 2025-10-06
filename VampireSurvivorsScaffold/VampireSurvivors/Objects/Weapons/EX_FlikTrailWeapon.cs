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
	public class EX_FlikTrailWeapon : Weapon // TypeDefIndex: 16657
	{
		// Fields
		public float _range; // 0x158
		private int _sourceIndex; // 0x15C
		private float _maxSources; // 0x160
		private List<Transform> _sources; // 0x168
	
		// Constructors
		public EX_FlikTrailWeapon() {} // 0x0000000187037440-0x00000001870374A0
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x00000001870366A0-0x00000001870367F0
		public void SetSources(List<Transform> array) {} // 0x00000001870367F0-0x00000001870368A0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977DC1 */) {} // 0x00000001870368A0-0x00000001870372D0
		public override void SetVisible(bool visible) {} // 0x00000001870372D0-0x0000000187037390
		private Transform GetSource() => default; // 0x0000000187037390-0x0000000187037440
	}
}
