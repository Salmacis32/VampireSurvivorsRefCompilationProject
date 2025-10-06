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
using PartyCSharpSDK;
using PlayFab.ClientModels;
using PlayFab.Party;
using VampireSurvivors.App.Scripts.Framework.Platforms.Backend.Authentication;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class PlayFabNetworkProvider : INetworkProvider // TypeDefIndex: 14060
	{
		// Fields
		private Logger _logger; // 0x38
		private PARTY_DIRECT_PEER_CONNECTIVITY_OPTIONS _connectivityOptions; // 0x40
		private PlayFabMultiplayerManager _playFabMultiplayerManager; // 0x48
		private int _expectedPeers; // 0x50
		private bool _hostingSession; // 0x54
		private float _currentTimeout; // 0x58
		private PlayFabMultiplayerManager.OnNetworkJoinedHandler _hostJoinedHandler; // 0x60
		private PlayFabMultiplayerManager.OnErrorEventHandler _errorHandler; // 0x68
		private PlayFabMultiplayerManager.OnRemotePlayerJoinedHandler _playerJoinedHandler; // 0x70
		private const float _expectedPeersTimeout = 10f; // Metadata: 0x01976CDF
	
		// Properties
		public NetworkProviders Provider { get => default; } // 0x0000000180B209C0-0x0000000180B209D0 
		public NetworkType NetworkType { get => default; } // 0x0000000180B209C0-0x0000000180B209D0 
		public bool UsesRsl { get => default; } // 0x0000000181958370-0x0000000181958380 
		public bool IsReady { get; private set; } // 0x0000000180B15AC0-0x0000000180B15AD0 0x000000018195A980-0x000000018195A990
		public string InitializationError { get; private set; } // 0x0000000180B15520-0x0000000180B15530 0x0000000181957C80-0x0000000181957CE0
		public Action OnJoinError { get; set; } // 0x0000000180B15530-0x0000000180B15540 0x0000000180B1C120-0x0000000180B1C180
		public Action OnP2PSessionReady { get; set; } // 0x0000000180B15540-0x0000000180B15550 0x0000000180B1D4C0-0x0000000180B1D520
		public Action<string> OnP2PSessionError { get; set; } // 0x0000000180B15550-0x0000000180B15560 0x0000000180B1D520-0x0000000180B1D580
	
		// Constructors
		public PlayFabNetworkProvider() {} // Dummy constructor
		public PlayFabNetworkProvider(Logger logger) {} // 0x0000000186C3C4E0-0x0000000186C3C830
	
		// Methods
		public void JoinP2P(LobbySession lobbySession) {} // 0x0000000186C3C830-0x0000000186C3CC20
		private void OnNetworkJoined(object sender, string networkid) {} // 0x0000000186C3CC20-0x0000000186C3CE40
		private void OnJoinNetworkError(object sender, PlayFabMultiplayerManagerErrorArgs args) {} // 0x0000000186C3CE40-0x0000000186C3D040
		public bool JoinGame(LobbySession lobbySession) => default; // 0x0000000186C3D040-0x0000000186C3D5D0
		public void PrepareGame(LobbySession lobbySession, Action<bool, string, Dictionary<string, string>> onGameReady) {} // 0x0000000186C3D5D0-0x0000000186C3DB00
		public void HostGame() {} // 0x0000000186C3DB00-0x0000000186C3DF20
		public async Task ShutDown() => default; // 0x0000000186C3DF20-0x0000000186C3E0C0
		public void Update() {} // 0x0000000186C3E0C0-0x0000000186C3E1A0
		private void OnP2PSessionReadyInvoke() {} // 0x0000000186C3E1A0-0x0000000186C3E220
		private void OnLoggedIn(PlayFab.ClientModels.LoginResult obj) {} // 0x0000000186C3E220-0x0000000186C3E2F0
		private async void LoginWithPlayFab() {} // 0x0000000186C3E2F0-0x0000000186C3E4B0
	}
}
