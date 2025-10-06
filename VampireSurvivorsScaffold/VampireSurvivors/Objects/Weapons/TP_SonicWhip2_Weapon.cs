/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_SonicWhip2_Weapon : TP_SonicWhip1_Weapon // TypeDefIndex: 16481
	{
		// Fields
		private TP_Valmanway_Weapon _subWeapon; // 0x178
		private bool _totalDamageCalculated; // 0x180
	
		// Constructors
		public TP_SonicWhip2_Weapon() {} // 0x0000000186FC8280-0x0000000186FC8290
	
		// Methods
		protected override void Awake() {} // 0x0000000186FF0640-0x0000000186FF0670
		protected override void OnStart() {} // 0x0000000186FF0670-0x0000000186FF07C0
		public override void InternalUpdate() {} // 0x0000000186FF07C0-0x0000000186FF08C0
		public override void OnSubWeaponCounter(bool skipTriggers = false /* Metadata: 0x01977CDF */) {} // 0x0000000186FF08C0-0x0000000186FF09C0
		public override void Cleanup() {} // 0x0000000186FF09C0-0x0000000186FF0A20
		public override float CalculateTotalDamage() => default; // 0x0000000186FDBCC0-0x0000000186FDBD10
		public override void SetVisible(bool visible) {} // 0x0000000186FDBB20-0x0000000186FDBB60
	}
}
