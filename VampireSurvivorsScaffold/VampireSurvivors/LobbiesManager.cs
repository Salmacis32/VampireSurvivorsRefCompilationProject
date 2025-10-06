/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Coherence.Cloud;
using Coherence.Log;
using UnityEngine;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class LobbiesManager : IInitializable, IDisposable // TypeDefIndex: 14013
	{
		// Fields
		private LobbySession _activeLobby; // 0x10
		private readonly Coherence.Log.Logger _logger; // 0x18
		private static Dictionary<string, string> _regionUrls; // 0x00
		private const string InviteCodeAlphabet = "ABCDEFGHJKLMNPQRSTUVWXYZ23456789"; // Metadata: 0x01976CB3
		private const int InviteCodeLength = 6; // Metadata: 0x01976CD4
	
		// Properties
		public LobbySession ActiveLobby { get => default; } // 0x0000000180B15C10-0x0000000180B15C20 
		public bool IsPartOfLobby { get => default; } // 0x0000000186987A30-0x0000000186987A50 
		public bool IsHost { get => default; } // 0x0000000186987A50-0x0000000186987A80 
	
		// Nested types
		private struct PingResult // TypeDefIndex: 14006
		{
			// Fields
			public bool isDone; // 0x00
			public long time; // 0x08
	
			// Constructors
			public PingResult(bool isDone, long time) {
				this.isDone = default;
				this.time = default;
			} // 0x000000018335A850-0x000000018335A860
		}
	
		// Constructors
		public LobbiesManager() {} // 0x0000000186989220-0x00000001869892E0
		static LobbiesManager() {} // 0x00000001869892E0-0x0000000186989540
	
		// Methods
		public void Initialize() {} // 0x0000000180B15170-0x0000000180B15180
		public void Dispose() {} // 0x0000000180B15170-0x0000000180B15180
		public async Task<LobbyResult> CreateNewLobby() => default; // 0x0000000186987A80-0x0000000186987C30
		public async Task<LobbyResult> JoinLobby(string tag) => default; // 0x0000000186987C30-0x0000000186987E20
		public async Task<bool> LeaveLobby() => default; // 0x0000000186987E20-0x0000000186987FA0
		public bool ArePlayersReadyToStartGame() => default; // 0x0000000186987FA0-0x0000000186988320
		private bool CheckAttributes(LobbyData lobbyData, out string errorMessage) {
			errorMessage = default;
			return default;
		} // 0x0000000186988320-0x0000000186988610
		private bool CheckHostDlcs(LobbyData lobbyData, out string errorMessage) {
			errorMessage = default;
			return default;
		} // 0x0000000186988610-0x0000000186988670
		private string GenerateLobbyCode() => default; // 0x0000000186988670-0x0000000186988BF0
		private async Task<string> GetBestRegion() => default; // 0x0000000186988BF0-0x0000000186988DA0
		private async Task<PingResult> GetRTTForRegion(string region) => default; // 0x0000000186988DA0-0x0000000186988F90
		private bool TryGetFirstIPv4Address(IPAddress[] addressList, out IPAddress firstIPv4Address) {
			firstIPv4Address = default;
			return default;
		} // 0x000000018197AB40-0x000000018197AC00
		private string GetCurrentlyLoadedDLCAsString() => default; // 0x0000000186988F90-0x0000000186989220
	}
}
