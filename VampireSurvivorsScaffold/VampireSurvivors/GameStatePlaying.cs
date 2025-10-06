/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Signals;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class GameStatePlaying : GameStateMachineState // TypeDefIndex: 14125
	{
		// Fields
		private bool _enteredThisFrame; // 0x30
	
		// Constructors
		public GameStatePlaying() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		public override void OnEnter() {} // 0x0000000186D95920-0x0000000186D962E0
		public override void OnExit() {} // 0x0000000186D962E0-0x0000000186D96BD0
		public void Update() {} // 0x0000000186D96BD0-0x0000000186D972B0
		private bool ChangePlayerSpectate() => default; // 0x0000000186D972B0-0x0000000186D97350
		private bool IsSpectateModeActive() => default; // 0x0000000186D97350-0x0000000186D97450
		private bool IsPlayerProperTarget() => default; // 0x0000000186D97450-0x0000000186D97500
		private void AdvanceFreeRoamCameraTarget() {} // 0x0000000186D97500-0x0000000186D975B0
		private void OnConnectionError(GameplaySignals.ConnectionErrorSignal signal) {} // 0x0000000186D975B0-0x0000000186D97620
		private void PauseGame(GameplaySignals.GamePausedSignal signal) {} // 0x0000000186D97620-0x0000000186D97870
		private void OpenTreasure() {} // 0x0000000186D97870-0x0000000186D978F0
		private void ShowGameoverino() {} // 0x0000000186D978F0-0x0000000186D97960
		private void ShowFinalFireworks() {} // 0x0000000186D97960-0x0000000186D97A00
		private void ShowEndCredits() {} // 0x0000000186D97A00-0x0000000186D97AA0
		private void LevelUp() {} // 0x0000000186D97AA0-0x0000000186D97B20
		private void ShowLevelBonus() {} // 0x0000000186D97B20-0x0000000186D97BA0
		private void PlayerDied(GameplaySignals.CharacterDiedSignal sig) {} // 0x0000000186D97BA0-0x0000000186D97CF0
		private void FoundNewItem() {} // 0x0000000186D97CF0-0x0000000186D97D70
		private void FoundNewCharacter() {} // 0x0000000186D97D70-0x0000000186D97DF0
		private void OpenPiano() {} // 0x0000000186D97DF0-0x0000000186D97E60
		private void ShowInitialArcanaSelection() {} // 0x0000000186D97E60-0x0000000186D97EE0
		private void ShowSurvarotsSelection() {} // 0x0000000186D97EE0-0x0000000186D97F60
		private void ShowMerchant() {} // 0x0000000186D97F60-0x0000000186D97FE0
		private void ShowWeaponSelection() {} // 0x0000000186D97FE0-0x0000000186D98090
		private void ShowHealer() {} // 0x0000000186D98090-0x0000000186D98100
		private void ShowDirector() {} // 0x0000000186D98100-0x0000000186D98170
		private static void FadeAudioDown(float volume = 0.2f /* Metadata: 0x01977011 */) {} // 0x0000000186D98170-0x0000000186D98240
		private void OpenTPWeaponSelection() {} // 0x0000000186D98240-0x0000000186D982B0
	}
}
