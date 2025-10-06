/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Poncle.Schema.Attributes.Attributes;
using VampireSurvivors.App.Data;
using VampireSurvivors.App.Objects;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Data.Stage
{
	[Serializable]
	public class StageData // TypeDefIndex: 18462
	{
		// Properties
		[Title("Order")]
		public int order { get; set; } // 0x0000000180B15510-0x0000000180B15520 0x0000000180B19030-0x0000000180B19040
		[Title("Tileset Stage Type")]
		public StageType? tilesetStageType { get; set; } // 0x0000000184079BF0-0x0000000184079C00 0x0000000182894100-0x0000000182894110
		[Title("Name")]
		public string stageName { get; set; } // 0x0000000180B15530-0x0000000180B15540 0x0000000180B1C120-0x0000000180B1C180
		[Title("Description")]
		public string description { get; set; } // 0x0000000180B15540-0x0000000180B15550 0x0000000180B1D4C0-0x0000000180B1D520
		[Title("UI Texture")]
		public string uiTexture { get; set; } // 0x0000000180B15550-0x0000000180B15560 0x0000000180B1D520-0x0000000180B1D580
		[Title("UI Frame")]
		public string uiFrame { get; set; } // 0x0000000180B15560-0x0000000180B15570 0x0000000181953C20-0x0000000181953C80
		[Title("Texture")]
		public string texture { get; set; } // 0x0000000180B15750-0x0000000180B15760 0x000000018260F820-0x000000018260F880
		[Title("Bestiary BG")]
		public string bestiaryBG { get; set; } // 0x0000000180B15760-0x0000000180B15770 0x000000018268E650-0x000000018268E6B0
		[Title("Stage Number")]
		public string stageNumber { get; set; } // 0x000000018197EAB0-0x000000018197EAC0 0x000000018261D810-0x000000018261D870
		[Title("Frame Name")]
		public string frameName { get; set; } // 0x0000000180B15730-0x0000000180B15740 0x00000001826E9730-0x00000001826E9790
		[Title("Frame Name Unlock")]
		public string frameNameUnlock { get; set; } // 0x0000000180B15740-0x0000000180B15750 0x000000018117C120-0x000000018117C180
		[Title("Unlocked")]
		public bool unlocked { get; set; } // 0x0000000183D894D0-0x0000000183D894E0 0x0000000183D894E0-0x0000000183D894F0
		public BgmType BGM { get; set; } // 0x0000000181B5A280-0x0000000181B5A290 0x0000000181B5A290-0x0000000181B5A2A0
		[Title("Side BGM")]
		public BgmType? sideBBGM { get; set; } // 0x00000001826E99F0-0x00000001826E9A00 0x0000000183BF5D20-0x0000000183BF5D30
		[Title("Legacy BGM")]
		public string legacyBGM { get; set; } // 0x00000001819A0360-0x00000001819A0370 0x0000000181917690-0x00000001819176F0
		[Title("Tips")]
		public string tips { get; set; } // 0x00000001819A0370-0x00000001819A0380 0x00000001819A0380-0x00000001819A03E0
		[Title("Hyper Tips")]
		public string hyperTips { get; set; } // 0x00000001819A03E0-0x00000001819A03F0 0x00000001819A03F0-0x00000001819A0450
		[Title("Valid for Character Data")]
		public bool validForCharcaterData { get; set; } // 0x00000001819643B0-0x00000001819643C0 0x00000001826FAF20-0x00000001826FAF30
		[Title("Hidden")]
		public bool hidden { get; set; } // 0x00000001854115C0-0x00000001854115D0 0x000000018675B7E0-0x000000018675B7F0
		[Title("Always Hidden")]
		public bool alwaysHidden { get; set; } // 0x00000001854115D0-0x00000001854115E0 0x000000018675B7F0-0x000000018675B800
		[Title("Mods")]
		public StageModifiers mods { get; set; } // 0x0000000181971630-0x0000000181971640 0x0000000182649B10-0x0000000182649B70
		[Title("Hyper")]
		public StageModifiers hyper { get; set; } // 0x00000001819A0250-0x00000001819A0260 0x0000000181918C00-0x0000000181918C60
		[Title("Inverse")]
		public StageModifiers inverse { get; set; } // 0x00000001819716D0-0x00000001819716E0 0x00000001819716E0-0x0000000181971740
		[Title("Tileset")]
		public Tileset tileset { get; set; } // 0x00000001819A0190-0x00000001819A01A0 0x0000000182743780-0x00000001827437E0
		[Title("Background")]
		public Background background { get; set; } // 0x00000001819A01A0-0x00000001819A01B0 0x0000000182A43650-0x0000000182A436B0
		[Title("Pools Mapping")]
		public List<PoolsMapping> poolsMapping { get; set; } // 0x00000001819A0460-0x00000001819A0470 0x0000000182743940-0x00000001827439A0
		[Title("Spawn Type")]
		public string spawnType { get; set; } // 0x00000001827666D0-0x00000001827666E0 0x0000000184BB7BF0-0x0000000184BB7C50
		[Title("Starting Spawns")]
		public int startingSpawns { get; set; } // 0x0000000181BDC430-0x0000000181BDC440 0x0000000181BDC440-0x0000000181BDC450
		[Required]
		[Title("Minute")]
		public int minute { get; set; } // 0x0000000183726220-0x0000000183726230 0x0000000183726230-0x0000000183726240
		[Title("Random Minutes")]
		public bool randomMinutes { get; set; } // 0x0000000182816BD0-0x0000000182816BE0 0x0000000182816BE0-0x0000000182816BF0
		[Title("Destructible Type")]
		public string destructibleType { get; set; } // 0x000000018282D820-0x000000018282D830 0x0000000184B1D020-0x0000000184B1D080
		[Title("Destructible Frequency")]
		public float destructibleFreq { get; set; } // 0x00000001866FAF70-0x00000001866FAF80 0x00000001867530E0-0x00000001867530F0
		[Title("Destructible Chance")]
		public float destructibleChance { get; set; } // 0x00000001867530F0-0x0000000186753100 0x0000000186753100-0x0000000186753110
		[Title("Destructible Chance Max")]
		public float destructibleChanceMax { get; set; } // 0x000000018281C5E0-0x000000018281C5F0 0x00000001864C43C0-0x00000001864C43D0
		[Title("Max Destructibles")]
		public int maxDestructibles { get; set; } // 0x000000018281C5A0-0x000000018281C5B0 0x000000018675B800-0x000000018675B810
		[Title("BG Texture Name")]
		public string BGTextureName { get; set; } // 0x0000000181945E90-0x0000000181945EA0 0x0000000180B3E800-0x0000000180B3E860
		[Title("Extra Texture")]
		public string Extra_Texture { get; set; } // 0x0000000182766860-0x0000000182766870 0x0000000184B1D430-0x0000000184B1D490
		[Title("Extra Audio")]
		public BgmType Extra_Audio { get; set; } // 0x0000000181945D40-0x0000000181945D50 0x0000000185DD4E90-0x0000000185DD4EA0
		[Title("Is Merchant Banned")]
		public bool isMerchantBanned { get; set; } // 0x0000000181945D70-0x0000000181945D80 0x0000000181945D80-0x0000000181945D90
		[Title("Is Speed Up Banned")]
		public bool isSpeedupBanned { get; set; } // 0x000000018629EDC0-0x000000018629EDD0 0x0000000186753190-0x00000001867531A0
		[Title("Has Lights")]
		public bool hasLights { get; set; } // 0x000000018675B810-0x000000018675B820 0x000000018675B820-0x000000018675B830
		[Title("Disable Global Light")]
		public bool disableGlobalLight { get; set; } // 0x000000018675B830-0x000000018675B840 0x000000018675B840-0x000000018675B850
		[Title("Has Character Spotlight")]
		public bool hasCharacterSpotlight { get; set; } // 0x0000000184BB1F80-0x0000000184BB1F90 0x0000000184BB1F90-0x0000000184BB1FA0
		[Title("Day Night")]
		public bool dayNight { get; set; } // 0x0000000185DD4EE0-0x0000000185DD4EF0 0x000000018675B850-0x000000018675B860
		[Title("Day Color")]
		public uint DayColor { get; set; } // 0x0000000184756E50-0x0000000184756E60 0x0000000184E07780-0x0000000184E07790
		[Title("Night Color")]
		public uint NightColor { get; set; } // 0x0000000186522200-0x0000000186522210 0x0000000185F8DCE0-0x0000000185F8DCF0
		[Title("Inverse Day Color")]
		public uint InverseDayColor { get; set; } // 0x00000001820926C0-0x00000001820926D0 0x00000001820926D0-0x00000001820926E0
		[Title("Inverse Night Color")]
		public uint InverseNightColor { get; set; } // 0x00000001820926E0-0x00000001820926F0 0x00000001820926F0-0x0000000182092700
		public TilemapTiledJSON tilemapTiledJSON { get; set; } // 0x0000000182937BD0-0x0000000182937BE0 0x0000000182A45B30-0x0000000182A45B90
		public TilemapTiledIMG tilemapTiledIMG { get; set; } // 0x0000000182A45B90-0x0000000182A45BA0 0x0000000182A45BA0-0x0000000182A45C00
		public TilemapPos tilemapPos { get; set; } // 0x0000000184F612E0-0x0000000184F612F0 0x0000000185D80170-0x0000000185D801D0
		[Title("Minimum")]
		public int minimum { get; set; } // 0x0000000181B53310-0x0000000181B53320 0x0000000181B53320-0x0000000181B53330
		[Title("Frequency")]
		public float frequency { get; set; } // 0x0000000184F54B90-0x0000000184F54BA0 0x0000000186758AB0-0x0000000186758AC0
		[Title("Zoom")]
		public float? zoom { get; set; } // 0x0000000184F54FC0-0x0000000184F54FD0 0x000000018675B860-0x000000018675B870
		[Required]
		[Title("Enemies")]
		public List<EnemyType?> enemies { get; set; } // 0x0000000184F54BD0-0x0000000184F54BE0 0x00000001864D7EE0-0x00000001864D7F40
		[Title("Bosses")]
		public List<EnemyType?> bosses { get; set; } // 0x0000000184755AB0-0x0000000184755AC0 0x00000001862CA0A0-0x00000001862CA100
		public Treasure treasure { get; set; } // 0x00000001827668E0-0x00000001827668F0 0x00000001827668F0-0x0000000182766950
		[Title("Arcana Holder")]
		public EnemyType? arcanaHolder { get; set; } // 0x00000001829176E0-0x00000001829176F0 0x000000018675B870-0x000000018675B880
		[Title("Arcana Treasure")]
		public Treasure arcanaTreasure { get; set; } // 0x0000000182917880-0x0000000182917890 0x0000000185C36330-0x0000000185C36390
		[Title("Events")]
		public List<Event> events { get; set; } // 0x0000000182917A20-0x0000000182917A30 0x0000000185637EC0-0x0000000185637F20
		[Title("Pizza Events")]
		public List<Event> pizzaEvents { get; set; } // 0x00000001826DB9D0-0x00000001826DB9E0 0x00000001826DB9E0-0x00000001826DBA40
		[Title("CFF")]
		public VampireSurvivors.Data.CharacterType? cff { get; set; } // 0x00000001826DBA40-0x00000001826DBA50 0x000000018675B880-0x000000018675B890
		[Title("Loot Table")]
		public List<VampireSurvivors.Data.ItemType> LootTable { get; set; } // 0x0000000182766A50-0x0000000182766A60 0x0000000185132550-0x00000001851325B0
		[Title("Relics")]
		public List<VampireSurvivors.Data.ItemType> relics { get; set; } // 0x0000000186747020-0x0000000186747030 0x0000000186747030-0x0000000186747090
		[Title("Relics 2")]
		public List<VampireSurvivors.Data.ItemType> relics2 { get; set; } // 0x0000000181971880-0x0000000181971890 0x0000000185E2C0B0-0x0000000185E2C110
		[Title("Yellow Relics")]
		public List<VampireSurvivors.Data.ItemType> yellowRelics { get; set; } // 0x0000000185FA2680-0x0000000185FA2690 0x0000000186747090-0x00000001867470F0
		[Title("Preload")]
		public PreloadData preload { get; set; } // 0x0000000185FA26F0-0x0000000185FA2700 0x00000001867470F0-0x0000000186747150
		[Title("Adventure Merchants")]
		public List<CustomMerchantData> adventureMerchants { get; set; } // 0x0000000182766A60-0x0000000182766A70 0x0000000182766A70-0x0000000182766AD0
		[Title("Default Followers")]
		public List<FollowerData> defaultFollowers { get; set; } // 0x0000000185D99B30-0x0000000185D99B40 0x0000000185578FC0-0x0000000185579020
		[Title("Adventure Price Markup")]
		public float? adventurePriceMarkup { get; set; } // 0x0000000185D98480-0x0000000185D98490 0x000000018675B890-0x000000018675B8A0
		[Title("Is Racing Stage")]
		public bool isRacingStage { get; set; } // 0x0000000186521930-0x0000000186521940 0x000000018675B8A0-0x000000018675B8B0
		[Title("Skip Visual Inversion")]
		public bool skipVisualInversion { get; set; } // 0x000000018675B8B0-0x000000018675B8C0 0x000000018675B8C0-0x000000018675B8D0
		[Title("Allow Visual Inversion")]
		public bool allowVisualInversion { get; set; } // 0x000000018675B8D0-0x000000018675B8E0 0x000000018675B8E0-0x000000018675B8F0
		[Title("Biome")]
		public string biome { get; set; } // 0x0000000182766D00-0x0000000182766D10 0x0000000182766D10-0x0000000182766D70
		[Title("Biomes")]
		public List<string> biomes { get; set; } // 0x0000000185D98490-0x0000000185D984A0 0x00000001867471B0-0x0000000186747210
	
		// Constructors
		public StageData() {} // 0x000000018675BB00-0x000000018675C1D0
	
		// Methods
		public string GetLocalizedName(StageType sType) => default; // 0x000000018675B8F0-0x000000018675B950
		public string GetLocalizedTips(StageType sType) => default; // 0x000000018675B950-0x000000018675B9B0
		public string GetLocalizedHyperTips(StageType sType) => default; // 0x000000018675B9B0-0x000000018675BA10
		public string GetLocalizedDescription(StageType sType) => default; // 0x000000018675BA10-0x000000018675BA70
		private string GetPrefix(StageType sType) => default; // 0x000000018675BA70-0x000000018675BB00
	}
}
