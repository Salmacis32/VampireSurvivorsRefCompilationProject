/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.TimerSystem;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class TP_Maria_Character : CharacterController // TypeDefIndex: 17096
	{
		// Fields
		private int _followers; // 0x3F0
		public float bonusConst; // 0x3F4
		public float bonusStats; // 0x3F8
		public float overhealingTotal; // 0x3FC
		private float OverhealDelay; // 0x400
		private float OverhealTriggerValue; // 0x404
		private float OverhealTriggerValue2; // 0x408
		private bool _canOverheal; // 0x40C
		private VampireSurvivors.Framework.TimerSystem.Timer _overHealTimer; // 0x410
		private List<VampireSurvivors.Data.CharacterType> possibleFollowers; // 0x418
		private List<VampireSurvivors.Data.CharacterType> currentFollowers; // 0x420
	
		// Constructors
		public TP_Maria_Character() {} // 0x0000000187171650-0x0000000187171940
	
		// Methods
		public override float PPower() => default; // 0x0000000187170B40-0x0000000187170BC0
		public override void AfterFullInitialization() {} // 0x0000000187170BC0-0x0000000187170DB0
		public override void LevelUp() {} // 0x0000000187170DB0-0x0000000187170E90
		private void AddRandomFollower() {} // 0x0000000187170E90-0x0000000187171260
		private void StatsUp(float value, float rawValue) {} // 0x0000000187171260-0x0000000187171650
	}
}
