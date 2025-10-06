/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Poncle.Schema.Attributes.Attributes;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Data.Stage
{
	[Serializable]
	[Title("Tile Set")]
	public class Tileset // TypeDefIndex: 18450
	{
		// Properties
		[Title("Set Key")]
		public string setKey { get; set; } // 0x0000000180B15C10-0x0000000180B15C20 0x0000000181958310-0x0000000181958370
		[Title("Set Path")]
		public string setPath { get; set; } // 0x0000000180B15520-0x0000000180B15530 0x0000000181957C80-0x0000000181957CE0
		[Title("Map Key")]
		public string mapKey { get; set; } // 0x0000000180B15530-0x0000000180B15540 0x0000000180B1C120-0x0000000180B1C180
		[Title("Map Path")]
		public string mapPath { get; set; } // 0x0000000180B15540-0x0000000180B15550 0x0000000180B1D4C0-0x0000000180B1D520
		[Title("Is Tiling")]
		public bool isTiling { get; set; } // 0x0000000180B1C110-0x0000000180B1C120 0x000000018197EA10-0x000000018197EA20
		[Title("Is Horizontal Road")]
		public bool isHorizontalRoad { get; set; } // 0x000000018197EA20-0x000000018197EA30 0x000000018197EA30-0x000000018197EA40
		[Title("Has Walls Check Destructible Logic")]
		public bool hasWallsCheckDestructibleLogic { get; set; } // 0x000000018197EA40-0x000000018197EA50 0x000000018197EA50-0x000000018197EA60
		[Title("Size X")]
		public float? SizeX { get; set; } // 0x0000000185C0DF90-0x0000000185C0DFA0 0x0000000186751C50-0x0000000186751C60
		[Title("Size Y")]
		public float? SizeY { get; set; } // 0x0000000186751C60-0x0000000186751C70 0x0000000186751C70-0x0000000186751C80
		[Title("Min Treasure X")]
		public float? minTreasureX { get; set; } // 0x000000018644F940-0x000000018644F950 0x00000001841C7E30-0x00000001841C7E40
		[Title("Max Treasure X")]
		public float? maxTreasureX { get; set; } // 0x0000000184B11800-0x0000000184B11810 0x00000001862D7470-0x00000001862D7480
		[Title("Min Treasure Y")]
		public float? minTreasureY { get; set; } // 0x000000018644FB20-0x000000018644FB30 0x0000000186751C80-0x0000000186751C90
		[Title("Max Treasure Y")]
		public float? maxTreasureY { get; set; } // 0x00000001847E3880-0x00000001847E3890 0x00000001847E3890-0x00000001847E38A0
		[Minimum(0f)]
		[Title("Tint")]
		public uint? tint { get; set; } // 0x0000000184BE3080-0x0000000184BE3090 0x0000000184BE3090-0x0000000184BE30A0
		[Title("Map Relic")]
		public VampireSurvivors.Data.ItemType? mapRelic { get; set; } // 0x0000000186757060-0x0000000186757070 0x00000001835D2FA0-0x00000001835D2FB0
		[Title("Details Texture")]
		public string detailsTexture { get; set; } // 0x00000001819A0360-0x00000001819A0370 0x0000000181917690-0x00000001819176F0
		public HardBounds hardBounds { get; set; } // 0x00000001819A0370-0x00000001819A0380 0x00000001819A0380-0x00000001819A03E0
	
		// Constructors
		public Tileset() {} // 0x000000018675A670-0x000000018675A6E0
	}
}
