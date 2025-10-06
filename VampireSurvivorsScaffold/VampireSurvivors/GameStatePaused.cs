/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using VampireSurvivors.Signals;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class GameStatePaused : GameStateMachineState // TypeDefIndex: 14124
	{
		// Fields
		private bool _enteredThisFrame; // 0x30
	
		// Constructors
		public GameStatePaused() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		public override void OnEnter() {} // 0x0000000186C5DA10-0x0000000186C5E740
		public override void OnExit() {} // 0x0000000186C5E740-0x0000000186C5F210
		public void Update() {} // 0x0000000186C5F210-0x0000000186C5F660
		private bool IsButtonPressed(Player pausingPlayer) => default; // 0x0000000186C5F660-0x0000000186C5F710
		private void OnConnectionError(GameplaySignals.ConnectionErrorSignal signal) {} // 0x0000000186C5F710-0x0000000186C5F780
		private void ReturnToGame() {} // 0x0000000186C5F780-0x0000000186C5F890
		public void QuitGame() {} // 0x0000000186C5F890-0x0000000186C5F940
		private void PlayerDied(GameplaySignals.CharacterDiedSignal sig) {} // 0x0000000186C5F940-0x0000000186C5FA90
		private void LevelUp() {} // 0x0000000186C5FA90-0x0000000186C5FB20
		private void UnfreezePlayer() {} // 0x0000000186C5FB20-0x0000000186C5FBC0
		private void ShowLevelBonus() {} // 0x0000000186C5FBC0-0x0000000186C5FC50
		private void FoundNewItem() {} // 0x0000000186C5FC50-0x0000000186C5FCE0
		private void FoundNewCharacter() {} // 0x0000000186C5FCE0-0x0000000186C5FD60
		private void OpenPiano() {} // 0x0000000186C5FD60-0x0000000186C5FDE0
		private void ShowInitialArcanaSelection() {} // 0x0000000186C5FDE0-0x0000000186C5FE70
		private void ShowSurvarotsSelection() {} // 0x0000000186C5FE70-0x0000000186C5FF00
		private void ShowMerchant() {} // 0x0000000186C5FF00-0x0000000186C5FF90
		private void ShowWeaponSelection() {} // 0x0000000186C5FF90-0x0000000186C60040
		private void ShowHealer() {} // 0x0000000186C60040-0x0000000186C600C0
		private void ShowDirector() {} // 0x0000000186C600C0-0x0000000186C60140
		private static void FadeAudioDown(float volume = 0.2f /* Metadata: 0x0197700D */) {} // 0x0000000186C60140-0x0000000186C60210
		private void OpenTPWeaponSelection() {} // 0x0000000186C60210-0x0000000186C60290
		private void OpenTreasure() {} // 0x0000000186C60290-0x0000000186C60310
		private void ShowGameoverino() {} // 0x0000000186C60310-0x0000000186C60390
		private void ShowFinalFireworks() {} // 0x0000000186C60390-0x0000000186C60430
		private void ShowEndCredits() {} // 0x0000000186C60430-0x0000000186C60570
	}
}
