/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PlayFab.ClientModels;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Scripts.Framework.Platforms.Backend.Authentication
{
	public class AccountDetails // TypeDefIndex: 18818
	{
		// Fields
		public readonly Dictionary<AccountDetailsType, string> PlatformAccounts; // 0x10
	
		// Constructors
		private AccountDetails() {} // 0x00000001868441C0-0x0000000186844280
	
		// Methods
		public bool IsDifferentAccountLinked(AccountDetailsType platform) => default; // 0x0000000186844280-0x00000001868444E0
		public string GetPlatformAccountIdentifier(AccountDetailsType platform) => default; // 0x00000001868444E0-0x0000000186844640
		public static AccountDetails FromApiResult(GetAccountInfoResult result) => default; // 0x0000000186844640-0x00000001868449C0
		public string GetCurrentPlatformDetails() => default; // 0x00000001868449C0-0x0000000186844A10
		public bool HasAddedEmailCredentials() => default; // 0x0000000186844A10-0x0000000186844A20
		public bool IsCurrentPlatformLinked() => default; // 0x0000000186844A20-0x0000000186844A30
		public bool IsPlatformLinked(AccountDetailsType type) => default; // 0x0000000186844A30-0x0000000186844AA0
		public AccountDetailsType GetCurrentPlatformType() => default; // 0x0000000181F01BA0-0x0000000181F01BB0
	}
}
