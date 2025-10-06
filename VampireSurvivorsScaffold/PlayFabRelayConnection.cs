/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit.Relay;
using PlayFab.Party;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

public class PlayFabRelayConnection : IRelayConnection // TypeDefIndex: 13857
{
	// Fields
	private IEnumerable<PlayFabPlayer> player; // 0x10
	private PlayFabMultiplayerManager manager; // 0x18
	private readonly Queue<ArraySegment<byte>> messagesFromPlayFabToServer; // 0x20

	// Constructors
	public PlayFabRelayConnection() {} // Dummy constructor
	public PlayFabRelayConnection(PlayFabPlayer player, PlayFabMultiplayerManager manager) {} // 0x00000001865AD7E0-0x00000001865AD9C0

	// Methods
	public void OnConnectionOpened() {} // 0x0000000180B15170-0x0000000180B15180
	public void OnConnectionClosed() {} // 0x00000001865AD9C0-0x00000001865ADA10
	public void ReceiveMessagesFromClient(List<ArraySegment<byte>> packetBuffer) {} // 0x00000001865ADA10-0x00000001865ADC70
	public void SendMessageToClient(ReadOnlySpan<byte> packetData) {} // 0x00000001865ADC70-0x00000001865ADCF0
	public void EnqueueMessageFromPlayFab(ArraySegment<byte> packet) {} // 0x00000001865ADCF0-0x00000001865ADD50
}

