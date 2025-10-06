/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Steamworks;
using Steamworks.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class SteamConnectionManager : IConnectionManager // TypeDefIndex: 14068
	{
		// Fields
		private bool _isConnectionReady; // 0x28
		private SteamId _hostSteamId; // 0x30
		private ConnectionManager _steamRelayConnection; // 0x38
	
		// Properties
		public Steamworks.Data.Connection Connection { get => default; } // 0x0000000186C45940-0x0000000186C45960 
	
		// Events
		public event Action<ConnectionInfo> OnHostDisconnected;
		public event Action<IntPtr, int> OnMessageReceived;
		public event Action<string> P2PActivationFailed;
	
		// Constructors
		public SteamConnectionManager() {} // Dummy constructor
		public SteamConnectionManager(SteamId hostSteamId) {} // 0x00000001847D19F0-0x00000001847D1A00
	
		// Methods
		public void Open() {} // 0x0000000186C45960-0x0000000186C45BC0
		public void Close() {} // 0x0000000186C45BC0-0x0000000186C45C20
		public void Receive() {} // 0x0000000186C45C20-0x0000000186C45C50
		public void OnConnecting(ConnectionInfo info) {} // 0x0000000186C45C50-0x0000000186C45D50
		public void OnConnected(ConnectionInfo info) {} // 0x0000000186C45D50-0x0000000186C45E60
		public void OnDisconnected(ConnectionInfo info) {} // 0x0000000186C45E60-0x0000000186C46130
		public void OnMessage(IntPtr data, int size, long messageNum, long recvTime, int channel) {} // 0x000000018645DE70-0x000000018645DE90
	}
}
