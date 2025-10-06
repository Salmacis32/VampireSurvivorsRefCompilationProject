/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_WindWhip2_Weapon : TP_WindWhip1_Weapon // TypeDefIndex: 16527
	{
		// Fields
		private TP_SpiritTornado_Weapon _subWeapon; // 0x168
		private bool _totalDamageCalculated; // 0x170
	
		// Constructors
		public TP_WindWhip2_Weapon() {} // 0x0000000187000BD0-0x0000000187000C40
	
		// Methods
		protected override void Awake() {} // 0x0000000186FA0AB0-0x0000000186FA0AD0
		protected override void OnStart() {} // 0x0000000187000C40-0x0000000187000D90
		public override void OnSubWeaponCounter(bool skipTriggers = false /* Metadata: 0x01977D2B */) {} // 0x0000000187000D90-0x0000000187000E90
		public override void InternalUpdate() {} // 0x0000000187000E90-0x0000000187000F90
		public override void Cleanup() {} // 0x0000000187000F90-0x0000000187000FD0
		public override float CalculateTotalDamage() => default; // 0x0000000187000FD0-0x0000000187001020
		public override void SetVisible(bool visible) {} // 0x0000000187001020-0x0000000187001060
	}
}
