/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.TimerSystem;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class TP_Maxim_Character : TP_Character // TypeDefIndex: 17099
	{
		// Fields
		public float bonusConst; // 0x3F0
		public float bonusStats; // 0x3F4
		public float overhealingTotal; // 0x3F8
		private float OverhealTriggerValue; // 0x3FC
		private VampireSurvivors.Framework.TimerSystem.Timer _overHealTimer; // 0x400
	
		// Constructors
		public TP_Maxim_Character() {} // 0x0000000187151F00-0x0000000187151F30
	
		// Methods
		public override float PPower() => default; // 0x0000000187172310-0x0000000187172450
		public override float PSpeed() => default; // 0x0000000187172450-0x00000001871724E0
		public override void AfterFullInitialization() {} // 0x00000001871724E0-0x00000001871725F0
		private void StatsUp(float value, float rawValue) {} // 0x0000000187151EB0-0x0000000187151F00
	}
}
