/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class TP_Grant_Character : TP_Character // TypeDefIndex: 17068
	{
		// Fields
		private bool _canRetaliate; // 0x3F0
		private float RetaliationDelay; // 0x3F4
		private float OverhealDelay; // 0x3F8
		private float OverhealTriggerValue; // 0x3FC
		private bool _canOverheal; // 0x400
		private VampireSurvivors.Framework.TimerSystem.Timer _overHealTimer; // 0x408
		private List<WeaponType> knives; // 0x410
	
		// Constructors
		public TP_Grant_Character() {} // 0x0000000187167820-0x0000000187167A90
	
		// Methods
		public override void AfterFullInitialization() {} // 0x0000000187167220-0x0000000187167340
		private void FireAllKnives() {} // 0x0000000187167340-0x0000000187167580
		public override bool GetDamaged(float damageAmount) => default; // 0x0000000187167580-0x00000001871676B0
		private void OverhealTrigger(float value, float rawValue) {} // 0x00000001871676B0-0x0000000187167820
	}
}
