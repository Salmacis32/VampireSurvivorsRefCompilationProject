/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Coherence.Cloud;
using Coherence.Log;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class SteamNetworkProvider : INetworkProvider // TypeDefIndex: 14070
	{
		// Fields
		private Logger _logger; // 0x30
		private SteamSocketManager _steamSocketManager; // 0x38
		private SteamConnectionManager _steamConnectionManager; // 0x40
		private float _currentTimeout; // 0x48
		private bool _hostingSession; // 0x4C
		private const float _expectedPeersTimeout = 10f; // Metadata: 0x01976CE7
	
		// Properties
		public NetworkProviders Provider { get => default; } // 0x0000000180B21570-0x0000000180B21580 
		public NetworkType NetworkType { get => default; } // 0x0000000180B209C0-0x0000000180B209D0 
		public bool UsesRsl { get => default; } // 0x0000000181958370-0x0000000181958380 
		public bool IsReady { get => default; } // 0x0000000186C46130-0x0000000186C462A0 
		public string InitializationError { get; private set; } // 0x0000000180B15C10-0x0000000180B15C20 0x0000000181958310-0x0000000181958370
		public Action OnJoinError { get; set; } // 0x0000000180B15520-0x0000000180B15530 0x0000000181957C80-0x0000000181957CE0
		public Action OnP2PSessionReady { get; set; } // 0x0000000180B15530-0x0000000180B15540 0x0000000180B1C120-0x0000000180B1C180
		public Action<string> OnP2PSessionError { get; set; } // 0x0000000180B15540-0x0000000180B15550 0x0000000180B1D4C0-0x0000000180B1D520
	
		// Constructors
		public SteamNetworkProvider() {} // Dummy constructor
		public SteamNetworkProvider(Logger logger) {} // 0x0000000186C462A0-0x0000000186C46300
	
		// Methods
		public void JoinP2P(LobbySession lobbySession) {} // 0x0000000186C46300-0x0000000186C46920
		private void OnP2PActivationFailed(string errorMessage) {} // 0x00000001826FCE60-0x00000001826FCE80
		public bool JoinGame(LobbySession lobbySession) => default; // 0x0000000186C46920-0x0000000186C46BA0
		public void PrepareGame(LobbySession lobbySession, Action<bool, string, Dictionary<string, string>> onGameReady) {} // 0x0000000186C46BA0-0x0000000186C470E0
		private void OnP2PSessionBecomeReady() {} // 0x00000001826FCE40-0x00000001826FCE60
		public void HostGame() {} // 0x0000000186C470E0-0x0000000186C475B0
		public async Task ShutDown() => default; // 0x0000000186C475B0-0x0000000186C47750
		public void Update() {} // 0x0000000186C47750-0x0000000186C47800
		private bool CheckLoginStatus() => default; // 0x0000000186C47800-0x0000000186C47920
	}
}
