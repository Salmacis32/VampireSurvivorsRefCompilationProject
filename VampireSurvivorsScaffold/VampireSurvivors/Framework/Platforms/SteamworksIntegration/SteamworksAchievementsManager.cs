/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Steamworks;
using VampireSurvivors;
using VampireSurvivors.Achievements;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Platforms;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Platforms.SteamworksIntegration
{
	public class SteamworksAchievementsManager : IPlatformAchievementsManager // TypeDefIndex: 18203
	{
		// Fields
		private ErroInfo m_LastError; // 0x10
		private AchievementsManagerState m_State; // 0x28
		private Dictionary<AchievementType, AchievementData> m_AchievementDefinitions; // 0x30
		private bool m_storeStats; // 0x38
		protected Action<bool, List<AchievementType>> m_onInitCompleteCallback; // 0x40
		protected List<AchievementType> m_inout_Completed; // 0x48
	
		// Properties
		public AchievementsManagerState State { get => default; } // 0x0000000181FFD1B0-0x0000000181FFD1C0 
		public ErroInfo LastError { get => default; } // 0x00000001830E71E0-0x00000001830E7200 
	
		// Constructors
		public SteamworksAchievementsManager() {} // 0x00000001866FC0C0-0x00000001866FC180
	
		// Methods
		public void Close() {} // 0x00000001866FB3B0-0x00000001866FB540
		public void InitAsync(Dictionary<AchievementType, AchievementData> readonly_achievementDefinitions, List<AchievementType> inout_Completed, Action<bool, List<AchievementType>> onComplete) {} // 0x00000001866FB540-0x00000001866FB910
		private void OnUserStatsReceived(SteamId steamId, Steamworks.Result result) {} // 0x00000001866FB910-0x00000001866FBD30
		public void ReportProgressAsync(AchievementType id, float newprogress = 1f /* Metadata: 0x0197887F */, Action<AchievementType, bool> onComplete = null) {} // 0x00000001866FBD30-0x00000001866FC0C0
	}
}
