/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Data
{
	[Serializable]
	public class PS4BaseGameData // TypeDefIndex: 18393
	{
		// Fields
		[Tooltip("This should only ever be updated if we are submitting a new master version. This is for failed initial submissions, or remasters / disc releases.")]
		public string _MasterVersion; // 0x10
		[Tooltip("This should be updated for each new patch we generate.")]
		public string _ApplicationVersion; // 0x18
		public List<string> _TrophyPacks; // 0x20
		public List<PS4TrophyIdMappingData> _TrophyIdMappingFiles; // 0x28
	
		// Constructors
		public PS4BaseGameData() {} // 0x0000000186746D50-0x0000000186746F80
	}
}
