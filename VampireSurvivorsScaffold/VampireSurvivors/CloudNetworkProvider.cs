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
	public class CloudNetworkProvider : INetworkProvider // TypeDefIndex: 13984
	{
		// Fields
		private IRoomsService _roomsService; // 0x38
		private Logger _logger; // 0x40
		private RoomData? _roomData; // 0x48
	
		// Properties
		public NetworkProviders Provider { get => default; } // 0x0000000180B15D70-0x0000000180B15D80 
		public NetworkType NetworkType { get => default; } // 0x0000000180B15D70-0x0000000180B15D80 
		public bool UsesRsl { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		public bool IsReady { get; private set; } // 0x0000000180B15AC0-0x0000000180B15AD0 0x000000018195A980-0x000000018195A990
		public string InitializationError { get; private set; } // 0x0000000180B15520-0x0000000180B15530 0x0000000181957C80-0x0000000181957CE0
		public Action OnJoinError { get; set; } // 0x0000000180B15530-0x0000000180B15540 0x0000000180B1C120-0x0000000180B1C180
		public Action OnP2PSessionReady { get; set; } // 0x0000000180B15540-0x0000000180B15550 0x0000000180B1D4C0-0x0000000180B1D520
		public Action<string> OnP2PSessionError { get; set; } // 0x0000000180B15550-0x0000000180B15560 0x0000000180B1D520-0x0000000180B1D580
	
		// Constructors
		public CloudNetworkProvider() {} // Dummy constructor
		public CloudNetworkProvider(Logger logger) {} // 0x0000000186982DC0-0x0000000186982E20
	
		// Methods
		public void JoinP2P(LobbySession lobbySession) {} // 0x0000000180B15170-0x0000000180B15180
		public bool JoinGame(LobbySession lobbySession) => default; // 0x0000000186982E20-0x00000001869830E0
		public void PrepareGame(LobbySession lobbySession, Action<bool, string, Dictionary<string, string>> onGameReady) {} // 0x00000001869830E0-0x00000001869834E0
		public void HostGame() {} // 0x00000001869834E0-0x0000000186983620
		public void Update() {} // 0x0000000180B15170-0x0000000180B15180
		private void OnCreatedRoom(RequestResponse<RoomData> request, Action<bool, string, Dictionary<string, string>> onGameReady) {} // 0x0000000186983620-0x0000000186983A90
		private static void JoinRoom(RoomData room) {} // 0x0000000186983A90-0x0000000186983C40
		public async Task ShutDown() => default; // 0x0000000186983C40-0x0000000186983D70
	}
}
