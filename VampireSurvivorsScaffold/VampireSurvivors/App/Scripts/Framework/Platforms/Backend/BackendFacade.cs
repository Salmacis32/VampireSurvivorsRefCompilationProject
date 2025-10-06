/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using PlayFab;
using PlayFab.Json;
using VampireSurvivors.App.Scripts.Framework.Platforms;
using VampireSurvivors.App.Scripts.Framework.Platforms.Backend.Authentication;
using VampireSurvivors.App.Scripts.Framework.Platforms.Backend.Core;
using VampireSurvivors.App.Scripts.Framework.Platforms.Backend.PlayFab;
using VampireSurvivors.App.Scripts.Framework.Platforms.Backend.Storage;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Platforms;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Scripts.Framework.Platforms.Backend
{
	public static class BackendFacade // TypeDefIndex: 18720
	{
		// Fields
		private static IPlatformConfiguration _platformConfiguration; // 0x00
		private static readonly IPlatform _platform; // 0x08
		private static readonly ICoreAuthentication _coreAuthentication; // 0x10
		private static readonly IPlatformAuthentication _platformAuthentication; // 0x18
		private static readonly IPlayerDataStorage _storage; // 0x20
		private static readonly IMultiSlotSaveStorage _multiSlotSaveStorage; // 0x28
	
		// Constructors
		static BackendFacade() {} // 0x000000018681DE60-0x000000018681E390
	
		// Methods
		private static async Task<T> TryOperationAndDoAuth<T>(Func<Task<T>> operation) => default;
		public static string GetPlatformAsString() => default; // 0x000000018681E390-0x000000018681E540
		public static PlatformType GetPlatformType() => default; // 0x000000018681E540-0x000000018681E5C0
		public static string GetEnvironment() => default; // 0x000000018681E5C0-0x000000018681E640
		public static bool SupportsPlatformAuthentication() => default; // 0x000000018681E640-0x000000018681E770
		public static string GetAccountId() => default; // 0x000000018681E770-0x000000018681E7F0
		public static bool IsLoggedIn() => default; // 0x000000018681E7F0-0x000000018681E870
		public static async Task<bool> AddOrUpdateContactEmail(string email) => default; // 0x000000018681E870-0x000000018681EA00
		public static async Task<string> GetAccountEmailAddress() => default; // 0x000000018681EA00-0x000000018681EB20
		public static async Task<IPlayerProfile> GetPlayerProfile() => default; // 0x000000018681EB20-0x000000018681EC40
		public static async Task<string> ResetContactEmailAddress() => default; // 0x000000018681EC40-0x000000018681ED60
		public static async Task<bool> ResendAccountVerificationEmail() => default; // 0x000000018681ED60-0x000000018681EE80
		public static async Task<bool> RemoveContactEmailAddress() => default; // 0x000000018681EE80-0x000000018681EFA0
		public static void Logout() {} // 0x000000018681EFA0-0x000000018681F020
		public static void SetDefaultAuthContext(PlayFabAuthenticationContext ctx) {} // 0x000000018681F020-0x000000018681F090
		public static async Task<JsonObject> ExecuteCloudScript(string fnName, Dictionary<string, string> parameters = null) => default; // 0x000000018681F090-0x000000018681F270
		public static async Task<AccountDetails> GetAccountDetails() => default; // 0x000000018681F270-0x000000018681F390
		public static async Task<ILoginResult> Login() => default; // 0x000000018681F390-0x000000018681F4B0
		public static async Task<ILinkResult> LinkAccount(bool force = false /* Metadata: 0x0197AF93 */) => default; // 0x000000018681F4B0-0x000000018681F5D0
		public static async Task<bool> UnlinkAccount() => default; // 0x000000018681F5D0-0x000000018681F6F0
		public static async Task<bool> UnlinkAccount(IPlatformAuthentication platformAuthentication) => default; // 0x000000018681F6F0-0x000000018681F870
		public static async Task<bool> AddEmailAndPassword(string email, string password) => default; // 0x000000018681F870-0x000000018681FA50
		public static async Task<ILoginResult> LoginWithEmail(string email, string password) => default; // 0x000000018681FA50-0x000000018681FC40
		public static Task SendPasswordReset(string email) => default; // 0x000000018681FC40-0x000000018681FD40
		public static async Task<bool> RegisterWithEmail(string email, string password) => default; // 0x000000018681FD40-0x000000018681FF30
		public static string GetCustomID() => default; // 0x000000018681FF30-0x000000018681FFC0
		public static Task<bool> LinkDeviceId() => default; // 0x000000018681FFC0-0x0000000186820190
		public static Task<bool> UnlinkDeviceId() => default; // 0x0000000186820190-0x0000000186820360
		public static async Task<ILoginResult> LoginWithDeviceId() => default; // 0x0000000186820360-0x0000000186820480
		private static async Task<bool> LinkCustomID(string id) => default; // 0x0000000186820480-0x0000000186820610
		private static async Task<bool> UnlinkCustomId(string id) => default; // 0x0000000186820610-0x00000001868207A0
		public static async Task<ILoginResult> LoginWithCustomID(string id, bool forceCreate = false /* Metadata: 0x0197AF94 */, bool requiresProfileFetch = true /* Metadata: 0x0197AF95 */) => default; // 0x00000001868207A0-0x0000000186820960
		public static async Task<PlayerOptionsData> GetMergeConflictSlotData() => default; // 0x0000000186820960-0x0000000186820A80
		public static async Task<PlayerOptionsData> GetSlotSaveData(int slot) => default; // 0x0000000186820A80-0x0000000186820BA0
		public static async Task<bool> SetSlotSaveData(int slot, PlayerOptionsData value) => default; // 0x0000000186820BA0-0x0000000186820D30
		public static async Task<bool> SetPlayerData(PlayFabPlayerData.AllowedPlayerDataKeys key, string value) => default; // 0x0000000186820D30-0x0000000186820EC0
		public static Task<bool> TryGetPlatformToken() => default; // 0x0000000186820EC0-0x0000000186821210
		private static async Task<string> GetPlayerData(PlayFabPlayerData.AllowedPlayerDataKeys key) => default; // 0x0000000186821210-0x0000000186821330
	}
}
