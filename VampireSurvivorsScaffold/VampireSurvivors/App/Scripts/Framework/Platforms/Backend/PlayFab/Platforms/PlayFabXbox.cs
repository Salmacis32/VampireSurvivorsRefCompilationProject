/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using PlayFab;
using PlayFab.ClientModels;
using VampireSurvivors.App.Scripts.Framework.Platforms;
using VampireSurvivors.App.Scripts.Framework.Platforms.Backend;
using VampireSurvivors.App.Scripts.Framework.Platforms.Backend.Authentication;
using VampireSurvivors.App.Scripts.Framework.Platforms.Backend.Core;
using VampireSurvivors.Framework.Platforms;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Scripts.Framework.Platforms.Backend.PlayFab.Platforms
{
	public class PlayFabXbox : IPlatform, IPlatformAuthentication // TypeDefIndex: 18784
	{
		// Constructors
		public PlayFabXbox() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public PlatformType GetPlatformName() => default; // 0x0000000180B21570-0x0000000180B21580
		public Task<ILoginResult> Login() => default; // 0x000000018683BA10-0x000000018683BA20
		public Task<ILoginResult> LoginOrRegister() => default; // 0x000000018683BA20-0x000000018683BA30
		private Task<ILoginResult> LoginOrRegisterInternal(bool createAccount) => default; // 0x000000018683BA30-0x000000018683BD30
		public Task<ILinkResult> LinkAccount(bool force = false /* Metadata: 0x0197AFB7 */) => default; // 0x000000018683BD30-0x000000018683BF70
		public Task<bool> UnlinkAccount() => default; // 0x000000018683BF70-0x000000018683C350
	}
}
