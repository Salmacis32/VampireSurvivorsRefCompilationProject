/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Data
{
	[Serializable]
	public class ArcanaData // TypeDefIndex: 18386
	{
		// Properties
		public int arcanaType { get; set; } // 0x0000000180B15510-0x0000000180B15520 0x0000000180B19030-0x0000000180B19040
		public string name { get; set; } // 0x0000000180B15520-0x0000000180B15530 0x0000000181957C80-0x0000000181957CE0
		public string description { get; set; } // 0x0000000180B15530-0x0000000180B15540 0x0000000180B1C120-0x0000000180B1C180
		public List<object> weapons { get; set; } // 0x0000000180B15540-0x0000000180B15550 0x0000000180B1D4C0-0x0000000180B1D520
		public List<object> items { get; set; } // 0x0000000180B15550-0x0000000180B15560 0x0000000180B1D520-0x0000000180B1D580
		public string texture { get; set; } // 0x0000000180B15560-0x0000000180B15570 0x0000000181953C20-0x0000000181953C80
		public string frameName { get; set; } // 0x0000000180B15750-0x0000000180B15760 0x000000018260F820-0x000000018260F880
		public bool enabled { get; set; } // 0x00000001826F3EE0-0x00000001826F3EF0 0x0000000180B1F000-0x0000000180B1F010
		public bool unlocked { get; set; } // 0x0000000182743350-0x0000000182743360 0x0000000180B1F010-0x0000000180B1F020
		public bool major { get; set; } // 0x0000000184EB8610-0x0000000184EB8620 0x0000000184EB8620-0x0000000184EB8630
		public bool hidden { get; set; } // 0x0000000184EB8630-0x0000000184EB8640 0x0000000184EB8640-0x0000000184EB8650
		public bool alwaysHidden { get; set; } // 0x00000001841C7E40-0x00000001841C7E50 0x00000001841C7E50-0x00000001841C7E60
		public int stars { get; set; } // 0x0000000180B15770-0x0000000180B15780 0x0000000182621130-0x0000000182621140
		public ContentGroupType contentGroup { get; set; } // 0x00000001819A01D0-0x00000001819A01E0 0x0000000181EDFC70-0x0000000181EDFC80
	
		// Constructors
		public ArcanaData() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public string GetLocalizedNameTerm(ArcanaType t) => default; // 0x00000001867464C0-0x0000000186746520
		public string GetLocalizedDescriptionTerm(ArcanaType t) => default; // 0x0000000186746520-0x0000000186746580
		public string GetLocalPrefix(ArcanaType t) => default; // 0x0000000186746580-0x0000000186746660
	}
}
