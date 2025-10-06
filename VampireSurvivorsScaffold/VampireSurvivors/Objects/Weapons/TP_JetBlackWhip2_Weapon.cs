/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_JetBlackWhip2_Weapon : TP_JetBlackWhip1_Weapon // TypeDefIndex: 16416
	{
		// Fields
		private TP_DarkRift_Weapon _subWeapon; // 0x188
		private bool _totalDamageCalculated; // 0x190
	
		// Constructors
		public TP_JetBlackWhip2_Weapon() {} // 0x0000000186FC8280-0x0000000186FC8290
	
		// Methods
		protected override void Awake() {} // 0x0000000186FD4470-0x0000000186FD44B0
		protected override void OnStart() {} // 0x0000000186FD44B0-0x0000000186FD45D0
		public override void OnSubWeaponCounter(bool skipTriggers = false /* Metadata: 0x01977C9B */) {} // 0x0000000186FD45D0-0x0000000186FD46E0
		public override void Cleanup() {} // 0x0000000186FD46E0-0x0000000186FD4750
		public override float CalculateTotalDamage() => default; // 0x0000000186FA6AC0-0x0000000186FA6B10
		public override void SetVisible(bool visible) {} // 0x0000000186FA6B10-0x0000000186FA6B50
	}
}
