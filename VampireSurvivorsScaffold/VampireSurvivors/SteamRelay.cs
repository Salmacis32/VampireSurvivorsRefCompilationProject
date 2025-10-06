/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit.Relay;
using Steamworks.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class SteamRelay : IRelay // TypeDefIndex: 14071
	{
		// Fields
		private readonly Dictionary<Steamworks.Data.Connection, SteamRelayConnection> _connectionMap; // 0x10
		private SteamSocketManager _steamSocketManager; // 0x18
	
		// Properties
		public CoherenceRelayManager RelayManager { get; set; } // 0x0000000180B15530-0x0000000180B15540 0x0000000180B1C120-0x0000000180B1C180
	
		// Constructors
		public SteamRelay() {} // Dummy constructor
		public SteamRelay(SteamSocketManager socketManager) {} // 0x0000000186C47D20-0x0000000186C47EB0
	
		// Methods
		public void Open() {} // 0x0000000186C47EB0-0x0000000186C48170
		public void Update() {} // 0x0000000186C48170-0x0000000186C48250
		public void Close() {} // 0x0000000186C48250-0x0000000186C48580
		private void CreateRelayConnections() {} // 0x0000000186C48580-0x0000000186C48970
		public void OnDisconnected(Steamworks.Data.Connection steamConnection, ConnectionInfo info) {} // 0x0000000186C48970-0x0000000186C48BB0
		public void OnMessage(Steamworks.Data.Connection steamConnection, IntPtr data, int size) {} // 0x0000000186C48BB0-0x0000000186C48E90
	}
}
