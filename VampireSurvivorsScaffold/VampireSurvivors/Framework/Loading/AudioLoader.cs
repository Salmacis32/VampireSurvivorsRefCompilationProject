/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DarkTonic.MasterAudio;
using UnityEngine;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Loading
{
	public static class AudioLoader // TypeDefIndex: 18251
	{
		// Fields
		public static Dictionary<string, List<string>> LoadedSFX; // 0x00
	
		// Constructors
		static AudioLoader() {} // 0x0000000186720970-0x0000000186720A50
	
		// Methods
		public static void LoadBgmAsync(BgmType bgmType, string cacheGroupName, DlcType? dlcType, Action onComplete) {} // 0x000000018671F1F0-0x000000018671F640
		public static void LoadBgm(BgmType bgmType, string cacheGroupName, DlcType? dlcType, Action onComplete = null) {} // 0x000000018671F640-0x000000018671F920
		public static void LoadSFX(SfxType sfxType, string cacheGroupName, DlcType? dlcType, Action onComplete = null) {} // 0x000000018671F920-0x000000018671FC70
		public static void LoadSFXAsync(SfxType sfxType, string cacheGroupName, DlcType? dlcType, Action onComplete = null) {} // 0x000000018671FC70-0x0000000186720010
		private static void CacheLoadedSFX(string cacheGroupName, string sfxGroupName) {} // 0x0000000186720010-0x00000001867202E0
		public static bool IsSFXLoaded(SfxType sfx) => default; // 0x00000001867202E0-0x0000000186720660
		public static void ReleaseCachedGroup(string cacheGroup) {} // 0x0000000186720660-0x0000000186720750
		public static void ReleaseCachedKey(string keyName) {} // 0x0000000186720750-0x0000000186720970
	}
}
