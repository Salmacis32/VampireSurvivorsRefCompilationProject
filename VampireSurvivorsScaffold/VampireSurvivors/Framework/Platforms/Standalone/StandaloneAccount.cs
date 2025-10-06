/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Platforms;
using VampireSurvivors.Framework.Platforms.Saves;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Platforms.Standalone
{
	public class StandaloneAccount : IBaseAccount // TypeDefIndex: 18207
	{
		// Fields
		private StandaloneStorage m_Storage; // 0x50
		private DummyAchievementsManager m_DummyAchievementsManager; // 0x58
	
		// Properties
		public override string LocalID { get => default; } // 0x0000000180B15750-0x0000000180B15760 
		public override string OnlineID { get => default; } // 0x0000000180B15750-0x0000000180B15760 
		public override string UniqueAccountID { get => default; } // 0x00000001849BA2B0-0x00000001849BA2D0 
		public override IPlatformSaveUtils Storage { get => default; } // 0x000000018197EAB0-0x000000018197EAC0 
		public override IPlatformAchievementsManager AchievementsManager { get => default; } // 0x0000000180B15730-0x0000000180B15740 
	
		// Constructors
		public StandaloneAccount() {} // Dummy constructor
		public StandaloneAccount(int rewiredPlayerId = 0 /* Metadata: 0x01978887 */) {} // 0x00000001866FCCA0-0x00000001866FCF00
	
		// Methods
		public override void LoginAsync(LoginOptions options, Action<LoginResult> onComplete) {} // 0x00000001866FCF00-0x00000001866FCF90
		public override void GetAvailableDlc(Action<List<DlcType>> onComplete) {} // 0x00000001866FCF90-0x00000001866FD180
		public override void GetLicensedDlc(Action<List<DlcType>> onComplete) {} // 0x00000001866FD180-0x00000001866FD3E0
		public override void UpdateInstalledDlc(Action onComplete) {} // 0x0000000184F92570-0x0000000184F92590
		public override void MountDlc(DlcType dlcType, Action<string> onComplete) {} // 0x00000001866FD3E0-0x00000001866FD810
		public override void UnmountDlc(DlcType dlcType, Action onComplete) {} // 0x00000001866F4C50-0x00000001866F4C70
		public override bool DoesSupportWindowModes() => default; // 0x0000000181958370-0x0000000181958380
		public override bool DoesSupportVSync() => default; // 0x0000000181958370-0x0000000181958380
		public override bool DoesPlayer1NeedController() => default; // 0x0000000180B15290-0x0000000180B152A0
		private void OnUpdate() {} // 0x0000000180B15170-0x0000000180B15180
		private void OnDestroy() {} // 0x00000001866FD810-0x00000001866FD8D0
	}
}
