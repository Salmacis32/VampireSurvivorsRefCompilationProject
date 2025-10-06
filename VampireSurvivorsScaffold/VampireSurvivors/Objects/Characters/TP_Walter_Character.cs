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
	public class TP_Walter_Character : TP_Character // TypeDefIndex: 17129
	{
		// Fields
		private float OverhealDelay; // 0x3F0
		private float OverhealTriggerValue2; // 0x3F4
		private bool _canOverheal; // 0x3F8
		private VampireSurvivors.Framework.TimerSystem.Timer _overHealTimer; // 0x400
		private Weapon aurablastWeapon; // 0x408
		private List<WeaponType> spells; // 0x410
	
		// Properties
		public override bool DrainWeaponsImmunity { get => default; } // 0x0000000181958370-0x0000000181958380 
	
		// Constructors
		public TP_Walter_Character() {} // 0x000000018717C640-0x000000018717CC90
	
		// Methods
		public override void AfterFullInitialization() {} // 0x000000018717BFB0-0x000000018717C0D0
		private void StatsUp(float value, float rawValue) {} // 0x000000018717C0D0-0x000000018717C5F0
		[Command]
		public void TriggerWeapon(int weapon) {} // 0x000000018717C5F0-0x000000018717C640
	}
}
