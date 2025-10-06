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
	public class GameStateSurvarotsSelection : GameStateMachineState // TypeDefIndex: 14128
	{
		// Constructors
		public GameStateSurvarotsSelection() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		public override void OnEnter() {} // 0x0000000186D98840-0x0000000186D988F0
		public override void OnExit() {} // 0x0000000186D988F0-0x0000000186D98CD0
		private void AddCharacterCard(UISignals.CharacterCardSelectedSignal sig) {} // 0x0000000186D98CD0-0x0000000186D98E20
		private void Skip() {} // 0x0000000186D98E20-0x0000000186D98E90
		[IteratorStateMachine(typeof(_WaitDelay_d__4))]
		private IEnumerator WaitDelay() => default; // 0x0000000186D98E90-0x0000000186D98F30
		private void OnConnectionError(GameplaySignals.ConnectionErrorSignal signal) {} // 0x0000000186D98F30-0x0000000186D98FA0
	}
}
