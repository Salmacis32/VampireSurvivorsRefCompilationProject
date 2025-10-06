/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine.SceneManagement;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class CheatsController : IInitializable, IDisposable // TypeDefIndex: 14152
	{
		// Fields
		private List<CheatData> _gameplayCheats; // 0x10
		private List<CheatData> _menuCheats; // 0x18
		[Inject]
		private SignalBus _signalBus; // 0x20
		private Player _player; // 0x28
	
		// Constructors
		public CheatsController() {} // 0x0000000186DA1490-0x0000000186DA15D0
	
		// Methods
		public void Initialize() {} // 0x0000000186DA0D10-0x0000000186DA0E40
		private void UnloadCheats(Scene arg0) {} // 0x0000000186DA0E40-0x0000000186DA0F60
		private void SceneLoaded(Scene arg0, LoadSceneMode arg1) {} // 0x0000000186DA0F60-0x0000000186DA0FB0
		private void LoadCheats(string sceneName) {} // 0x0000000186DA0FB0-0x0000000186DA0FF0
		public void Dispose() {} // 0x0000000180B15170-0x0000000180B15180
		private void AddAllGameplayCheats() {} // 0x0000000180B15170-0x0000000180B15180
		private void AddAllMenuCheats() {} // 0x0000000180B15170-0x0000000180B15180
		private void AddGameplayCheat(string label, Action cb) {} // 0x0000000186DA0FF0-0x0000000186DA1160
		private void AddMenuCheat(string label, Action cb) {} // 0x0000000186DA1160-0x0000000186DA1270
		private void ResumeGame() {} // 0x0000000186DA1270-0x0000000186DA12C0
		public List<CheatData> GetCheats() => default; // 0x0000000186DA12C0-0x0000000186DA1490
	}
}
