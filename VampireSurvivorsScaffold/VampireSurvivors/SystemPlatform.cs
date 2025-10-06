/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Achievements;
using VampireSurvivors.App.Scripts.Framework.Platforms;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Platforms;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class SystemPlatform : IInitializable, IDisposable, ITickable // TypeDefIndex: 13918
	{
		// Fields
		private IBaseAccount m_CurrentSystem; // 0x10
		private static SystemPlatform sInstance; // 0x00
		public static SystemPlatformTypes Platform; // 0x18
		[Inject]
		private PlayerOptions _playerOptions; // 0x18
		[Inject]
		private DataManager _dataManager; // 0x20
	
		// Properties
		public static IBaseAccount Account { get => default; } // 0x00000001865C2BD0-0x00000001865C2C20 
		public static SystemPlatform Instance { get => default; } // 0x00000001865C2C20-0x00000001865C2C60 
		public PlayerOptions PlayerOptions { get => default; } // 0x0000000180B15520-0x0000000180B15530 
		public DataManager DataManager { get => default; } // 0x0000000180B15530-0x0000000180B15540 
		public static AchievementPlatform CurrentPlatform { get => default; } // 0x0000000180B21570-0x0000000180B21580 
	
		// Events
		public static event Action OnUpdate;
		public static event Action OnQuit;
	
		// Constructors
		public SystemPlatform() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		private void Update() {} // 0x00000001865C30A0-0x00000001865C3100
		public void Initialize() {} // 0x00000001865C3100-0x00000001865C3250
		public void Dispose() {} // 0x00000001865C3250-0x00000001865C33A0
		public void Tick() {} // 0x00000001865C33A0-0x00000001865C3400
		public void GetAuthToken(Action<PlatformAuthToken> onSuccess, Action<string> onError, Action<TokenAbortReason> onAbort) {} // 0x00000001865C3400-0x00000001865C3750
	}
}
