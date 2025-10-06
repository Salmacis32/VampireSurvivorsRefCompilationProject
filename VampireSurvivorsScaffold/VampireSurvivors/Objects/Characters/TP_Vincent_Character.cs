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
	public class TP_Vincent_Character : TP_Character // TypeDefIndex: 17127
	{
		// Fields
		public float bonusConst; // 0x3F0
		public float bonusGreed; // 0x3F4
		public float overhealingTotal; // 0x3F8
		private float OverhealTriggerValue; // 0x3FC
		private VampireSurvivors.Framework.TimerSystem.Timer _overHealTimer; // 0x400
	
		// Constructors
		public TP_Vincent_Character() {} // 0x000000018717BF80-0x000000018717BFB0
	
		// Methods
		public override float PGreed() => default; // 0x000000018717BBA0-0x000000018717BD40
		public override void AfterFullInitialization() {} // 0x000000018717BD40-0x000000018717BF80
		private void GreedUp(float value, float rawValue) {} // 0x0000000187151EB0-0x0000000187151F00
	}
}
