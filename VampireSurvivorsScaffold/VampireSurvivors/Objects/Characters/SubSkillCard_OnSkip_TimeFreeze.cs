/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class SubSkillCard_OnSkip_TimeFreeze : CharacterSkillCard_Base // TypeDefIndex: 16895
	{
		// Constructors
		public SubSkillCard_OnSkip_TimeFreeze() {} // Dummy constructor
		public SubSkillCard_OnSkip_TimeFreeze(ArcanaType type) {} // 0x00000001870D5D20-0x00000001870D5D30
	
		// Methods
		public override void OnOwnerLevelUpSkipped() {} // 0x00000001870EA5E0-0x00000001870EA740
		[Command]
		public void TriggerTimeStop(long startingSimFrame) {} // 0x00000001870EA740-0x00000001870EA820
		private void TimeStop() {} // 0x00000001870EA820-0x00000001870EA9F0
	}
}
