/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Scripts.Framework.Platforms.Backend.Authentication
{
	public interface ICoreAuthentication // TypeDefIndex: 18819
	{
		// Methods
		bool IsLoggedIn();
		void Logout();
		Task<ILoginResult> Login(string email, string password);
		Task<bool> Register(string email, string password);
		Task<bool> LinkCustomID(string id);
		Task<bool> UnlinkCustomID(string id);
		Task<ILoginResult> LoginWithCustomID(string id, bool forceCreate);
		Task<bool> AddBasicCredentials(string email, string password);
		Task<AccountDetails> GetAccountDetails();
		Task RequestPasswordReset(string emailAddress);
		string GetAccountId();
		Task<bool> AddOrUpdateContactEmail(string email);
		Task<bool> ResendVerificationEmail();
		Task<bool> RemoveContactEmail();
		Task<IPlayerProfile> GetPlayerProfile();
	}
}
