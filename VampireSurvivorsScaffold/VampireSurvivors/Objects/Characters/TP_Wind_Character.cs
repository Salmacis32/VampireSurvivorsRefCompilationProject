/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class TP_Wind_Character : TP_Character // TypeDefIndex: 17131
	{
		// Fields
		private bool _canRetaliate; // 0x3F0
		private float RetaliationDelay; // 0x3F4
		private float OverhealDelay; // 0x3F8
		private float OverhealTriggerValue2; // 0x3FC
		private bool _canOverheal; // 0x400
		private VampireSurvivors.Framework.TimerSystem.Timer _overHealTimer; // 0x408
		private Weapon aurablastWeapon; // 0x410
		private List<WeaponType> spells; // 0x418
	
		// Constructors
		public TP_Wind_Character() {} // 0x000000018717DA10-0x000000018717E710
	
		// Methods
		public override void AfterFullInitialization() {} // 0x000000018717D020-0x000000018717D1D0
		public override bool GetDamaged(float damageAmount) => default; // 0x000000018717D1D0-0x000000018717D440
		private void StatsUp(float value, float rawValue) {} // 0x000000018717D440-0x000000018717DA10
		[Command]
		public void TriggerCoatOfArmsWeapon(int weapon) {} // 0x000000018717C5F0-0x000000018717C640
	}
}
