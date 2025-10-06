/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Achievements;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Data
{
	public class SecretData // TypeDefIndex: 18405
	{
		// Fields
		private const string _prefix = "secretLang/"; // Metadata: 0x01978A95
	
		// Properties
		public string description { get; set; } // 0x0000000180B15C10-0x0000000180B15C20 0x0000000181958310-0x0000000181958370
		public CharacterType? characterToUnlock { get; set; } // 0x0000000180B15520-0x0000000180B15530 0x0000000182759640-0x0000000182759650
		public WeaponType? weaponToUnlock { get; set; } // 0x0000000180B15530-0x0000000180B15540 0x0000000182759650-0x0000000182759660
		public StageType? stageToUnlock { get; set; } // 0x0000000180B15540-0x0000000180B15550 0x0000000185A2C780-0x0000000185A2C790
		public StageType? hyperToUnlock { get; set; } // 0x0000000180B15550-0x0000000180B15560 0x00000001847D19F0-0x00000001847D1A00
		public ItemType? relicToUnlock { get; set; } // 0x0000000180B15560-0x0000000180B15570 0x000000018197EA80-0x000000018197EA90
		public ArcanaType? arcanaToUnlock { get; set; } // 0x0000000180B15750-0x0000000180B15760 0x000000018197EA90-0x000000018197EAA0
		public PowerUpType? powerUpToUnlock { get; set; } // 0x0000000180B15760-0x0000000180B15770 0x000000018197EAA0-0x000000018197EAB0
		public bool mistery { get; set; } // 0x000000018264AE80-0x000000018264AE90 0x00000001841A6E80-0x00000001841A6E90
		public bool achieved { get; set; } // 0x00000001848FA660-0x00000001848FA670 0x0000000185E0DBC0-0x0000000185E0DBD0
		public bool isSpell { get; set; } // 0x0000000185479BF0-0x0000000185479C00 0x0000000185E0DBD0-0x0000000185E0DBE0
		public string spell { get; set; } // 0x0000000180B15730-0x0000000180B15740 0x00000001826E9730-0x00000001826E9790
		public string special { get; set; } // 0x0000000180B15740-0x0000000180B15750 0x000000018117C120-0x000000018117C180
		public bool hidden { get; set; } // 0x0000000183D894D0-0x0000000183D894E0 0x0000000183D894E0-0x0000000183D894F0
		public int? goldPrize { get; set; } // 0x0000000186757060-0x0000000186757070 0x00000001835D2FA0-0x00000001835D2FB0
		public bool isModifier { get; set; } // 0x00000001819A0230-0x00000001819A0240 0x000000018262A110-0x000000018262A120
		public List<SkinToUnlock> skinsToUnlock { get; set; } // 0x00000001819A0360-0x00000001819A0370 0x0000000181917690-0x00000001819176F0
		public List<WeaponType> weaponListToUnlock { get; set; } // 0x00000001819A0370-0x00000001819A0380 0x00000001819A0380-0x00000001819A03E0
		public ItemType? requiresRelic { get; set; } // 0x00000001819A03E0-0x00000001819A03F0 0x0000000184BBA3E0-0x0000000184BBA3F0
		public string customTexture { get; set; } // 0x0000000181919F80-0x0000000181919F90 0x000000018198E590-0x000000018198E5F0
		public string customFrame { get; set; } // 0x0000000181971630-0x0000000181971640 0x0000000182649B10-0x0000000182649B70
		public string customSmallTexture { get; set; } // 0x00000001819A0250-0x00000001819A0260 0x0000000181918C00-0x0000000181918C60
		public string customSmallFrame { get; set; } // 0x00000001819716D0-0x00000001819716E0 0x00000001819716E0-0x0000000181971740
	
		// Constructors
		public SecretData() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public Sprite GetSecondReward(DataManager dataManager) => default; // 0x0000000186757070-0x0000000186757660
		public string GetLocalizedDescriptionTerm(SecretType t) => default; // 0x0000000186757660-0x00000001867576F0
	}
}
