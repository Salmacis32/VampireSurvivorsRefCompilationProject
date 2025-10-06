/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Data
{
	[Serializable]
	public class MusicData // TypeDefIndex: 18401
	{
		// Properties
		public string title { get; set; } // 0x0000000180B15C10-0x0000000180B15C20 0x0000000181958310-0x0000000181958370
		public string author { get; set; } // 0x0000000180B15520-0x0000000180B15530 0x0000000181957C80-0x0000000181957CE0
		public string source { get; set; } // 0x0000000180B15530-0x0000000180B15540 0x0000000180B1C120-0x0000000180B1C180
		public StageType? unlockedByStage { get; set; } // 0x0000000180B15540-0x0000000180B15550 0x0000000185A2C780-0x0000000185A2C790
		public CharacterType? unlockedByCharacter { get; set; } // 0x0000000180B15550-0x0000000180B15560 0x00000001847D19F0-0x00000001847D1A00
		public ItemType? unlockedByItem { get; set; } // 0x0000000180B15560-0x0000000180B15570 0x000000018197EA80-0x000000018197EA90
		public bool isUnlocked { get; set; } // 0x0000000182699160-0x0000000182699170 0x0000000182699170-0x0000000182699180
		public string icon { get; set; } // 0x0000000180B15760-0x0000000180B15770 0x000000018268E650-0x000000018268E6B0
		public HyperMod hyperMod { get; set; } // 0x000000018197EAB0-0x000000018197EAC0 0x000000018261D810-0x000000018261D870
		public ForsakenMod forsakenMod { get; set; } // 0x0000000180B15730-0x0000000180B15740 0x00000001826E9730-0x00000001826E9790
	
		// Constructors
		public MusicData() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public string GetLocalizedTitle(BgmType t) => default; // 0x0000000186752F70-0x0000000186753060
	}
}
