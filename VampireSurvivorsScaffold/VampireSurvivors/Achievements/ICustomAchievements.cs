/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Achievements
{
	public interface ICustomAchievements // TypeDefIndex: 18498
	{
		// Methods
		List<AchievementType> CheckAchievements(PlayerOptions playerOptions, AchievementManager achievementManager, DataManager dataManager);
		List<AchievementType> GetUnlocksThatNeedFixing(PlayerOptions playerOptions);
		List<AchievementType> CheckForStartupAchievements(PlayerOptions playerOptions);
		void RunSecretsCheck(AchievementManager achievementManager, PlayerOptions playerOptions, DataManager dataManager);
	}
}
