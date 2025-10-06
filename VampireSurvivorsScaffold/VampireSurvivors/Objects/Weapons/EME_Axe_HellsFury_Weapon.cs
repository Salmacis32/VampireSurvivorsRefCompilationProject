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
	public class EME_Axe_HellsFury_Weapon : Weapon // TypeDefIndex: 16550
	{
		// Fields
		protected readonly Dictionary<WeaponType, string> _glimmerNames; // 0x158
	
		// Constructors
		public EME_Axe_HellsFury_Weapon() {} // 0x000000018700A0D0-0x000000018700A1C0
	
		// Methods
		public override float PAmount() => default; // 0x0000000185C0CCB0-0x0000000185C0CCC0
		protected override void Awake() {} // 0x00000001870099F0-0x0000000187009A10
		protected override void OnStart() {} // 0x0000000187009A10-0x0000000187009B90
		public override void InternalUpdate() {} // 0x0000000186F88E60-0x0000000186F88EE0
		private void UpdateFiringTimer() {} // 0x0000000186FC9360-0x0000000186FC93E0
		public override void ResetFiringTimer() {} // 0x0000000186F292B0-0x0000000186F292D0
		private void AddGlimmerName(WeaponType glimmerWeaponType) {} // 0x0000000187009B90-0x0000000187009CE0
		private string GetGlimmerName(WeaponType weaponType) => default; // 0x0000000187009CE0-0x0000000187009E50
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977D47 */) {} // 0x0000000187009E50-0x000000018700A0D0
	}
}
