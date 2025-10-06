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
	public class BaseGame_CustomAchivementHandleing : ICustomAchievements // TypeDefIndex: 18493
	{
		// Constructors
		public BaseGame_CustomAchivementHandleing() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public List<AchievementType> CheckAchievements(PlayerOptions playerOptions, AchievementManager achievementManager, DataManager dataManager) => default; // 0x0000000186782480-0x00000001867843C0
		public List<AchievementType> GetUnlocksThatNeedFixing(PlayerOptions playerOptions) => default; // 0x00000001867843C0-0x00000001867846A0
		public List<AchievementType> CheckForStartupAchievements(PlayerOptions playerOptions) => default; // 0x00000001867846A0-0x0000000186784D30
		public void RunSecretsCheck(AchievementManager achievementManager, PlayerOptions playerOptions, DataManager dataManager) {} // 0x0000000186784D30-0x0000000186785DD0
		private bool CheckForStage6Achievement(PlayerOptions playerOptions) => default; // 0x0000000186785DD0-0x0000000186786210
		private bool CheckSigmaUnlock(PlayerOptions playerOptions) => default; // 0x0000000186786210-0x00000001867875E0
		public int CountKilledEnemiesAndVariants(EnemyType enemyType, PlayerOptions playerOptions, DataManager dataManager) => default; // 0x00000001867875E0-0x0000000186787C60
	}
}
