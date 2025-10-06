/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Loading
{
	public static class CharacterLoader // TypeDefIndex: 18258
	{
		// Fields
		private const string CharacterCacheGroup = "CharacterTextures"; // Metadata: 0x019788F2
	
		// Methods
		public static Dictionary<VampireSurvivors.Data.CharacterType, List<string>> GetTexturesAndTypesForSelectedPlayers(PlayerOptions playerOptions, DataManager dataManager) => default; // 0x0000000186720CE0-0x0000000186721600
		public static List<string> GetTexturesForCharacterTypes(List<VampireSurvivors.Data.CharacterType> characters, PlayerOptions playerOptions, DataManager dataManager) => default; // 0x0000000186721600-0x00000001867218A0
		public static List<string> GetTexturesForCharacterType(VampireSurvivors.Data.CharacterType characterType, PlayerOptions playerOptions, DataManager dataManager) => default; // 0x00000001867218A0-0x0000000186721BC0
		public static void ClearCharacterTextures(List<string> excludedTextures = null) {} // 0x0000000186721BC0-0x0000000186721EE0
		public static void LoadCharacterAsync(VampireSurvivors.Data.CharacterType characterType, Action onComplete) {} // 0x0000000186721EE0-0x0000000186722240
		public static void LoadAllCharacterTextures(DataManager dataManager) {} // 0x0000000186722240-0x00000001867226B0
		public static void LoadAllCharacterTexturesAsync(DataManager dataManager, Action onComplete) {} // 0x00000001867226B0-0x0000000186723130
		public static void LoadCharacterTexture(string textureName, VampireSurvivors.Data.CharacterType characterType, DataManager dataManager, string customCacheGroup = null) {} // 0x0000000186723130-0x0000000186723350
		public static void LoadCharacterTextureAsync(string textureName, VampireSurvivors.Data.CharacterType characterType, Action<bool> onComplete, DataManager dataManager, string customCacheGroup = null) {} // 0x0000000186723350-0x0000000186723520
	}
}
