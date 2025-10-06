/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.TimerSystem;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class TP_Barlowe_Character : TP_Character // TypeDefIndex: 17035
	{
		// Fields
		public float bonusConst; // 0x3F0
		public float bonusStat; // 0x3F4
		public float overhealingTotal; // 0x3F8
		private float OverhealTriggerValue; // 0x3FC
		private VampireSurvivors.Framework.TimerSystem.Timer _overHealTimer; // 0x400
	
		// Constructors
		public TP_Barlowe_Character() {} // 0x0000000187151F00-0x0000000187151F30
	
		// Methods
		public override float PPower() => default; // 0x0000000187151AF0-0x0000000187151C00
		public override float PCurse() => default; // 0x0000000187151C00-0x0000000187151D70
		public override void AfterFullInitialization() {} // 0x0000000187151D70-0x0000000187151E90
		public override WeaponType GetFourthLevelUpOption() => default; // 0x0000000187151E90-0x0000000187151EB0
		private void StatsUp(float value, float rawValue) {} // 0x0000000187151EB0-0x0000000187151F00
	}
}
