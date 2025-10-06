/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_PlatinumWhip2_Weapon : TP_PlatinumWhip1_Weapon // TypeDefIndex: 16436
	{
		// Fields
		private TP_GrandCross_Weapon _subWeapon; // 0x178
		private bool _totalDamageCalculated; // 0x180
	
		// Constructors
		public TP_PlatinumWhip2_Weapon() {} // 0x0000000186FDB650-0x0000000186FDB6C0
	
		// Methods
		protected override void Awake() {} // 0x0000000186FDB810-0x0000000186FDB830
		protected override void OnStart() {} // 0x0000000186FDB830-0x0000000186FDBA20
		public override void OnSubWeaponCounter(bool skipTriggers = false /* Metadata: 0x01977CAF */) {} // 0x0000000186FDBA20-0x0000000186FDBB20
		public override void SetVisible(bool visible) {} // 0x0000000186FDBB20-0x0000000186FDBB60
		public override void Cleanup() {} // 0x0000000186FDBB60-0x0000000186FDBBC0
		public override void InternalUpdate() {} // 0x0000000186FDBBC0-0x0000000186FDBCC0
		public override float CalculateTotalDamage() => default; // 0x0000000186FDBCC0-0x0000000186FDBD10
	}
}
