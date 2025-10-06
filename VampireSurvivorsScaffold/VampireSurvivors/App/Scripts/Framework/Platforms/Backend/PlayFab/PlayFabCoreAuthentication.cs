/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using PlayFab;
using PlayFab.ClientModels;
using VampireSurvivors.App.Scripts.Framework.Platforms.Backend.Authentication;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Scripts.Framework.Platforms.Backend.PlayFab
{
	public class PlayFabCoreAuthentication : ICoreAuthentication // TypeDefIndex: 18747
	{
		// Constructors
		public PlayFabCoreAuthentication() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public void Logout() {} // 0x000000018682CF60-0x000000018682D000
		public bool IsLoggedIn() => default; // 0x000000018682D000-0x000000018682D050
		public string GetAccountId() => default; // 0x000000018682D050-0x000000018682D0C0
		public Task<AccountDetails> GetAccountDetails() => default; // 0x000000018682D0C0-0x000000018682D570
		public Task RequestPasswordReset(string emailAddress) => default; // 0x000000018682D570-0x000000018682D9C0
		public Task<bool> AddBasicCredentials(string email, string password) => default; // 0x000000018682D9C0-0x000000018682DFC0
		public Task<ILoginResult> Login(string email, string password) => default; // 0x000000018682DFC0-0x000000018682E460
		public Task<bool> Register(string email, string password) => default; // 0x000000018682E460-0x000000018682E920
		public Task<bool> AddOrUpdateContactEmail(string email) => default; // 0x000000018682E920-0x000000018682EEE0
		public Task<bool> ResendVerificationEmail() => default; // 0x000000018682EEE0-0x000000018682F440
		public Task<bool> RemoveContactEmail() => default; // 0x000000018682F440-0x000000018682F940
		public Task<IPlayerProfile> GetPlayerProfile() => default; // 0x000000018682F940-0x000000018682FEC0
		public Task<bool> LinkCustomID(string id) => default; // 0x000000018682FEC0-0x0000000186830330
		public Task<bool> UnlinkCustomID(string id) => default; // 0x0000000186830330-0x0000000186830770
		public Task<ILoginResult> LoginWithCustomID(string id, bool forceCreate = false /* Metadata: 0x0197AFA8 */) => default; // 0x0000000186830770-0x0000000186830A80
		public static void AssertPlayFabSettings() {} // 0x0000000186830A80-0x0000000186830B80
		private string GenerateUsername() => default; // 0x0000000186830B80-0x0000000186830E00
	}
}
