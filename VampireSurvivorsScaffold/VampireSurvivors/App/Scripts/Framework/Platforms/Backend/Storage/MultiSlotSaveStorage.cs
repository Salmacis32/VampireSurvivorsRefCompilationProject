/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using VampireSurvivors.App.Scripts.Framework.Platforms.Backend.PlayFab;
using VampireSurvivors.App.Scripts.Framework.Platforms.Backend.Service;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Scripts.Framework.Platforms.Backend.Storage
{
	public class MultiSlotSaveStorage : IMultiSlotSaveStorage // TypeDefIndex: 18728
	{
		// Fields
		private const string SAVE_SLOT_KEY_PREFIX = "SAVE_DATA_SLOT_"; // Metadata: 0x0197AF97
		private ISaveDataCompressor compressor; // 0x10
		private IPlayerDataStorage storage; // 0x18
		private int maxSlots; // 0x20
	
		// Constructors
		public MultiSlotSaveStorage() {} // Dummy constructor
		public MultiSlotSaveStorage(IPlayerDataStorage storage, int maxSlots) {} // 0x000000018682A6A0-0x000000018682A810
	
		// Methods
		public Task<bool> SetSlotData(int slot, PlayerOptionsData value) => default; // 0x000000018682A810-0x000000018682A860
		public async Task<PlayerOptionsData> GetSlotData(int slot) => default; // 0x000000018682A860-0x000000018682A9F0
		public async Task<PlayerOptionsData> GetMergeConflictSlotData() => default; // 0x000000018682A9F0-0x000000018682AB70
		private void AssertArgs(int slot) {} // 0x000000018682AB70-0x000000018682AC20
		private PlayFabPlayerData.AllowedPlayerDataKeys GetKey(int slot) => default; // 0x000000018682AC20-0x000000018682ADC0
		private async Task<PlayerOptionsData> TryGet(PlayFabPlayerData.AllowedPlayerDataKeys key) => default; // 0x000000018682ADC0-0x000000018682AF50
		private async Task<bool> TrySet(PlayFabPlayerData.AllowedPlayerDataKeys key, PlayerOptionsData value) => default; // 0x000000018682AF50-0x000000018682B140
	}
}
