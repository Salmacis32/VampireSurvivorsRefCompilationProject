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
using VampireSurvivors.Framework.Platforms.Saves;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Scripts.Framework.Initialisation
{
	public static class PlatformIntegration // TypeDefIndex: 18830
	{
		// Methods
		public static void Init(PlayerOptions playerOptions, AchievementManager achievementManager, Action onComplete) {} // 0x0000000186844AA0-0x0000000186844D70
		private static void LicenseCheckDlc(Action onComplete) {} // 0x0000000186844D70-0x0000000186844DC0
		private static void UpdateDlc(Action onComplete) {} // 0x0000000186844DC0-0x0000000186844ED0
		private static void LoadDlc(Action onComplete) {} // 0x0000000186844ED0-0x0000000186845080
		private static void SignIn(Action onComplete, Action onError) {} // 0x0000000186845080-0x00000001868452B0
		private static void InitStorage(Action onComplete, Action onError) {} // 0x00000001868452B0-0x00000001868455C0
		private static void Load(PlayerOptions playerOptions, Action onComplete, Action onError) {} // 0x00000001868455C0-0x00000001868458B0
		private static void HandleSaveDataCorruptedDialog(Action onComplete) {} // 0x00000001868458B0-0x0000000186845940
		private static void SetCurrentLanguageCode() {} // 0x0000000186845940-0x0000000186845A60
		private static void HandleNoFreeSpaceWhenLoading(PlayerOptions playerOptions, Action onComplete, Action onError) {} // 0x0000000186845A60-0x0000000186845D10
		private static void ShowInternalNoFreeSpaceDialog(PlayerOptions playerOptions, Action button1Callback, Action button2Callback) {} // 0x0000000186845D10-0x0000000186845DF0
		private static void SyncAchievements(PlayerOptions playerOptions, AchievementManager achievementManager) {} // 0x0000000186845DF0-0x00000001868461A0
		private static void FireProgressUpdate(string term, bool isTerm = true /* Metadata: 0x0197AFC3 */) {} // 0x00000001868461A0-0x0000000186846270
	}
}
