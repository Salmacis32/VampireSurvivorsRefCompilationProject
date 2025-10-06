/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Platforms.Saves;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Platforms
{
	public class DummyAccount : IBaseAccount // TypeDefIndex: 18183
	{
		// Fields
		private DummyStorage _storage; // 0x50
		private DummyAchievementsManager _dummyAchievementsManager; // 0x58
	
		// Properties
		public override string LocalID { get => default; } // 0x0000000180B15750-0x0000000180B15760 
		public override string OnlineID { get => default; } // 0x0000000180B15750-0x0000000180B15760 
		public override string UniqueAccountID { get => default; } // 0x00000001849BA2B0-0x00000001849BA2D0 
		public override IPlatformSaveUtils Storage { get => default; } // 0x000000018197EAB0-0x000000018197EAC0 
		public override IPlatformAchievementsManager AchievementsManager { get => default; } // 0x0000000180B15730-0x0000000180B15740 
	
		// Constructors
		public DummyAccount() {} // Dummy constructor
		public DummyAccount(int rewiredPlayerId = 0 /* Metadata: 0x01978839 */) {} // 0x00000001866F47D0-0x00000001866F4900
	
		// Methods
		public override void LoginAsync(LoginOptions options, Action<LoginResult> onComplete) {} // 0x00000001866F4900-0x00000001866F49B0
		public override void GetAvailableDlc(Action<List<DlcType>> onComplete) {} // 0x00000001866F49B0-0x00000001866F4BA0
		public override void GetLicensedDlc(Action<List<DlcType>> onComplete) {} // 0x00000001866F4BA0-0x00000001866F4C20
		public override void UpdateInstalledDlc(Action onComplete) {} // 0x0000000184F92570-0x0000000184F92590
		public override void MountDlc(DlcType dlcType, Action<string> onComplete) {} // 0x00000001866F4C20-0x00000001866F4C50
		public override void UnmountDlc(DlcType dlcType, Action onComplete) {} // 0x00000001866F4C50-0x00000001866F4C70
	}
}
