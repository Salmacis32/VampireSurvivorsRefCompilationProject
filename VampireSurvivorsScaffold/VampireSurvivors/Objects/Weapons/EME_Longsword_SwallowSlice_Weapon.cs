/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class EME_Longsword_SwallowSlice_Weapon : Weapon // TypeDefIndex: 16598
	{
		// Fields
		protected readonly Dictionary<WeaponType, string> _glimmerNames; // 0x158
		private int swallowSliceInterval; // 0x160
	
		// Constructors
		public EME_Longsword_SwallowSlice_Weapon() {} // 0x000000018701BBB0-0x000000018701BCA0
	
		// Methods
		protected override void Awake() {} // 0x00000001870099F0-0x0000000187009A10
		protected override void OnStart() {} // 0x000000018701AB30-0x000000018701ACB0
		public override void InternalUpdate() {} // 0x0000000186F88E60-0x0000000186F88EE0
		private void UpdateFiringTimer() {} // 0x0000000186FC9360-0x0000000186FC93E0
		public override void ResetFiringTimer() {} // 0x0000000186F292B0-0x0000000186F292D0
		private void AddGlimmerName(WeaponType glimmerWeaponType) {} // 0x000000018701ACB0-0x000000018701AE00
		private string GetGlimmerName(WeaponType weaponType) => default; // 0x000000018701AE00-0x000000018701AF70
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977D73 */) {} // 0x000000018701AF70-0x000000018701B6C0
		private void FireSwallowSwing(Vector2 pos, float _amount) {} // 0x000000018701B6C0-0x000000018701BBB0
	}
}
