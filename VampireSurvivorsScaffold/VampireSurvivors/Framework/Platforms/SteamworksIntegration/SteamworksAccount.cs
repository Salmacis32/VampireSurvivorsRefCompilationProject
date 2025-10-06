/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Cloud;
using Steamworks;
using VampireSurvivors;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Platforms;
using VampireSurvivors.Framework.Platforms.Saves;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Platforms.SteamworksIntegration
{
	public class SteamworksAccount : IBaseAccount // TypeDefIndex: 18202
	{
		// Fields
		private IPlatformSaveUtils m_Storage; // 0x50
		private IPlatformAchievementsManager m_AchievementsManager; // 0x58
		private AuthTicket _sessionTicket; // 0x60
		private PlatformAuthToken _authToken; // 0x68
		private string _steamID; // 0x70
		private bool m_IsInitialised; // 0x78
	
		// Properties
		public override string LocalID { get => default; } // 0x0000000180B15750-0x0000000180B15760 
		public override string OnlineID { get => default; } // 0x0000000180B15750-0x0000000180B15760 
		public override string UniqueAccountID { get => default; } // 0x00000001826E99F0-0x00000001826E9A00 
		public override IPlatformSaveUtils Storage { get => default; } // 0x000000018197EAB0-0x000000018197EAC0 
		public override IPlatformAchievementsManager AchievementsManager { get => default; } // 0x0000000180B15730-0x0000000180B15740 
	
		// Constructors
		public SteamworksAccount() {} // Dummy constructor
		public SteamworksAccount(int rewiredPlayerId = 0 /* Metadata: 0x01978866 */) {} // 0x00000001866F7950-0x00000001866F7C60
	
		// Methods
		public static uint GetAppID() => default; // 0x00000001866F7940-0x00000001866F7950
		public bool IsSteamInitialised() => default; // 0x00000001826E9A60-0x00000001826E9A70
		private void OnDestroy() {} // 0x00000001866F7C60-0x00000001866F7E40
		private void OnUpdate() {} // 0x00000001866F7E40-0x00000001866F7F70
		public void CleanAuthToken() {} // 0x00000001866F7F70-0x00000001866F7F90
		public override void GetAuthToken(Action<PlatformAuthToken> onSuccess, Action<string> onError, Action<TokenAbortReason> onAbort, string url = "https://playfabapi.com/" /* Metadata: 0x01978867 */) {} // 0x00000001866F7F90-0x00000001866F84E0
		public override void LoginAsync(LoginOptions options, Action<VampireSurvivors.Framework.Platforms.LoginResult> onComplete) {} // 0x00000001866F84E0-0x00000001866F89F0
		public override void LoginWithCoherence(Action<LoginOperation> onComplete) {} // 0x00000001866F89F0-0x00000001866F8BE0
		private void OnAuthTokenSuccess(PlatformAuthToken token, Action<LoginOperation> onComplete) {} // 0x00000001866F8BE0-0x00000001866F8D50
		private void InitBasicSteamCallbacks() {} // 0x00000001866F8D50-0x00000001866F9130
		private void OnSteamOverlayActivated(bool wasOverlayActivated) {} // 0x00000001866F9130-0x00000001866F9310
		public override void GetAvailableDlc(Action<List<DlcType>> onComplete) {} // 0x00000001866F9310-0x00000001866F9660
		public override void GetLicensedDlc(Action<List<DlcType>> onComplete) {} // 0x00000001866F9660-0x00000001866F9A80
		public override void UpdateInstalledDlc(Action onComplete) {} // 0x0000000184F92570-0x0000000184F92590
		public override void MountDlc(DlcType dlcType, Action<string> onComplete) {} // 0x00000001866F9A80-0x00000001866FA5A0
		public override void UnmountDlc(DlcType dlcType, Action onComplete) {} // 0x00000001866F4C50-0x00000001866F4C70
		private bool IsSteamRunningAndOnSteamDeck() => default; // 0x00000001866FA5A0-0x00000001866FA600
		public override void DisplayOnscreenKeyboard() {} // 0x00000001866FA600-0x00000001866FA760
		public override bool DoesSupportWindowModes() => default; // 0x00000001866FA760-0x00000001866FA7C0
		public override bool DoesSupportVSync() => default; // 0x0000000181958370-0x0000000181958380
		public override bool DoesPlayer1NeedController() => default; // 0x00000001866FA5A0-0x00000001866FA600
		public override string GetDefaultLanguage() => default; // 0x00000001866FA7C0-0x00000001866FAF70
	}
}
