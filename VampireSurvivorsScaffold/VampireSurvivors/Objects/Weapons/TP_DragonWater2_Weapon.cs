/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_DragonWater2_Weapon : TP_DragonWater1_Weapon // TypeDefIndex: 16328
	{
		// Fields
		private TP_Hydrostorm_Weapon _subWeapon; // 0x188
		private bool _totalDamageCalculated; // 0x190
	
		// Constructors
		public TP_DragonWater2_Weapon() {} // 0x0000000186FA67A0-0x0000000186FA6810
	
		// Methods
		protected override void Awake() {} // 0x0000000186FA6810-0x0000000186FA6830
		protected override void OnStart() {} // 0x0000000186FA6830-0x0000000186FA6950
		public override void OnSubWeaponCounter(bool skipTriggers = false /* Metadata: 0x01977C5E */) {} // 0x0000000186FA6950-0x0000000186FA6A50
		public override void Cleanup() {} // 0x0000000186FA6A50-0x0000000186FA6AC0
		public override float CalculateTotalDamage() => default; // 0x0000000186FA6AC0-0x0000000186FA6B10
		public override void SetVisible(bool visible) {} // 0x0000000186FA6B10-0x0000000186FA6B50
	}
}
