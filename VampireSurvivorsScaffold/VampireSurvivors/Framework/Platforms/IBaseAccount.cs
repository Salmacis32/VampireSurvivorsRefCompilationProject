/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Cloud;
using Rewired;
using UnityEngine;
using VampireSurvivors;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Platforms.Saves;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Platforms
{
	public abstract class IBaseAccount : ILastErrorProvider // TypeDefIndex: 18194
	{
		// Fields
		protected ErroInfo m_LastError; // 0x18
		protected LoginState m_LoginState; // 0x30
		public readonly int m_RewiredPlayerId; // 0x34
		protected Rewired.Player m_Player; // 0x38
		protected string m_Name; // 0x40
		private string m_SystemLanguage; // 0x48
	
		// Properties
		public string UserName { get; } // 0x0000000180B15750-0x0000000180B15760 
		public LoginState State { get; } // 0x0000000181953B80-0x0000000181953B90 
		public Rewired.Player InputPlayer { get; } // 0x0000000180B15560-0x0000000180B15570 
		public ErroInfo LastError { get; } // 0x00000001829ECFE0-0x00000001829ED000 
		public abstract string UniqueAccountID { get; }
		public abstract string LocalID { get; }
		public abstract string OnlineID { get; }
		public abstract IPlatformSaveUtils Storage { get; }
		public abstract IPlatformAchievementsManager AchievementsManager { get; }
		public bool IsLoggedIn { get; } // 0x00000001866F5710-0x00000001866F5720 
		public bool IsOnlineLoggedIn { get; } // 0x00000001866F5720-0x00000001866F5730 
	
		// Events
		public event Action UserPresenceChangedListener;
	
		// Constructors
		protected IBaseAccount() {} // Dummy constructor
		public IBaseAccount(int rewiredPlayerId) {} // 0x00000001866F5640-0x00000001866F5710
	
		// Methods
		public static void NAME() {} // 0x0000000180B15170-0x0000000180B15180
		public virtual void Close() {} // 0x00000001866F5730-0x00000001866F5850
		protected void SetState(LoginState newState) {} // 0x00000001866F5850-0x00000001866F5870
		public abstract void LoginAsync(LoginOptions options, Action<LoginResult> onComplete);
		public virtual void LoginWithCoherence(Action<LoginOperation> coherenceLoginOperation) {} // 0x00000001866F5870-0x00000001866F5B00
		protected void TriggerUserPresenceChanged() {} // 0x0000000182855080-0x00000001828550A0
		public abstract void GetAvailableDlc(Action<List<DlcType>> onComplete);
		public abstract void GetLicensedDlc(Action<List<DlcType>> onComplete);
		public abstract void UpdateInstalledDlc(Action onComplete);
		public abstract void MountDlc(DlcType dlcType, Action<string> onComplete);
		public abstract void UnmountDlc(DlcType dlcType, Action onComplete);
		public virtual AssetBundle GetAssetBundle(string path, string bundleName) => default; // 0x00000001866F5B00-0x00000001866F5B70
		public virtual void DisplayOnscreenKeyboard() {} // 0x0000000180B15170-0x0000000180B15180
		public virtual bool DoesSupportWindowModes() => default; // 0x0000000180B15290-0x0000000180B152A0
		public virtual bool DoesSupportVSync() => default; // 0x0000000180B15290-0x0000000180B152A0
		public virtual bool DoesPlayer1NeedController() => default; // 0x0000000181958370-0x0000000181958380
		public virtual void GetAuthToken(Action<PlatformAuthToken> onSuccess, Action<string> onError, Action<TokenAbortReason> onAbort, string url = "https://playfabapi.com/" /* Metadata: 0x0197884E */) {} // 0x00000001866F5B70-0x00000001866F5BB0
		public virtual string GetDefaultLanguage() => default; // 0x00000001866F5BB0-0x00000001866F5F40
	}
}
