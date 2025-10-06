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
	public class EME_Mech_BallisticMissile_Weapon : Weapon // TypeDefIndex: 16605
	{
		// Fields
		protected readonly Dictionary<WeaponType, string> _glimmerNames; // 0x158
	
		// Constructors
		public EME_Mech_BallisticMissile_Weapon() {} // 0x000000018701E480-0x000000018701E570
	
		// Methods
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
		protected override void Awake() {} // 0x00000001870099F0-0x0000000187009A10
		protected override void OnStart() {} // 0x000000018701DB80-0x000000018701DCD0
		private void AddGlimmerName(WeaponType glimmerWeaponType) {} // 0x000000018701DCD0-0x000000018701DE20
		private string GetGlimmerName(WeaponType weaponType) => default; // 0x000000018701DE20-0x000000018701DF90
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977D75 */) {} // 0x000000018701DF90-0x000000018701E480
	}
}
