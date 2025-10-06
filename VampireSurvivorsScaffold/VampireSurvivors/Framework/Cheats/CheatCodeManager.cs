/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;
using VampireSurvivors.Achievements;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Cheats
{
	public class CheatCodeManager : IInitializable, IDisposable // TypeDefIndex: 18373
	{
		// Fields
		protected Player _player; // 0x10
		protected PlayerOptions _playerOptions; // 0x18
		protected AchievementManager _achievementManager; // 0x20
		protected readonly List<CheatCodeCombo> _cheatCodeCombos; // 0x28
	
		// Nested types
		protected class CheatCodeCombo // TypeDefIndex: 18372
		{
			// Fields
			public List<KeyCode> Combo; // 0x10
			public List<string> ActionCombo; // 0x18
			public Action OnComboComplete; // 0x20
			private int _currentIndex; // 0x28
			private bool _isComplete; // 0x2C
	
			// Constructors
			public CheatCodeCombo() {} // 0x0000000180B15170-0x0000000180B15180
	
			// Methods
			public void CheckComboKeyboard(Rewired.Keyboard keyboard) {} // 0x0000000186742170-0x0000000186742280
			public void CheckComboController(Player player) {} // 0x0000000186742280-0x0000000186742360
			private IGamepadTemplate GetGamepad(Player player) => default; // 0x0000000186742360-0x00000001867423E0
		}
	
		// Constructors
		public CheatCodeManager() {} // 0x00000001867420B0-0x0000000186742170
	
		// Methods
		[Inject]
		private void Construct(PlayerOptions playerOptions, AchievementManager achievementManager) {} // 0x00000001819A2C80-0x00000001819A2D30
		public void Initialize() {} // 0x0000000186741DA0-0x0000000186741E60
		public void Dispose() {} // 0x0000000186741E60-0x0000000186741ED0
		public virtual void InternalUpdate() {} // 0x0000000186741ED0-0x0000000186741EE0
		protected virtual void AddCheatCodeCombos() {} // 0x0000000180B15170-0x0000000180B15180
		private void CheckForCheatCodeComboActivation() {} // 0x0000000186741EE0-0x00000001867420B0
	}
}
