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
	public class SubSkillCard_Overheal_FeverUp : CharacterSkillCard_Base // TypeDefIndex: 16896
	{
		// Fields
		private float overhealTriggerValue; // 0x70
		private VampireSurvivors.Framework.TimerSystem.Timer overHealTimer; // 0x78
		private bool canOverheal; // 0x80
		private float overhealDelay; // 0x84
	
		// Constructors
		public SubSkillCard_Overheal_FeverUp() {} // Dummy constructor
		public SubSkillCard_Overheal_FeverUp(ArcanaType type) {} // 0x00000001870EA9F0-0x00000001870EAA10
	
		// Methods
		public override void InitialActivate() {} // 0x00000001870EAA10-0x00000001870EAB40
		private void CharacterHealed(float value, float rawValue) {} // 0x00000001870EAB40-0x00000001870EAEB0
		protected void OnOverhealTriggered(float value, float rawValue) {} // 0x00000001870EAEB0-0x00000001870EB0F0
	}
}
