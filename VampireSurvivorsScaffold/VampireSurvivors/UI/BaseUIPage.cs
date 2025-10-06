/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Doozy.Engine.UI;
using Rewired;
using Rewired.Integration.UnityUI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.App.Scripts.Framework.Adventures;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Signals;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class BaseUIPage : MonoBehaviour // TypeDefIndex: 14700
	{
		// Fields
		[SerializeField]
		private bool _UseScreenSpaceCamera; // 0x20
		[SerializeField]
		protected bool _hasScrollView; // 0x21
		[SerializeField]
		protected float _scrollSpeed; // 0x24
		[SerializeField]
		protected RectTransform _scroll; // 0x28
		[SerializeField]
		protected RectTransform _content; // 0x30
		[SerializeField]
		protected Scrollbar _scrollbar; // 0x38
		[SerializeField]
		protected Slider _Slider; // 0x40
		[SerializeField]
		protected float _ForceScrollBarSize; // 0x48
		protected bool _AutoSizeAfterParse; // 0x4C
		[SerializeField]
		private float _OffsetWhenSliderShown; // 0x50
		[SerializeField]
		protected int ItemsPerPage; // 0x54
		protected int previouslySelectedItemIndex; // 0x58
		protected ScrollEnhancer _scrollEnhancer; // 0x60
		protected RewiredStandaloneInputModule _inputModule; // 0x68
		protected UIView View; // 0x70
		private bool ShouldLog; // 0x78
		protected SignalBus SignalBus; // 0x80
		protected MultiplayerManager Multiplayer; // 0x88
		protected global::Rewired.Player Player; // 0x90
		protected DataManager Data; // 0x98
		protected AdventureManager Adventure; // 0xA0
		protected bool _isWaitingForPlayersToEnterUi; // 0xA8
		private float _defaultRepeatDelay; // 0xAC
		private float _defaultInputActionsPerSecond; // 0xB0
		private float _maxInputActionsPerSecond; // 0xB4
		private float _scrollAccelerationSpeed; // 0xB8
		private static float SCROLL_ACTIONS_PER_SEC; // 0x00
		private static float SCROLL_ACCELERATION; // 0x04
		private Sprite _defaultPanelSprite; // 0xC0
		private RenderMode? _originalMode; // 0xC8
		private Vector3 _originalCanvasScale; // 0xD0
		private float _originalOrthographicSize; // 0xDC
	
		// Properties
		protected virtual bool IsOnlineUi { get => default; } // 0x0000000181958370-0x0000000181958380 
	
		// Constructors
		public BaseUIPage() {} // 0x000000018679D6C0-0x000000018679D740
		static BaseUIPage() {} // 0x000000018679D740-0x000000018679D7A0
	
		// Methods
		[Inject]
		private void Construct(SignalBus signalBus, MultiplayerManager _mult, DataManager _data, AdventureManager _adventure) {} // 0x00000001867981F0-0x0000000186798370
		protected virtual void Awake() {} // 0x0000000186798370-0x0000000186798AF0
		protected virtual void OnShowStart(GameObject g) {} // 0x0000000186798AF0-0x0000000186799640
		protected virtual void OnCharacterDisconnected(OnlineSignals.CharacterDisconnected signal) {} // 0x0000000186799640-0x0000000186799960
		protected void EnterMultiplayerControl(VampireSurvivors.Objects.Characters.CharacterController player, float vibrationMilliseconds = -1f /* Metadata: 0x019771D1 */) {} // 0x0000000186799960-0x0000000186799AE0
		private void SelectPlayerInput(VampireSurvivors.Objects.Characters.CharacterController player, float vibrationMilliseconds) {} // 0x0000000186799AE0-0x0000000186799C00
		protected virtual VampireSurvivors.Objects.Characters.CharacterController GetCharacterControllingUi() => default; // 0x0000000186799C00-0x0000000186799C50
		protected bool IsLocalPlayerControllingUi() => default; // 0x0000000186799C50-0x0000000186799D50
		protected void ExitMultiplayerControl() {} // 0x0000000186799D50-0x0000000186799E60
		private void EnterOnlineMultiplayerControl() {} // 0x0000000186799E60-0x000000018679A1A0
		[IteratorStateMachine(typeof(_WaitForPlayersToBeInsideGameplayUi_d__44))]
		private IEnumerator WaitForPlayersToBeInsideGameplayUi(int uiPageId) => default; // 0x000000018679A1A0-0x000000018679A250
		private List<UnityEngine.UI.Button> DeactivateButtons(out Selectable selectedBtn) {
			selectedBtn = default;
			return default;
		} // 0x000000018679A250-0x000000018679A6A0
		private void ReactivateButtons(List<UnityEngine.UI.Button> buttons, Selectable selectedBtn) {} // 0x000000018679A6A0-0x000000018679A980
		[IteratorStateMachine(typeof(_Parse_d__47))]
		private IEnumerator Parse() => default; // 0x000000018679A980-0x000000018679AA20
		public void ForceScrollAlignment() {} // 0x000000018679AA20-0x000000018679AA40
		protected virtual void OnShowFinish(GameObject g) {} // 0x000000018679AA40-0x000000018679AAF0
		protected virtual void OnHideStart(GameObject g) {} // 0x000000018679AAF0-0x000000018679AD00
		protected virtual void OnHideFinish(GameObject g) {} // 0x000000018679AD00-0x000000018679B160
		protected virtual void Update() {} // 0x000000018679B160-0x000000018679BB60
		private void ScrollSelection(bool up) {} // 0x000000018679BB60-0x000000018679C7D0
		private void ScrollPageWithoutSelectables(bool up) {} // 0x000000018679C7D0-0x000000018679C9D0
		protected void ForceBackButtonNavigation(Selectable up, Selectable down, Selectable left, Selectable right) {} // 0x000000018679C9D0-0x000000018679CBD0
		protected void ResetBackButtonNavigation() {} // 0x000000018679CBD0-0x000000018679CCC0
		protected virtual void OnEnterPressed() {} // 0x0000000180B15170-0x0000000180B15180
		protected virtual void OnCancelPressed() {} // 0x0000000180B15170-0x0000000180B15180
		protected void SetNavigationUp(Selectable origin, Selectable target = null) {} // 0x000000018679CCC0-0x000000018679CF20
		protected void SetNavigationDown(Selectable origin, Selectable target = null) {} // 0x000000018679CF20-0x000000018679D1B0
		protected void SetNavigationLeft(Selectable origin, Selectable target = null) {} // 0x000000018679D1B0-0x000000018679D440
		protected void SetNavigationRight(Selectable origin, Selectable target = null) {} // 0x000000018679D440-0x000000018679D6A0
		protected void SetNavigationMode(Selectable origin, Navigation.Mode mode) {} // 0x0000000186797C90-0x0000000186797CF0
		protected void ClearNavigationUp(Selectable origin) {} // 0x0000000186797CF0-0x0000000186797DC0
		protected void ClearNavigationDown(Selectable origin) {} // 0x0000000186797DC0-0x0000000186797E90
		protected void ClearNavigationLeft(Selectable origin) {} // 0x0000000186797E90-0x0000000186797F60
		protected void ClearNavigationRight(Selectable origin) {} // 0x0000000186797F60-0x0000000186798020
		public void SetScrollAcceleration(float maxSpeed, float acceleration) {} // 0x000000018679D6A0-0x000000018679D6C0
	}
}
