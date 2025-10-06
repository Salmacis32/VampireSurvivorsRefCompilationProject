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
	public class TP_FrozenShade_Character : TP_Character // TypeDefIndex: 17063
	{
		// Fields
		private TP_SoulSteal_Weapon soulStealWeapon; // 0x3F0
		private VampireSurvivors.Framework.TimerSystem.Timer animTimer; // 0x3F8
		private float OverhealTriggerValue; // 0x400
	
		// Constructors
		public TP_FrozenShade_Character() {} // 0x00000001871654D0-0x00000001871654F0
	
		// Methods
		public override void AfterFullInitialization() {} // 0x0000000187164D50-0x0000000187165070
		private void PlayAnimLoop() {} // 0x0000000187165070-0x00000001871650C0
		protected override void OnStop() {} // 0x0000000180B15170-0x0000000180B15180
		private void ConeOfCold(float value, float rawValue) {} // 0x00000001871650C0-0x0000000187165420
		public override void ClearFromSpecialAnims() {} // 0x0000000187165420-0x00000001871654D0
	}
}
