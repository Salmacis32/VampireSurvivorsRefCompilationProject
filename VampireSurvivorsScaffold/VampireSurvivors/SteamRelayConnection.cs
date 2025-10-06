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
	public class SteamRelayConnection : IRelayConnection // TypeDefIndex: 14072
	{
		// Fields
		private Steamworks.Data.Connection steamConnection; // 0x10
		private readonly Queue<ArraySegment<byte>> messagesFromSteamToServer; // 0x18
	
		// Constructors
		public SteamRelayConnection() {} // Dummy constructor
		public SteamRelayConnection(Steamworks.Data.Connection steamConnection) {} // 0x0000000186C48E90-0x0000000186C48FC0
	
		// Methods
		public void OnConnectionOpened() {} // 0x0000000180B15170-0x0000000180B15180
		public void OnConnectionClosed() {} // 0x0000000186C48FC0-0x0000000186C490E0
		public void EnqueueMessageFromSteam(ArraySegment<byte> packetData) {} // 0x0000000186C490E0-0x0000000186C49140
		public void ReceiveMessagesFromClient(List<ArraySegment<byte>> packetBuffer) {} // 0x0000000186C49140-0x0000000186C493A0
		public void SendMessageToClient(ReadOnlySpan<byte> packetData) {} // 0x0000000186C493A0-0x0000000186C49630
	}
}
