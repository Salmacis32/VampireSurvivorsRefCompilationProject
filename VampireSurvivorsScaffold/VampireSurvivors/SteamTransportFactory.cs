/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Log;
using Coherence.Stats;
using Coherence.Transport;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class SteamTransportFactory : ITransportFactory // TypeDefIndex: 14075
	{
		// Fields
		private readonly SteamConnectionManager _steamConnectionManager; // 0x10
	
		// Constructors
		public SteamTransportFactory() {} // Dummy constructor
		public SteamTransportFactory(SteamConnectionManager steamConnectionManager) {} // 0x0000000181958310-0x0000000181958370
	
		// Methods
		public ITransport Create(ushort mtu, IStats stats, Logger logger) => default; // 0x0000000186C4BB00-0x0000000186C4BB90
	}
}
