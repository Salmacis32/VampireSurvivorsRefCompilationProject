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
	public class NewAchievementData // TypeDefIndex: 18500
	{
		// Properties
		public List<AchievementUnlockConditionData> UnlockConditions { get; set; } // 0x0000000180B15C10-0x0000000180B15C20 0x0000000181958310-0x0000000181958370
		public string description { get; set; } // 0x0000000180B15520-0x0000000180B15530 0x0000000181957C80-0x0000000181957CE0
		public int goldPrize { get; set; } // 0x000000018195ECC0-0x000000018195ECD0 0x0000000181962000-0x0000000181962010
		public string weaponIcon { get; set; } // 0x0000000180B15540-0x0000000180B15550 0x0000000180B1D4C0-0x0000000180B1D520
		public bool achieved { get; set; } // 0x0000000180B1C110-0x0000000180B1C120 0x000000018197EA10-0x000000018197EA20
		public string hyperToUnlock { get; set; } // 0x0000000180B15560-0x0000000180B15570 0x0000000181953C20-0x0000000181953C80
		public string stageToUnlock { get; set; } // 0x0000000180B15750-0x0000000180B15760 0x000000018260F820-0x000000018260F880
		public string weaponToUnlock { get; set; } // 0x0000000180B15760-0x0000000180B15770 0x000000018268E650-0x000000018268E6B0
		public bool mistery { get; set; } // 0x000000018264AE80-0x000000018264AE90 0x00000001841A6E80-0x00000001841A6E90
		public string relicToUnlock { get; set; } // 0x0000000180B15730-0x0000000180B15740 0x00000001826E9730-0x00000001826E9790
		public string arcanaToUnlock { get; set; } // 0x0000000180B15740-0x0000000180B15750 0x000000018117C120-0x000000018117C180
		public string characterToUnlock { get; set; } // 0x00000001819A0210-0x00000001819A0220 0x00000001827660A0-0x0000000182766100
		public List<VampireSurvivors.Data.CharacterType> charactersToUnlock { get; set; } // 0x00000001826E99F0-0x00000001826E9A00 0x00000001826E9A00-0x00000001826E9A60
		public string powerUpToUnlock { get; set; } // 0x00000001819A0360-0x00000001819A0370 0x0000000181917690-0x00000001819176F0
		public AchievementType Type { get; set; } // 0x0000000181BABE10-0x0000000181BABE20 0x0000000181BABE20-0x0000000181BABE30
		public VampireSurvivors.Data.CharacterType requiresChar { get; set; } // 0x0000000181F7AC50-0x0000000181F7AC60 0x0000000181F7AC60-0x0000000181F7AC70
		public VampireSurvivors.Data.ItemType requiresItem { get; set; } // 0x0000000182518590-0x00000001825185A0 0x00000001825185A0-0x00000001825185B0
		public StageType? requiresStage { get; set; } // 0x0000000184BDAFA0-0x0000000184BDAFB0 0x0000000183B898F0-0x0000000183B89900
		public WeaponType? requiresWeapon { get; set; } // 0x0000000186758960-0x0000000186758970 0x0000000185C8B820-0x0000000185C8B830
		public List<SkinToUnlock> skinsToUnlock { get; set; } // 0x00000001819A0250-0x00000001819A0260 0x0000000181918C00-0x0000000181918C60
		public AdventureProgressData adventureUnlockData { get; set; } // 0x00000001819716D0-0x00000001819716E0 0x00000001819716E0-0x0000000181971740
		public AchievementPlatformData[] PlatformsData { get; set; } // 0x00000001819A0190-0x00000001819A01A0 0x0000000182743780-0x00000001827437E0
		[JsonIgnore]
		public string CurrentPlatformData { get => default; } // 0x0000000186789580-0x00000001867895F0 
	
		// Constructors
		public NewAchievementData() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public virtual string GetLocalizedDescription(AchievementType type) => default; // 0x00000001867881A0-0x0000000186788230
		public virtual string GetLocalizedDescription(AdventureAchievementType type) => default; // 0x0000000186788230-0x00000001867882C0
		public virtual string GetLocalizedUnlocks() => default; // 0x00000001867882C0-0x0000000186788440
		public virtual string GetLocalizedName() => default; // 0x0000000186788440-0x00000001867884D0
		public string GetLocalizationKey() => default; // 0x00000001827AEC70-0x00000001827AECB0
		public virtual bool CheckForCompletion() => default; // 0x0000000180B15290-0x0000000180B152A0
		public virtual void Unlock(PlayerOptionsData config, PlayerOptions playerOptions) {} // 0x00000001867884D0-0x0000000186788DA0
		public virtual void FixUnlock(PlayerOptions playerOptions, DataManager dataManager, AchievementType type, Dictionary<PowerUpType, int> powerUpCounts) {} // 0x0000000186788DA0-0x0000000186789580
	}
}
