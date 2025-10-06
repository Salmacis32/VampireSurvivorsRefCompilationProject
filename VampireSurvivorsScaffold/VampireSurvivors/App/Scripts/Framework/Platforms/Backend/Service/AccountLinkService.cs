/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using PlayFab;
using PlayFab.Json;
using VampireSurvivors.App.Scripts.Framework.Platforms.Backend.Authentication;
using VampireSurvivors.App.Scripts.Framework.Platforms.Backend.PlayFab;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Scripts.Framework.Platforms.Backend.Service
{
	public class AccountLinkService // TypeDefIndex: 18806
	{
		// Constructors
		public AccountLinkService() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public async Task<ForceLinkResponse> PrepareForForceLink(AccountDetailsType platform) => default; // 0x000000018683F4D0-0x000000018683F670
		public async Task<bool> CanUnlink() => default; // 0x000000018683F670-0x000000018683F790
		public async Task TryToUnlinkSpecificPlatform(AccountDetailsType platform, bool isCurrentPlatform) => default; // 0x000000018683F790-0x000000018683F8F0
		private async Task<string> SetAccountVerificationTokenOnPlatformAccount() => default; // 0x000000018683F8F0-0x000000018683FA20
		public async Task AcceptMergeConflict() => default; // 0x000000018683FA20-0x000000018683FB60
		private async Task<ForceLinkResponse> CheckForceLinkOnServer(string platformAccountPlayFabId, AccountDetailsType platform) => default; // 0x000000018683FB60-0x000000018683FD10
	}
}
