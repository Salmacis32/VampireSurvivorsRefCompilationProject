/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_HolyWhip2_Weapon : TP_HolyWhip1_Weapon // TypeDefIndex: 16390
	{
		// Fields
		private TP_GothMissile_Weapon _subWeapon; // 0x180
		private bool _totalDamageCalculated; // 0x188
	
		// Constructors
		public TP_HolyWhip2_Weapon() {} // 0x0000000186FC8280-0x0000000186FC8290
	
		// Methods
		protected override void Awake() {} // 0x0000000186FC8680-0x0000000186FC86B0
		protected override void OnStart() {} // 0x0000000186FC86B0-0x0000000186FC87D0
		public override void OnSubWeaponCounter(bool skipTriggers = false /* Metadata: 0x01977C91 */) {} // 0x0000000186FC87D0-0x0000000186FC88D0
		public override void Cleanup() {} // 0x0000000186FC88D0-0x0000000186FC8940
		public override float CalculateTotalDamage() => default; // 0x0000000186FC8940-0x0000000186FC8990
		public override void SetVisible(bool visible) {} // 0x0000000186FC8990-0x0000000186FC89D0
	}
}
