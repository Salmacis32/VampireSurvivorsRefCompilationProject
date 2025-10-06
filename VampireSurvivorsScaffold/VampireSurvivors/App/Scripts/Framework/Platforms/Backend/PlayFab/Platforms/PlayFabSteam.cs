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
	public class PlayFabSteam : IPlatform, IPlatformAuthentication // TypeDefIndex: 18780
	{
		// Constructors
		public PlayFabSteam() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public PlatformType GetPlatformName() => default; // 0x0000000180B209C0-0x0000000180B209D0
		public async Task<ILoginResult> LoginOrRegister() => default; // 0x0000000186838C40-0x0000000186838DC0
		public async Task<ILoginResult> Login() => default; // 0x0000000186838DC0-0x0000000186838F40
		public async Task<ILinkResult> LinkAccount(bool force = false /* Metadata: 0x0197AFB4 */) => default; // 0x0000000186838F40-0x00000001868390D0
		private Task<ILoginResult> TryLoginOrRegisterInternal() => default; // 0x00000001868390D0-0x00000001868390E0
		private Task<ILoginResult> TryLoginInternal() => default; // 0x00000001868390E0-0x00000001868390F0
		private Task<ILoginResult> LoginOrRegisterInternal(bool createAccount) => default; // 0x00000001868390F0-0x0000000186839330
		private Task<ILinkResult> LinkAccountInternal(bool force = false /* Metadata: 0x0197AFB5 */) => default; // 0x0000000186839330-0x0000000186839570
		public Task<bool> UnlinkAccount() => default; // 0x0000000186839570-0x0000000186839950
		private async Task<T> RetryAction<T>(Func<Task<T>> action, int maxAttempts = 3 /* Metadata: 0x0197AFB6 */) => default;
	}
}
