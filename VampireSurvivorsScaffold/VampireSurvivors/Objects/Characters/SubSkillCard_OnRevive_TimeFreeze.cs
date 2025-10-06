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
	public class SubSkillCard_OnRevive_TimeFreeze : CharacterSkillCard_Base // TypeDefIndex: 16888
	{
		// Constructors
		public SubSkillCard_OnRevive_TimeFreeze() {} // Dummy constructor
		public SubSkillCard_OnRevive_TimeFreeze(ArcanaType type) {} // 0x00000001870D5D20-0x00000001870D5D30
	
		// Methods
		public override void OnOwnerRevived(float percentage = 1f /* Metadata: 0x01977ED4 */, bool instantRevival = false /* Metadata: 0x01977ED8 */) {} // 0x00000001870E8490-0x00000001870E8610
		[Command]
		public void TriggerTimeStop(long startingSimFrame) {} // 0x00000001870E8610-0x00000001870E86F0
		private void TimeStop() {} // 0x00000001870E86F0-0x00000001870E88C0
	}
}
