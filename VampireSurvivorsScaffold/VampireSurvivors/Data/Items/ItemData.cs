/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Poncle.Schema.Attributes.Attributes;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Data.Items
{
	[Serializable]
	[Title("Item")]
	public class ItemData // TypeDefIndex: 18465
	{
		// Properties
		[Title("Name")]
		public string name { get; set; } // 0x0000000180B15C10-0x0000000180B15C20 0x0000000181958310-0x0000000181958370
		[Title("Description")]
		public string description { get; set; } // 0x0000000180B15520-0x0000000180B15530 0x0000000181957C80-0x0000000181957CE0
		[Title("Achievement Tips")]
		public string achievementTips { get; set; } // 0x0000000180B15530-0x0000000180B15540 0x0000000180B1C120-0x0000000180B1C180
		[Title("Tips")]
		public string tips { get; set; } // 0x0000000180B15540-0x0000000180B15550 0x0000000180B1D4C0-0x0000000180B1D520
		[Title("Texture")]
		public string texture { get; set; } // 0x0000000180B15550-0x0000000180B15560 0x0000000180B1D520-0x0000000180B1D580
		[Title("Frame Name")]
		public string frameName { get; set; } // 0x0000000180B15560-0x0000000180B15570 0x0000000181953C20-0x0000000181953C80
		[Title("Picked Up Amount")]
		public int pickedupAmount { get; set; } // 0x0000000181953C80-0x0000000181953C90 0x0000000181953C90-0x0000000181953CA0
		[Title("Rarity")]
		public float rarity { get; set; } // 0x000000018275A5C0-0x000000018275A5D0 0x000000018275A5D0-0x000000018275A5E0
		[Title("Unlocks At")]
		public int unlocksAt { get; set; } // 0x00000001819A01B0-0x00000001819A01C0 0x00000001828975D0-0x00000001828975E0
		[Title("Value")]
		public float value { get; set; } // 0x000000018288BAA0-0x000000018288BAB0 0x000000018289F1C0-0x000000018289F1D0
		[Title("In Treasures")]
		public bool inTreasures { get; set; } // 0x000000018264AE80-0x000000018264AE90 0x00000001841A6E80-0x00000001841A6E90
		[Title("Seen")]
		public bool seen { get; set; } // 0x00000001848FA660-0x00000001848FA670 0x0000000185E0DBC0-0x0000000185E0DBD0
		[Title("Is Rare")]
		public bool isRare { get; set; } // 0x0000000185479BF0-0x0000000185479C00 0x0000000185E0DBD0-0x0000000185E0DBE0
		[Title("Is Relic")]
		public bool isRelic { get; set; } // 0x0000000185E0DBE0-0x0000000185E0DBF0 0x0000000185E0DBF0-0x0000000185E0DC00
		[Title("Is Unlocked")]
		public bool isUnlocked { get; set; } // 0x00000001841A3FD0-0x00000001841A3FE0 0x00000001841A3FE0-0x00000001841A3FF0
		[Title("Hidden")]
		public bool hidden { get; set; } // 0x00000001856B6220-0x00000001856B6230 0x0000000185DE0A50-0x0000000185DE0A60
		[Title("Always Hidden")]
		public bool alwaysHidden { get; set; } // 0x0000000184A2E4C0-0x0000000184A2E4D0 0x000000018675C320-0x000000018675C330
		[Title("Fever MS")]
		public int feverMS { get; set; } // 0x00000001819A01E0-0x00000001819A01F0 0x0000000181EDFC80-0x0000000181EDFC90
		[Title("Is Special Option")]
		public bool isSpecialOption { get; set; } // 0x0000000184A19620-0x0000000184A19630 0x000000018507F980-0x000000018507F990
		[Title("Sealable")]
		public bool sealable { get; set; } // 0x0000000185EA8440-0x0000000185EA8450 0x0000000185EA8450-0x0000000185EA8460
		[Title("Requires DLC")]
		public DlcType? requiresDLC { get; set; } // 0x0000000180B15740-0x0000000180B15750 0x0000000184E2EFF0-0x0000000184E2F000
		[Title("Requires Item")]
		public VampireSurvivors.Data.ItemType? requiresItem { get; set; } // 0x00000001819A0210-0x00000001819A0220 0x0000000184235400-0x0000000184235410
		[Title("Requires Arcana")]
		public ArcanaType? requiresArcana { get; set; } // 0x00000001826E99F0-0x00000001826E9A00 0x0000000183BF5D20-0x0000000183BF5D30
		[Title("Collection Frame")]
		public string collectionFrame { get; set; } // 0x00000001819A0360-0x00000001819A0370 0x0000000181917690-0x00000001819176F0
		[Title("Show Above All")]
		public bool showAboveAll { get; set; } // 0x00000001831F88E0-0x00000001831F88F0 0x00000001831F88F0-0x00000001831F8900
		[Title("Exclude From Default Loot Table")]
		public bool excludeFromDefaultLootTable { get; set; } // 0x0000000184BBA180-0x0000000184BBA190 0x0000000184BBA190-0x0000000184BBA1A0
		public bool ignoreForcedMovement { get; set; } // 0x0000000184B5DE30-0x0000000184B5DE40 0x0000000184B5DE40-0x0000000184B5DE50
		[Title("Content Group")]
		public ContentGroupType contentGroup { get; set; } // 0x0000000181F7AC50-0x0000000181F7AC60 0x0000000181F7AC60-0x0000000181F7AC70
	
		// Constructors
		public ItemData() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public string GetLocalizedDescription(VampireSurvivors.Data.ItemType type) => default; // 0x000000018675C330-0x000000018675C480
		public string GetLocalizedTips(VampireSurvivors.Data.ItemType type) => default; // 0x000000018675C480-0x000000018675C5D0
		public string GetLocalizedName(VampireSurvivors.Data.ItemType type) => default; // 0x000000018675C5D0-0x000000018675C720
		public string GetLocalizedAchievementTips(VampireSurvivors.Data.ItemType type) => default; // 0x000000018675C720-0x000000018675C870
		public string GetLocalPrefix(VampireSurvivors.Data.ItemType t) => default; // 0x000000018675C870-0x000000018675C900
	}
}
