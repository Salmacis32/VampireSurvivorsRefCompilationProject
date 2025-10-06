/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class StateMachine : MonoBehaviour // TypeDefIndex: 14132
	{
		// Fields
		public const string ENTER_DONE = "ENTER_DONE"; // Metadata: 0x01977015
		protected readonly Dictionary<System.Type, StateMachineState> instanceCache; // 0x30
		protected Dictionary<System.Type, Dictionary<string, System.Type>> overallTransitionMap; // 0x38
		protected StateMachineState currentState; // 0x40
		protected Dictionary<string, System.Type> currentTransitionMap; // 0x48
		protected DiContainer Container; // 0x50
	
		// Properties
		public string TransitionTriggerEvent { get; private set; } // 0x0000000180B15540-0x0000000180B15550 0x0000000180B1D4C0-0x0000000180B1D520
		public StateMachineState CurrentState { get => default; } // 0x0000000180B15750-0x0000000180B15760 
	
		// Events
		public event Action ExitStateEntered;
	
		// Constructors
		public StateMachine() {} // 0x0000000186D9B8A0-0x0000000186D9BA30
	
		// Methods
		[Inject]
		private void Construct(DiContainer container) {} // 0x000000018261D810-0x000000018261D870
		public void StartStateMachine<TInitialState>()
			where TInitialState : StateMachineState {}
		public virtual void Stop() {} // 0x0000000186D9AB30-0x0000000186D9ACE0
		protected void ResetTransitionMap() {} // 0x0000000186D9ACE0-0x0000000186D9ADB0
		public void AddExitListener(Action listener) {} // 0x0000000186D9A950-0x0000000186D9AA40
		public void RemoveExitListener(Action listener) {} // 0x0000000186D9AA40-0x0000000186D9AB30
		public virtual void ExitEntered() {} // 0x0000000186D9ADB0-0x0000000186D9ADF0
		protected void GoToState(System.Type state) {} // 0x0000000186D9ADF0-0x0000000186D9AF50
		private void UpdateTransitionMap(System.Type state) {} // 0x0000000186D9AF50-0x0000000186D9AFB0
		protected virtual void SetCurrentState(System.Type stateType) {} // 0x0000000186D9AFB0-0x0000000186D9B0F0
		public virtual void FireEvent(string eventStr) {} // 0x0000000186D9B0F0-0x0000000186D9B610
		protected StateMachineState GetStateInstance(System.Type stateType) => default; // 0x0000000186D9B610-0x0000000186D9B8A0
		protected void AddStateTransition<TFromState, TToState>(string eventStr)
			where TFromState : StateMachineState
			where TToState : StateMachineState {}
	}
}
