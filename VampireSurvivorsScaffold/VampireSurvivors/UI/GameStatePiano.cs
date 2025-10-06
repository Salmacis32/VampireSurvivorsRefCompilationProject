/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors;
using VampireSurvivors.Signals;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class GameStatePiano : GameStateMachineState // TypeDefIndex: 14563
	{
		// Constructors
		public GameStatePiano() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		public override void OnEnter() {} // 0x00000001871B28A0-0x00000001871B2BB0
		public override void OnExit() {} // 0x00000001871B2BB0-0x00000001871B2E00
		private void ResumeGame(UISignals.ClosePianoSignal signal) {} // 0x00000001871B2E00-0x00000001871B2E70
		private void ReturnToGame() {} // 0x00000001871B2E00-0x00000001871B2E70
		private void OnConnectionError(GameplaySignals.ConnectionErrorSignal signal) {} // 0x00000001871B2E70-0x00000001871B2EE0
	}
}
