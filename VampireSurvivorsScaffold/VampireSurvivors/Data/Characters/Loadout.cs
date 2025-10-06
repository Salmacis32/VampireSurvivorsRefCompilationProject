/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Poncle.Schema.Attributes.Attributes;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Data.Characters
{
	[Serializable]
	[Title("Loadout")]
	public class Loadout // TypeDefIndex: 18476
	{
		// Properties
		[Title("Starting Loadout")]
		public List<WeaponType> startingLoadout { get; set; } // 0x0000000180B15C10-0x0000000180B15C20 0x0000000181958310-0x0000000181958370
		[Title("Loadout")]
		public List<WeaponType> loadout { get; set; } // 0x0000000180B15520-0x0000000180B15530 0x0000000181957C80-0x0000000181957CE0
		[Title("Auto Shuffle")]
		public bool autoShuffle { get; set; } // 0x0000000181E0A560-0x0000000181E0A570 0x0000000181E0A570-0x0000000181E0A580
	
		// Constructors
		public Loadout() {} // 0x0000000180B15170-0x0000000180B15180
	}
}
