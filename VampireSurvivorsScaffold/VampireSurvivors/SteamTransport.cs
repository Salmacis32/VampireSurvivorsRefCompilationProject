/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using Coherence.Brook;
using Coherence.Common;
using Coherence.Connection;
using Coherence.Log;
using Coherence.Stats;
using Coherence.Transport;
using Steamworks.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class SteamTransport : ITransport // TypeDefIndex: 14074
	{
		// Fields
		internal const int HeaderSizeBytes = 4; // Metadata: 0x01976CEB
		private readonly IStats _stats; // 0x28
		private readonly Logger _logger; // 0x30
		private readonly SteamConnectionManager _steamConnectionManager; // 0x38
		private readonly Queue<byte[]> _incomingPackets; // 0x40
		private bool _isClosing; // 0x48
	
		// Properties
		public TransportState State { get; private set; } // 0x0000000181E0A560-0x0000000181E0A570 0x0000000181E0A570-0x0000000181E0A580
		public bool IsReliable { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		public bool CanSend { get => default; } // 0x0000000181958370-0x0000000181958380 
		public int HeaderSize { get => default; } // 0x0000000180B21B50-0x0000000180B21B60 
		public string Description { get => default; } // 0x0000000186C4AC90-0x0000000186C4ACD0 
	
		// Events
		public event Action OnOpen;
		public event Action<ConnectionException> OnError;
	
		// Constructors
		public SteamTransport() {} // Dummy constructor
		public SteamTransport(IStats stats, Logger logger, SteamConnectionManager steamConnectionManager) {} // 0x0000000186C4ACD0-0x0000000186C4B250
	
		// Methods
		public void Open(EndpointData _, ConnectionSettings __) {} // 0x0000000186C4B250-0x0000000186C4B270
		public void PrepareDisconnect() {} // 0x000000018508A410-0x000000018508A420
		public void Close() {} // 0x0000000186C4B270-0x0000000186C4B2E0
		public void Send(IOutOctetStream stream) {} // 0x0000000186C4B2E0-0x0000000186C4B5A0
		public void Receive(List<ValueTuple<IInOctetStream, IPEndPoint>> buffer) {} // 0x0000000186C4B5A0-0x0000000186C4B990
		private void OnHostDisconnected(ConnectionInfo info) {} // 0x0000000186C4B990-0x0000000186C4BA20
		private void OnMessage(IntPtr data, int size) {} // 0x0000000186C4BA20-0x0000000186C4BB00
	}
}
