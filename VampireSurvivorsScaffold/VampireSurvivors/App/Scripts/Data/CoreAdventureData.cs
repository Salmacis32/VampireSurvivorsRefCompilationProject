/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Poncle.Schema.Attributes.Attributes;
using VampireSurvivors.Achievements;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Scripts.Data
{
	[Serializable]
	public class CoreAdventureData // TypeDefIndex: 18837
	{
		// Properties
		[JsonProperty("name")]
		[Title("Adventure Name")]
		public string AdventureName { get; set; } // 0x0000000180B15C10-0x0000000180B15C20 0x0000000181958310-0x0000000181958370
		[JsonProperty("subtitleImage")]
		[Title("Subtitle Image")]
		public string SubtitleImage { get; set; } // 0x0000000180B15520-0x0000000180B15530 0x0000000181957C80-0x0000000181957CE0
		[JsonProperty("startingCoins")]
		[Title("Starting Coins")]
		public int StartingCoins { get; set; } // 0x000000018195ECC0-0x000000018195ECD0 0x0000000181962000-0x0000000181962010
		[JsonProperty("startingCharacter")]
		[Title("Starting Character")]
		public VampireSurvivors.Data.CharacterType StartingCharacter { get; set; } // 0x0000000181E0A5A0-0x0000000181E0A5B0 0x0000000181E0A5B0-0x0000000181E0A5C0
		[JsonProperty("startingStage")]
		[Title("Starting Stage")]
		public StageType StartingStage { get; set; } // 0x0000000181FFD1B0-0x0000000181FFD1C0 0x0000000181FFD1C0-0x0000000181FFD1D0
		[JsonProperty("spriteName")]
		[Title("Sprite Name")]
		public string SpriteName { get; set; } // 0x0000000180B15550-0x0000000180B15560 0x0000000180B1D520-0x0000000180B1D580
		[JsonProperty("texture")]
		[Title("Texture")]
		public string Texture { get; set; } // 0x0000000180B15560-0x0000000180B15570 0x0000000181953C20-0x0000000181953C80
		[JsonProperty("requiresDLC")]
		[Title("Requires DLC")]
		public DlcType? RequiresDLC { get; set; } // 0x0000000180B15750-0x0000000180B15760 0x000000018197EA90-0x000000018197EAA0
		[JsonProperty("completionCoinReward")]
		[Title("Completion Reward")]
		public int CompletionCoinReward { get; set; } // 0x00000001819A01B0-0x00000001819A01C0 0x00000001828975D0-0x00000001828975E0
		[JsonProperty("completionSkinsReward")]
		[Title("Completion Skins")]
		public List<SkinToUnlock> CompletionSkinsReward { get; set; } // 0x000000018197EAB0-0x000000018197EAC0 0x000000018261D810-0x000000018261D870
	
		// Constructors
		public CoreAdventureData() {} // 0x0000000180B15170-0x0000000180B15180
	}
}
