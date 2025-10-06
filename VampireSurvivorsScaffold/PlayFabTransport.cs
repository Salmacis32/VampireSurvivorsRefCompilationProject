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
using PlayFab.Party;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

public class PlayFabTransport : ITransport // TypeDefIndex: 13858
{
	// Fields
	private PlayFabMultiplayerManager _playFabMultiplayerManager; // 0x28
	private List<PlayFabPlayer> host; // 0x30
	private string hostId; // 0x38
	private Logger _logger; // 0x40
	private IStats _stats; // 0x48
	private bool isClosing; // 0x50
	private readonly Queue<byte[]> incomingPackets; // 0x58

	// Properties
	public TransportState State { get; private set; } // 0x0000000181E0A560-0x0000000181E0A570 0x0000000181E0A570-0x0000000181E0A580
	public bool IsReliable { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
	public bool CanSend { get => default; } // 0x0000000181958370-0x0000000181958380 
	public int HeaderSize { get; } // 0x0000000181E0A5A0-0x0000000181E0A5B0 
	public string Description { get => default; } // 0x00000001865AE130-0x00000001865AE170 

	// Events
	public event Action OnOpen;
	public event Action<ConnectionException> OnError;

	// Constructors
	public PlayFabTransport() {} // Dummy constructor
	public PlayFabTransport(Logger logger, IStats stats, string host, PlayFabMultiplayerManager manager) {} // 0x00000001865AE170-0x00000001865AE390

	// Methods
	public void Open(EndpointData _, ConnectionSettings __) {} // 0x00000001865AE390-0x00000001865AEAB0
	private void OnRemotePlayerLeft(object sender, PlayFabPlayer player) {} // 0x00000001865AEAB0-0x00000001865AEC00
	private void OpenNetwork() {} // 0x00000001865AEC00-0x00000001865AEE50
	private void OnPlayFabError(object sender, PlayFabMultiplayerManagerErrorArgs args) {} // 0x00000001865AEE50-0x00000001865AF000
	private void OnDataMessageNoCopyReceived(object sender, PlayFabPlayer from, IntPtr buffer, uint buffersize) {} // 0x00000001865AF000-0x00000001865AF0D0
	public void Close() {} // 0x00000001865AF0D0-0x00000001865AF2A0
	public void Send(IOutOctetStream data) {} // 0x00000001865AF2A0-0x00000001865AF450
	public void Receive(List<ValueTuple<IInOctetStream, IPEndPoint>> buffer) {} // 0x00000001865AF450-0x00000001865AF730
	public void PrepareDisconnect() {} // 0x00000001858CC910-0x00000001858CC920
}

