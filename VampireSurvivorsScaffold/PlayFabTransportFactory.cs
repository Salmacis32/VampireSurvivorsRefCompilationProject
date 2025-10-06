/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Log;
using Coherence.Stats;
using Coherence.Transport;
using PlayFab.Party;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

public class PlayFabTransportFactory : ITransportFactory // TypeDefIndex: 13859
{
	// Fields
	private PlayFabMultiplayerManager manager; // 0x10
	private string host; // 0x18

	// Constructors
	public PlayFabTransportFactory() {} // Dummy constructor
	public PlayFabTransportFactory(string host, PlayFabMultiplayerManager manager) {} // 0x00000001835B6320-0x00000001835B63D0

	// Methods
	public ITransport Create(ushort mtu, IStats stats, Logger logger) => default; // 0x00000001865AF730-0x00000001865AF7D0
}

