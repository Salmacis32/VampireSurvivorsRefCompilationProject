/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Coherence.Cloud;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public interface INetworkProvider // TypeDefIndex: 13992
	{
		// Properties
		NetworkProviders Provider { get; }
		NetworkType NetworkType { get; }
		bool UsesRsl { get; }
		bool IsReady { get; }
		string InitializationError { get; }
		Action OnJoinError { get; set; }
		Action OnP2PSessionReady { get; set; }
		Action<string> OnP2PSessionError { get; set; }
	
		// Methods
		void JoinP2P(LobbySession lobbySession);
		bool JoinGame(LobbySession lobbySession);
		void PrepareGame(LobbySession lobbySession, Action<bool, string, Dictionary<string, string>> onGameReady);
		void HostGame();
		Task ShutDown();
		void Update();
	}
}
