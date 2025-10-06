/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Coherence.Connection;
using Coherence.Toolkit;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class AppOnlineLobbyState : AppStateMachineState // TypeDefIndex: 14093
	{
		// Fields
		private Coroutine _coroutine; // 0x40
	
		// Constructors
		public AppOnlineLobbyState() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		public override void Init(StateMachine stateMachine) {} // 0x0000000186C50220-0x0000000186C50240
		public override void OnEnter() {} // 0x0000000186C50240-0x0000000186C50B20
		public override void OnExit() {} // 0x0000000186C50B20-0x0000000186C511C0
		[IteratorStateMachine(typeof(_DisconnectIfHostNotInGameRoutine_d__4))]
		private IEnumerator DisconnectIfHostNotInGameRoutine() => default; // 0x0000000186C511C0-0x0000000186C51260
		private void OnClientDisconnected(CoherenceClientConnection clientConn) {} // 0x0000000186C51260-0x0000000186C51510
		private async void DisconnectWithoutLeavingLobby() {} // 0x0000000186C51510-0x0000000186C516D0
		private void SelectStage() {} // 0x0000000186C516D0-0x0000000186C51740
		private void StartGame() {} // 0x0000000186C51740-0x0000000186C517B0
		private async void OnBack() {} // 0x0000000186C517B0-0x0000000186C51970
		private async Task Disconnect(bool leaveLobby) => default; // 0x0000000186C51970-0x0000000186C51B30
		private async Task LeaveLobby() => default; // 0x0000000186C51B30-0x0000000186C51CE0
		private void OnDisconnected(CoherenceBridge _, ConnectionCloseReason __) {} // 0x0000000186C51CE0-0x0000000186C51D50
		private void OnShowErrorScreen() {} // 0x0000000186C51D50-0x0000000186C51DC0
		private void ShowAchievements() {} // 0x0000000186C51DC0-0x0000000186C51E30
		private void ShowCollections() {} // 0x0000000186C51E30-0x0000000186C51EA0
		private void ShowPowerUps() {} // 0x0000000186C51EA0-0x0000000186C51F10
	}
}
