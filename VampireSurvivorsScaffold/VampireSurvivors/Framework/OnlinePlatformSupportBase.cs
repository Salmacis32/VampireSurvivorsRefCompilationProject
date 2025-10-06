/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework
{
	public class OnlinePlatformSupportBase // TypeDefIndex: 18120
	{
		// Properties
		public virtual bool WaitForServerResponseOnEnteringOnline { get => default; } // 0x0000000181958370-0x0000000181958380 
	
		// Constructors
		public OnlinePlatformSupportBase() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public virtual void Initialise() {} // 0x00000001866CC830-0x00000001866CC890
		public virtual void OnLobbyOpen(string lobbyID) {} // 0x00000001866CC890-0x00000001866CC910
		public virtual void OnLobbyClosed(string lobbyID) {} // 0x00000001866CC910-0x00000001866CC990
		public virtual void CheckInternetConnectionState(Action<bool> callback) {} // 0x00000001866CC990-0x00000001866CCA10
		public virtual void OnConnectionError() {} // 0x00000001866CCA10-0x00000001866CCA70
		public virtual void CheckAgeOk(Action<bool> callback) {} // 0x00000001866CCA70-0x00000001866CCAF0
		public virtual void CheckOnlineEntitlement(Action<bool> callback) {} // 0x00000001866CCAF0-0x00000001866CCB70
		public virtual void OnCreatedOnlineSession(string lobbyID, Action<bool> callback) {} // 0x00000001866CCB70-0x00000001866CCBF0
		public virtual void OnJoinedOnlineSession(string lobbyID, Action<bool> callback) {} // 0x00000001866CCBF0-0x00000001866CCC70
		public virtual void OnRemotePlayerJoinedRoom(string lobbyID, Action<bool> callback) {} // 0x00000001866CCC70-0x00000001866CCCF0
		public virtual void OnPlayerLeftOnlineSession(string lobbyID, Action<bool> callback) {} // 0x00000001866CCCF0-0x00000001866CCD70
		public virtual void OnEndOnlineSession(string lobbyID, Action<bool> callback) {} // 0x00000001866CCD70-0x00000001866CCDF0
		public virtual void ShowUsersProfile(string userId) {} // 0x00000001866CCDF0-0x00000001866CCE50
		public virtual void OnUpdate() {} // 0x0000000180B15170-0x0000000180B15180
	}
}
