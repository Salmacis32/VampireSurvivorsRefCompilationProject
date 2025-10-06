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
	public class GameStateTreasure : GameStateMachineState // TypeDefIndex: 14130
	{
		// Constructors
		public GameStateTreasure() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		public override void OnEnter() {} // 0x0000000186D99980-0x0000000186D99D80
		public override void OnExit() {} // 0x0000000186D99D80-0x0000000186D9A0B0
		private void OnConnectionError(GameplaySignals.ConnectionErrorSignal signal) {} // 0x0000000186D9A0B0-0x0000000186D9A120
		private void ReturnToGame(GameplaySignals.OpenTreasureCompletedSignal sig) {} // 0x0000000186D9A120-0x0000000186D9A2A0
		private void ForceReturnToGame() {} // 0x0000000186D9A2A0-0x0000000186D9A310
	}
}
