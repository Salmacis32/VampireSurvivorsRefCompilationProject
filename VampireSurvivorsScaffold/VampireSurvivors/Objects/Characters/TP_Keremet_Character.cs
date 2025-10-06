/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class TP_Keremet_Character : TP_Character // TypeDefIndex: 17086
	{
		// Fields
		private float OverhealDelay; // 0x3F0
		private float OverhealTriggerValue2; // 0x3F4
		private bool _canOverheal; // 0x3F8
		private VampireSurvivors.Framework.TimerSystem.Timer _overHealTimer; // 0x400
		private Weapon keremetWeapon; // 0x408
	
		// Constructors
		public TP_Keremet_Character() {} // 0x000000018716E5E0-0x000000018716E600
	
		// Methods
		public override void AfterFullInitialization() {} // 0x000000018716DDF0-0x000000018716E0D0
		private void FireMorbus(float value, float rawValue) {} // 0x000000018716E0D0-0x000000018716E5E0
	}
}
