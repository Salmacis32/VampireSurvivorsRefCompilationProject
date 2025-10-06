/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Achievements;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Platforms;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class DummyAchievementsManager : IPlatformAchievementsManager // TypeDefIndex: 13916
	{
		// Fields
		private AchievementsManagerState m_State; // 0x10
	
		// Properties
		public ErroInfo LastError { get => default; } // 0x00000001865C2B20-0x00000001865C2B90 
		public AchievementsManagerState State { get => default; } // 0x0000000180B15510-0x0000000180B15520 
	
		// Constructors
		public DummyAchievementsManager() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public void Close() {} // 0x0000000183749850-0x0000000183749860
		public void InitAsync(Dictionary<AchievementType, AchievementData> readonly_achievementDefinitions, List<AchievementType> inout_Completed, Action<bool, List<AchievementType>> onComplete) {} // 0x00000001865C2B90-0x00000001865C2BB0
		public void ReportProgressAsync(AchievementType id, float newprogress = 1f /* Metadata: 0x01976B39 */, Action<AchievementType, bool> onComplete = null) {} // 0x00000001865C2BB0-0x00000001865C2BD0
	}
}
