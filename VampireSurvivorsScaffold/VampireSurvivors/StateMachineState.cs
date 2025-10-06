/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class StateMachineState : MonoBehaviour // TypeDefIndex: 14134
	{
		// Fields
		protected StateMachine parentStateMachine; // 0x20
	
		// Constructors
		public StateMachineState() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		public virtual void Init(StateMachine stateMachine) {} // 0x0000000180B1C120-0x0000000180B1C180
		public virtual void OnEnter() {} // 0x0000000180B15170-0x0000000180B15180
		public virtual void OnExit() {} // 0x0000000180B15170-0x0000000180B15180
		protected void FireEvent(string eventStr) {} // 0x0000000186C4D740-0x0000000186C4D780
		protected void FireEventWithDelay(string eventStr, float delay) {} // 0x0000000186D9BA30-0x0000000186D9BB50
		[IteratorStateMachine(typeof(_FireEventWithDelayRoutine_d__6))]
		private IEnumerator FireEventWithDelayRoutine(string eventStr, float delay) => default; // 0x0000000186D9BB50-0x0000000186D9BC70
	}
}
