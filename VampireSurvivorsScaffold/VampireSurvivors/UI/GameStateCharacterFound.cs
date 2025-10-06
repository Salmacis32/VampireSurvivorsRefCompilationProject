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
	public class GameStateCharacterFound : GameStateMachineState // TypeDefIndex: 14558
	{
		// Constructors
		public GameStateCharacterFound() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		public override void OnEnter() {} // 0x00000001871B0E30-0x00000001871B1140
		public override void OnExit() {} // 0x00000001871B1140-0x00000001871B1390
		private void CharacterCollected(UISignals.CharacterCollectedSignal sig) {} // 0x00000001871B1390-0x00000001871B14D0
		private void ReturnToGame() {} // 0x00000001871B14D0-0x00000001871B1540
		private void OnConnectionError(GameplaySignals.ConnectionErrorSignal signal) {} // 0x00000001871B1540-0x00000001871B15B0
	}
}
