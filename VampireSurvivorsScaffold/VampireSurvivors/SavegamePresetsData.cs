/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class SavegamePresetsData : ScriptableObject // TypeDefIndex: 14177
	{
		// Fields
		public List<SavegamePreset> Presets; // 0x18
	
		// Nested types
		[Serializable]
		public class SavegamePreset // TypeDefIndex: 14176
		{
			// Fields
			public string Name; // 0x10
			public string Description; // 0x18
			public string Savegame; // 0x20
	
			// Constructors
			public SavegamePreset() {} // Dummy constructor
			public SavegamePreset(string name, string description, string savegame) {} // 0x0000000186DA58C0-0x0000000186DA5B20
		}
	
		// Constructors
		public SavegamePresetsData() {} // 0x000000018199F650-0x000000018199F660
	}
}
