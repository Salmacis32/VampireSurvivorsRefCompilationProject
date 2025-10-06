/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Signals;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class GameStateArcanaSelectionMain : GameStateMachineState // TypeDefIndex: 14110
	{
		// Constructors
		public GameStateArcanaSelectionMain() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		public override void OnEnter() {} // 0x0000000186C58560-0x0000000186C58610
		public override void OnExit() {} // 0x0000000186C58610-0x0000000186C589F0
		private void AddArcana(UISignals.ArcanaSelectedSignal sig) {} // 0x0000000186C589F0-0x0000000186C58B20
		private void Skip() {} // 0x0000000186C58B20-0x0000000186C58B90
		[IteratorStateMachine(typeof(_WaitDelay_d__4))]
		private IEnumerator WaitDelay() => default; // 0x0000000186C58B90-0x0000000186C58C30
		private void OnConnectionError(GameplaySignals.ConnectionErrorSignal signal) {} // 0x0000000186C58C30-0x0000000186C58CA0
	}
}
