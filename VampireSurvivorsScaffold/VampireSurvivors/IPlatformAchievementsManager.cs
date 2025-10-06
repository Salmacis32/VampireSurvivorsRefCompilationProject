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
	public interface IPlatformAchievementsManager : ILastErrorProvider // TypeDefIndex: 13915
	{
		// Properties
		AchievementsManagerState State { get; }
	
		// Methods
		void InitAsync(Dictionary<AchievementType, AchievementData> readonly_achievementDefinitions, List<AchievementType> inout_Completed, Action<bool, List<AchievementType>> onComplete);
		void ReportProgressAsync(AchievementType id, float newprogress = 1f /* Metadata: 0x01976B35 */, Action<AchievementType, bool> onComplete = null);
		void Close();
	}
}
