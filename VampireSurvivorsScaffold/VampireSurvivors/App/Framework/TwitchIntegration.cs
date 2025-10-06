/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Lexone.UnityTwitchChat;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Framework
{
	[UsedImplicitly]
	public class TwitchIntegration : IInitializable, IDisposable // TypeDefIndex: 18600
	{
		// Fields
		private static TwitchIntegration _sInstance; // 0x00
		private string _username; // 0x10
		[Inject]
		private PlayerOptions _playerOptions; // 0x18
	
		// Properties
		public string TwitchUsername { get => default; set {} } // 0x0000000180B15C10-0x0000000180B15C20 0x0000000181958310-0x0000000181958370
		public static TwitchIntegration Instance { get => default; } // 0x00000001867EF4F0-0x00000001867EF530 
		public IRC TwitchClient { get => default; } // 0x00000001867EF530-0x00000001867EF5D0 
	
		// Constructors
		public TwitchIntegration() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public void Initialize() {} // 0x00000001867EF5D0-0x00000001867EF6C0
		public void Dispose() {} // 0x00000001867EF6C0-0x00000001867EF760
		public void Init() {} // 0x00000001867EF760-0x00000001867EF8C0
		public void Kill() {} // 0x00000001867EF8C0-0x00000001867EF9E0
		public bool IsTwitchOn() => default; // 0x00000001867EF9E0-0x00000001867EFA80
		public bool IsTwitchWorking() => default; // 0x00000001867EFA80-0x00000001867EFBB0
	}
}
