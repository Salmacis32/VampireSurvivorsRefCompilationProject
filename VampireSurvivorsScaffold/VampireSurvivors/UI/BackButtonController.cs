/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Framework;
using VampireSurvivors.Signals;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class BackButtonController : MonoBehaviour // TypeDefIndex: 14694
	{
		// Fields
		public static BackButtonController Instance; // 0x00
		public static bool BackButtonClosesPage; // 0x08
		public static bool IgnoreNextAdditionalListner; // 0x09
		public bool ListenForControllerInput; // 0x20
		private SignalBus _signalBus; // 0x28
		private SelectableUI _selectable; // 0x30
		private Selectable _rawSelectable; // 0x38
		private global::Rewired.Player Player; // 0x40
		private MultiplayerManager _multiplayer; // 0x48
		private List<Action> _backtions; // 0x50
		[SerializeField]
		private GameObject randomize; // 0x58
		[SerializeField]
		private GameObject musicSelection; // 0x60
	
		// Constructors
		public BackButtonController() {} // 0x00000001867959B0-0x0000000186795AB0
		static BackButtonController() {} // 0x0000000186795AB0-0x0000000186795B00
	
		// Methods
		[Inject]
		private void Construct(SignalBus signal, MultiplayerManager multi) {} // 0x0000000186794190-0x0000000186794240
		private void Awake() {} // 0x0000000186794240-0x0000000186794A50
		private void OnDestroy() {} // 0x0000000186794A50-0x0000000186794E70
		private void Update() {} // 0x0000000186794E70-0x0000000186795160
		public static void AddListener(Action b) {} // 0x0000000186795160-0x0000000186795230
		public static void TryRemoveListener(Action b) {} // 0x0000000186795230-0x0000000186795480
		private void RunLastAction() {} // 0x0000000186795480-0x0000000186795500
		public static void FireBack() {} // 0x0000000186795500-0x00000001867955D0
		public static void GoBack() {} // 0x00000001867955D0-0x00000001867956A0
		private void Show(UISignals.ShowBackButtonSignal sig) {} // 0x00000001867956A0-0x00000001867956E0
		private void SetNavigation(UISignals.ForceBackButtonNavigation sig) {} // 0x00000001867956E0-0x00000001867958F0
		private void ResetNavigation(UISignals.ResetBackButtonNavigation sig) {} // 0x00000001867958F0-0x0000000186795950
		private void Hide() {} // 0x0000000186795950-0x00000001867959B0
	}
}
