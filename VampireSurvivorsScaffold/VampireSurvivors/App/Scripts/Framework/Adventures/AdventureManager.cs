/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Unity.Profiling;
using VampireSurvivors.App.Data.Adventures;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Scripts.Framework.Adventures
{
	[UsedImplicitly]
	public class AdventureManager : IInitializable, IDisposable // TypeDefIndex: 18835
	{
		// Fields
		public static int MAX_ASCENSION_POINTS; // 0x00
		[Inject]
		private PlayerOptions _playerOptions; // 0x10
		[Inject]
		private DataManager _dataManager; // 0x18
		private static AdventureManager _adventureManagerInstance; // 0x08
		private static readonly ProfilerMarker MarkerInitAdventure; // 0x10
		private static readonly ProfilerMarker MarkerInitDataManager; // 0x18
		public AdventureType CurrentAdventure; // 0x28
	
		// Properties
		public static bool IsInAdventureMode { get; set; } // 0x0000000186848BC0-0x0000000186848C20 0x0000000186848C20-0x0000000186848C80
		public static DlcType? CurrentAdventureDlcType { get; private set; } // 0x0000000186848C80-0x0000000186848CE0 0x0000000186848CE0-0x0000000186848D40
		public static bool ShouldExitAdventureModeOnDisconnect { get; set; } // 0x0000000186848D40-0x0000000186848DA0 0x0000000186848DA0-0x0000000186848E00
		public PlayerOptionsData CurrentAdventureSaveData { get => default; } // 0x0000000186848E00-0x0000000186848E10 
		public AdventureData AdventureData { get; private set; } // 0x0000000180B15530-0x0000000180B15540 0x0000000180B1C120-0x0000000180B1C180
		public Action<AdventureType> OnAdventureStartedEvent { get; set; } // 0x0000000180B15550-0x0000000180B15560 0x0000000180B1D520-0x0000000180B1D580
		public Action OnAdventureExitEvent { get; set; } // 0x0000000180B15560-0x0000000180B15570 0x0000000181953C20-0x0000000181953C80
		public Action<bool> OnAdventureAscended { get; set; } // 0x0000000180B15750-0x0000000180B15760 0x000000018260F820-0x000000018260F880
	
		// Constructors
		public AdventureManager() {} // 0x0000000180B15170-0x0000000180B15180
		static AdventureManager() {} // 0x000000018684C6E0-0x000000018684C870
	
		// Methods
		public void Initialize() {} // 0x0000000186848E10-0x0000000186848ED0
		public void Dispose() {} // 0x0000000180B15170-0x0000000180B15180
		public void InitAdventure(AdventureType adventureType) {} // 0x0000000186848ED0-0x0000000186849550
		public bool HasLoadedAtLeastOneDlcWithAdventures() => default; // 0x0000000186849550-0x0000000186849800
		public bool IsOwned(AdventureType type) => default; // 0x0000000186849800-0x0000000186849A30
		public bool AscendAdventure(AdventureType adventureType, bool forceShowAscensionConfirmation = false /* Metadata: 0x0197AFC5 */) => default; // 0x0000000186849A30-0x0000000186849DF0
		public void ResetAdventureProgress(AdventureType adventureType) {} // 0x0000000186849DF0-0x000000018684A060
		public static void ForceExitAdventure() {} // 0x000000018684A060-0x000000018684A0E0
		public void ExitAdventureMode(bool fireExitEvent = true /* Metadata: 0x0197AFC6 */, bool resetDataManager = true /* Metadata: 0x0197AFC7 */, bool force = false /* Metadata: 0x0197AFC8 */) {} // 0x000000018684A0E0-0x000000018684A610
		public bool IsAdventureCharacter(VampireSurvivors.Data.CharacterType characterType) => default; // 0x000000018684A610-0x000000018684A6F0
		public bool IsAdventureCompleted(AdventureType adventureType) => default; // 0x000000018684A6F0-0x000000018684A880
		public bool WasAdventureAlreadyCompleted(AdventureType adventureType) => default; // 0x000000018684A880-0x000000018684A9C0
		public bool CanAscend(AdventureType adventureType) => default; // 0x000000018684A9C0-0x000000018684AAD0
		public void InitDataManagerForAdventure(AdventureType adventureType) {} // 0x000000018684AAD0-0x000000018684B200
		private void ApplyAscension(PlayerOptionsData adventurePod, AdventureType adventureType) {} // 0x000000018684B200-0x000000018684B480
		private void CopyCoreSettingsFromAdventureToBaseGame(PlayerOptionsData AdventureGameSaveData) {} // 0x000000018684B480-0x000000018684B6B0
		private PlayerOptionsData StartNewAdventure(AdventureType adventureType) => default; // 0x000000018684B6B0-0x000000018684B790
		private PlayerOptionsData GenerateNewAdventureData(PlayerOptionsData currentSaveData, AdventureType adventureType) => default; // 0x000000018684B790-0x000000018684B850
		private PlayerOptionsData PopulateSaveDataWithAdventureData(PlayerOptionsData adventureSaveData, AdventureType adventureType) => default; // 0x000000018684B850-0x000000018684BAD0
		public void CopyDataFromBaseGame(PlayerOptionsData baseGameSaveData, PlayerOptionsData adventureSaveData) {} // 0x000000018684BAD0-0x000000018684BC00
		private void CopyArcanasFromBaseGame(PlayerOptionsData baseGameSaveData, PlayerOptionsData adventureSaveData) {} // 0x000000018684BC00-0x000000018684BE90
		private void CopyCoreSettingsFromBaseGame(PlayerOptionsData baseGameSaveData, PlayerOptionsData adventureSaveData) {} // 0x000000018684BE90-0x000000018684C0C0
		private void CopySkinsFromBaseGame(PlayerOptionsData baseGameSaveData, PlayerOptionsData adventureSaveData) {} // 0x000000018684C0C0-0x000000018684C1C0
		private void CopyRelicsFromBaseGame(PlayerOptionsData baseGameSaveData, PlayerOptionsData adventureSaveData) {} // 0x000000018684C1C0-0x000000018684C540
		private PlayerOptionsData LoadAdventureData(AdventureType adventureType) => default; // 0x000000018684C540-0x000000018684C6E0
	}
}
