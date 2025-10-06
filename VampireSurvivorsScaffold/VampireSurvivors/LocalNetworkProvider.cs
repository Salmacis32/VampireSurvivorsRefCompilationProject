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
	public class LocalNetworkProvider : INetworkProvider // TypeDefIndex: 14017
	{
		// Fields
		private Logger _logger; // 0x28
		private RoomData? _roomData; // 0x30
		private ReplicationServerRoomsService _roomsService; // 0xA8
	
		// Properties
		public NetworkProviders Provider { get => default; } // 0x00000001819170A0-0x00000001819170B0 
		public NetworkType NetworkType { get => default; } // 0x0000000180B209C0-0x0000000180B209D0 
		public bool UsesRsl { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		public bool IsReady { get => default; } // 0x0000000181958370-0x0000000181958380 
		public string InitializationError { get => default; } // 0x0000000180B15D70-0x0000000180B15D80 
		public Action OnJoinError { get; set; } // 0x0000000180B15C10-0x0000000180B15C20 0x0000000181958310-0x0000000181958370
		public Action OnP2PSessionReady { get; set; } // 0x0000000180B15520-0x0000000180B15530 0x0000000181957C80-0x0000000181957CE0
		public Action<string> OnP2PSessionError { get; set; } // 0x0000000180B15530-0x0000000180B15540 0x0000000180B1C120-0x0000000180B1C180
	
		// Constructors
		public LocalNetworkProvider() {} // Dummy constructor
		public LocalNetworkProvider(Logger logger) {} // 0x0000000186ADC660-0x0000000186ADC790
	
		// Methods
		public void JoinP2P(LobbySession lobbySession) {} // 0x0000000186ADC790-0x0000000186ADC7D0
		public bool JoinGame(LobbySession lobbySession) => default; // 0x0000000186ADC7D0-0x0000000186ADCA00
		public void PrepareGame(LobbySession lobbySession, Action<bool, string, Dictionary<string, string>> onGameReady) {} // 0x0000000186ADCA00-0x0000000186ADCBE0
		public void HostGame() {} // 0x0000000186ADCBE0-0x0000000186ADCD20
		public void Update() {} // 0x0000000180B15170-0x0000000180B15180
		private static void JoinRoom(RoomData room) {} // 0x0000000186ADCD20-0x0000000186ADCED0
		private void OnCreatedRoom(RequestResponse<RoomData> request, Action<bool, string, Dictionary<string, string>> onGameReady) {} // 0x0000000186ADCED0-0x0000000186ADD330
		public async Task ShutDown() => default; // 0x0000000186ADD330-0x0000000186ADD460
	}
}
