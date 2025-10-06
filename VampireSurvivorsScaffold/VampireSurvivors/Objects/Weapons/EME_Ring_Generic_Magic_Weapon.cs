/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class EME_Ring_Generic_Magic_Weapon : Weapon // TypeDefIndex: 16624
	{
		// Fields
		protected readonly Dictionary<WeaponType, string> _glimmerNames; // 0x158
	
		// Properties
		public virtual WeaponType GlimmerName { get => default; } // 0x00000001823E9BA0-0x00000001823E9BB0 
	
		// Constructors
		public EME_Ring_Generic_Magic_Weapon() {} // 0x0000000187027250-0x0000000187027340
	
		// Methods
		protected override void Awake() {} // 0x00000001870099F0-0x0000000187009A10
		protected override void OnStart() {} // 0x0000000187026B70-0x0000000187026CE0
		private void AddGlimmerName(WeaponType glimmerWeaponType) {} // 0x0000000187026CE0-0x0000000187026E30
		private string GetGlimmerName(WeaponType weaponType) => default; // 0x0000000187026E30-0x0000000187026FA0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977D85 */) {} // 0x0000000187026FA0-0x0000000187027250
	}
}
