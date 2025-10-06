/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Steamworks;
using Steamworks.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class SteamSocketManager : ISocketManager // TypeDefIndex: 14073
	{
		// Fields
		private SocketManager _steamSocketManager; // 0x28
		private int _expectedPeers; // 0x30
		private bool _isGameReady; // 0x34
	
		// Properties
		public HashSet<Steamworks.Data.Connection> Connected { get => default; } // 0x0000000186C49C10-0x0000000186C49C30 
	
		// Events
		public event Action OnSessionReady;
		public event Action<Steamworks.Data.Connection, ConnectionInfo> OnPeerDisconnected;
		public event Action<Steamworks.Data.Connection, IntPtr, int> OnMessageReceived;
	
		// Constructors
		public SteamSocketManager() {} // Dummy constructor
		public SteamSocketManager(int expectedPeers) {} // 0x0000000186C49C30-0x0000000186C49D10
	
		// Methods
		public string Open() => default; // 0x0000000186C49D10-0x0000000186C4A170
		public void Update() {} // 0x0000000186C4A170-0x0000000186C4A250
		public void Close() {} // 0x0000000186C4A250-0x0000000186C4A510
		public void OnConnecting(Steamworks.Data.Connection connection, ConnectionInfo info) {} // 0x0000000186C4A510-0x0000000186C4A650
		public void OnConnected(Steamworks.Data.Connection connection, ConnectionInfo info) {} // 0x0000000186C4A650-0x0000000186C4A7D0
		public void OnDisconnected(Steamworks.Data.Connection connection, ConnectionInfo info) {} // 0x0000000186C4A7D0-0x0000000186C4A880
		public void OnMessage(Steamworks.Data.Connection connection, NetIdentity identity, IntPtr data, int size, long messageNum, long recvTime, int channel) {} // 0x0000000186C4A880-0x0000000186C4A8B0
	}
}
