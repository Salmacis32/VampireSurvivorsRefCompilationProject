/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using VampireSurvivors.App.Data.Adventures;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Achievements
{
	[Serializable]
	public class AchievementData // TypeDefIndex: 18481
	{
		// Properties
		public string forcedTexture { get; set; } // 0x0000000180B15C10-0x0000000180B15C20 0x0000000181958310-0x0000000181958370
		public string forcedFrameName { get; set; } // 0x0000000180B15520-0x0000000180B15530 0x0000000181957C80-0x0000000181957CE0
		public string forcedUnlockTips { get; set; } // 0x0000000180B15530-0x0000000180B15540 0x0000000180B1C120-0x0000000180B1C180
		public string description { get; set; } // 0x0000000180B15540-0x0000000180B15550 0x0000000180B1D4C0-0x0000000180B1D520
		public int goldPrize { get; set; } // 0x0000000181953B80-0x0000000181953B90 0x0000000181953B90-0x0000000181953BA0
		public string weaponIcon { get; set; } // 0x0000000180B15560-0x0000000180B15570 0x0000000181953C20-0x0000000181953C80
		public bool achieved { get; set; } // 0x0000000182699160-0x0000000182699170 0x0000000182699170-0x0000000182699180
		public string hyperToUnlock { get; set; } // 0x0000000180B15760-0x0000000180B15770 0x000000018268E650-0x000000018268E6B0
		public string stageToUnlock { get; set; } // 0x000000018197EAB0-0x000000018197EAC0 0x000000018261D810-0x000000018261D870
		public string weaponToUnlock { get; set; } // 0x0000000180B15730-0x0000000180B15740 0x00000001826E9730-0x00000001826E9790
		public bool mistery { get; set; } // 0x000000018289FD40-0x000000018289FD50 0x0000000184EC0B20-0x0000000184EC0B30
		public string relicToUnlock { get; set; } // 0x00000001819A0210-0x00000001819A0220 0x00000001827660A0-0x0000000182766100
		public string arcanaToUnlock { get; set; } // 0x00000001826E99F0-0x00000001826E9A00 0x00000001826E9A00-0x00000001826E9A60
		public string characterToUnlock { get; set; } // 0x00000001819A0360-0x00000001819A0370 0x0000000181917690-0x00000001819176F0
		public List<VampireSurvivors.Data.CharacterType> charactersToUnlock { get; set; } // 0x00000001819A0370-0x00000001819A0380 0x00000001819A0380-0x00000001819A03E0
		public string powerUpToUnlock { get; set; } // 0x00000001819A03E0-0x00000001819A03F0 0x00000001819A03F0-0x00000001819A0450
		public AchievementType Type { get; set; } // 0x0000000181BA6030-0x0000000181BA6040 0x0000000181BA6040-0x0000000181BA6050
		public VampireSurvivors.Data.CharacterType requiresChar { get; set; } // 0x00000001826AC060-0x00000001826AC0D0 0x0000000182897180-0x0000000182897190
		public VampireSurvivors.Data.ItemType requiresItem { get; set; } // 0x000000018198E5F0-0x000000018198E600 0x000000018198E600-0x000000018198E610
		public StageType? requiresStage { get; set; } // 0x000000018675E8F0-0x000000018675E900 0x000000018675E900-0x000000018675E910
		public WeaponType? requiresWeapon { get; set; } // 0x0000000186758980-0x0000000186758990 0x0000000186758990-0x00000001867589A0
		public List<SkinToUnlock> skinsToUnlock { get; set; } // 0x00000001819A0190-0x00000001819A01A0 0x0000000182743780-0x00000001827437E0
		public AdventureProgressData adventureUnlockData { get; set; } // 0x00000001819A01A0-0x00000001819A01B0 0x0000000182A43650-0x0000000182A436B0
		public List<AchievementUnlockConditionData> UnlockConditions { get; set; } // 0x00000001819A0460-0x00000001819A0470 0x0000000182743940-0x00000001827439A0
		public AchievementPlatformData[] PlatformsData { get; set; } // 0x00000001827666D0-0x00000001827666E0 0x0000000184BB7BF0-0x0000000184BB7C50
		[JsonIgnore]
		public string CurrentPlatformData { get => default; } // 0x000000018675FD40-0x000000018675FDB0 
	
		// Constructors
		public AchievementData() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public virtual string GetLocalizedDescription(AchievementType type) => default; // 0x000000018675E910-0x000000018675E9A0
		public virtual string GetLocalizedDescription(AdventureAchievementType type) => default; // 0x000000018675E9A0-0x000000018675EA30
		public virtual string GetLocalizedUnlocks() => default; // 0x000000018675EA30-0x000000018675EBB0
		public virtual string GetLocalizedName() => default; // 0x000000018675EBB0-0x000000018675EC40
		public string GetLocalizationKey() => default; // 0x00000001827AEC70-0x00000001827AECB0
		public virtual bool CheckForCompletion() => default; // 0x0000000180B15290-0x0000000180B152A0
		public virtual void Unlock(PlayerOptionsData config, PlayerOptions playerOptions) {} // 0x000000018675EC40-0x000000018675F530
		public virtual void FixUnlock(PlayerOptions playerOptions, DataManager dataManager, AchievementType type, Dictionary<PowerUpType, int> powerUpCounts) {} // 0x000000018675F530-0x000000018675FD40
	}
}
