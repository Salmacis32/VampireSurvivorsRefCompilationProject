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
	public class PlayFabNintendo : IPlatform, IPlatformAuthentication // TypeDefIndex: 18769
	{
		// Constructors
		public PlayFabNintendo() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public PlatformType GetPlatformName() => default; // 0x0000000181BA4B30-0x0000000181BA4B40
		public Task<ILoginResult> Login() => default; // 0x0000000186837130-0x0000000186837140
		public Task<ILoginResult> LoginOrRegister() => default; // 0x0000000186837140-0x0000000186837150
		private Task<ILoginResult> LoginOrRegisterInternal(bool createAccount = false /* Metadata: 0x0197AFB2 */) => default; // 0x0000000186837150-0x0000000186837390
		public Task<ILinkResult> LinkAccount(bool force = false /* Metadata: 0x0197AFB3 */) => default; // 0x0000000186837390-0x00000001868375D0
		public Task<bool> UnlinkAccount() => default; // 0x00000001868375D0-0x00000001868379B0
	}
}
