/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework
{
	public static class OnlinePlatformSupport // TypeDefIndex: 18119
	{
		// Fields
		public static OnlinePlatformSupportBase OnlinePlatformSupportInstance; // 0x00
		public static bool HavePendingInvite; // 0x08
		public static string PendingInviteLobbyID; // 0x10
		public const string CommunicatingPopupID = "OnlinePlatformSupportCommunicating"; // Metadata: 0x0197871B
	
		// Properties
		public static bool WaitForServerResponseOnEnteringOnline { get; } // 0x00000001866CB800-0x00000001866CB860 
	
		// Methods
		public static void Setup() {} // 0x00000001866CB860-0x00000001866CBA00
		public static void AutoJoinLobby(string lobbyID) {} // 0x00000001866CBA00-0x00000001866CBB30
		public static void OnLobbyOpen(string lobbyID) {} // 0x00000001866CBB30-0x00000001866CBBB0
		public static void OnLobbyClosed(string lobbyID) {} // 0x00000001866CBBB0-0x00000001866CBC30
		public static void CheckAgeOk(Action<bool> callback) {} // 0x00000001866CBC30-0x00000001866CBCB0
		public static void CheckOnlineEntitlement(Action<bool> callback) {} // 0x00000001866CBCB0-0x00000001866CBD30
		public static void OnCreatedOnlineSession(string lobbyId, Action<bool> callback) {} // 0x00000001866CBD30-0x00000001866CBDC0
		public static void OnJoinedOnlineSession(string lobbyID, Action<bool> callback) {} // 0x00000001866CBDC0-0x00000001866CBE50
		public static void OnRemotePlayerJoinedRoom(string lobbyID, Action<bool> callback) {} // 0x00000001866CBE50-0x00000001866CBEE0
		public static void OnPlayerLeftOnlineSession(string lobbyID, Action<bool> callback) {} // 0x00000001866CBEE0-0x00000001866CBF70
		public static void OnEndOnlineSession(string lobbyID, Action<bool> callback) {} // 0x00000001866CBF70-0x00000001866CC000
		public static void OnConnectionError() {} // 0x00000001866CC000-0x00000001866CC060
		public static void CheckHasInternetConnection(Action<bool> callback) {} // 0x00000001866CC060-0x00000001866CC0E0
		public static void OnUpdate() {} // 0x00000001866CC0E0-0x00000001866CC240
		public static void ShowUsersProfile(string userId) {} // 0x00000001866CC240-0x00000001866CC2C0
		private static void TryJoinLobby() {} // 0x00000001866CC2C0-0x00000001866CC830
	}
}
