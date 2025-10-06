/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using PlayFab;
using PlayFab.ClientModels;
using VampireSurvivors.App.Scripts.Framework.Platforms.Backend.Storage;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Scripts.Framework.Platforms.Backend.PlayFab
{
	public class PlayFabPlayerData : IPlayerDataStorage // TypeDefIndex: 18755
	{
		// Nested types
		public enum AllowedPlayerDataKeys // TypeDefIndex: 18752
		{
			PASSED_DOB_GATE = 0,
			MERGE_CONFLICT_DATA = 1,
			SAVE_DATA_SLOT_1 = 2,
			LINK_ACCOUNT_VERIFICATION_TOKEN = 3,
			LINKED_CUSTOM_IDS = 4
		}
	
		// Constructors
		public PlayFabPlayerData() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public Task<bool> SetPlayerData(AllowedPlayerDataKeys key, string value) => default; // 0x00000001868326F0-0x0000000186832CF0
		public Task<string> GetPlayerData(AllowedPlayerDataKeys key) => default; // 0x0000000186832CF0-0x00000001868332E0
	}
}
