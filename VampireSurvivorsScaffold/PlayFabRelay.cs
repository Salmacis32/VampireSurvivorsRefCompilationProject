/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Log;
using Coherence.Toolkit.Relay;
using PartyCSharpSDK;
using PlayFab.Party;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

public class PlayFabRelay : IRelay // TypeDefIndex: 13856
{
	// Fields
	private PlayFabMultiplayerManager _playFabMultiplayerManager; // 0x10
	private Dictionary<PlayFabPlayer, PlayFabRelayConnection> _connectionMap; // 0x18
	private PARTY_DIRECT_PEER_CONNECTIVITY_OPTIONS _connectivityOptions; // 0x20
	private Logger _logger; // 0x28

	// Properties
	public CoherenceRelayManager RelayManager { get; set; } // 0x0000000180B15550-0x0000000180B15560 0x0000000180B1D520-0x0000000180B1D580

	// Constructors
	public PlayFabRelay() {} // Dummy constructor
	public PlayFabRelay(PARTY_DIRECT_PEER_CONNECTIVITY_OPTIONS connectivityOptions) {} // 0x00000001865AC7B0-0x00000001865AC910

	// Methods
	public void Open() {} // 0x00000001865AC910-0x00000001865ACDC0
	private void OnDataMessageNoCopyReceived(object sender, PlayFabPlayer from, IntPtr buffer, uint buffersize) {} // 0x00000001865ACDC0-0x00000001865AD130
	private void OnRemotePlayerLeft(object sender, PlayFabPlayer player) {} // 0x00000001865AD130-0x00000001865AD3D0
	public void Close() {} // 0x00000001865AD3D0-0x00000001865AD6A0
	public void Update() {} // 0x0000000180B15170-0x0000000180B15180
	private void OnNetworkError(object sender, PlayFabMultiplayerManagerErrorArgs args) {} // 0x00000001865AD6A0-0x00000001865AD7E0
}

