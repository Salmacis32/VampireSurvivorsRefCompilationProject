/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class SelectableUI : MonoBehaviour, ISelectHandler, IDeselectHandler // TypeDefIndex: 14978
	{
		// Fields
		[SerializeField]
		private bool _ShowSelector; // 0x20
		[SerializeField]
		private bool _CanBeSelectedThroughMouse; // 0x21
		[SerializeField]
		private RectTransform _AlternateSelectionIcon; // 0x28
		[SerializeField]
		private bool _IgnoreNavigation; // 0x30
		[SerializeField]
		private bool ForceStupidDumbScrollViewMaskingFix; // 0x31
		[SerializeField]
		private bool _ShouldUpdatePositionWhenForcingDumbFix; // 0x32
		[SerializeField]
		private bool _ShouldUpdateSizeWhenForcingDumbFix; // 0x33
		[SerializeField]
		private bool _ShouldReParentToCanvasWhenFixingMasking; // 0x34
		public SelectableType selectionType; // 0x38
		public static SelectableUI CurrentSelectableUI; // 0x18
		public bool ReselectIfDefaultSelectedOnPage; // 0x50
		public bool IsDefaultSelectedOnPage; // 0x51
		private bool isSelected; // 0x52
		private Selectable _selectable; // 0x58
		private Navigation _originalNavigation; // 0x60
		private global::Rewired.Player _player; // 0x88
		private Transform _initialParent; // 0x90
		private bool previousMPState; // 0x98
	
		// Events
		public static event OnSelection UIButtonSelected;
		public static event OnSelection UIItemSelected;
		public static event OnSelection UIItemDestroyed;
		public event OnSelectionChanged OnBecameSelected;
		public event OnSelectionChanged OnBecameDeselected;
		public static event OnSetSelectorVisibility SetSelectorVisibility;
	
		// Nested types
		public enum SelectableType // TypeDefIndex: 14970
		{
			BUTTON = 0,
			ITEM = 1
		}
	
		public delegate void OnSelection(RectTransform rTrans); // TypeDefIndex: 14971; 0x000000018196C5F0-0x000000018196C600
	
		public delegate void OnSetSelectorVisibility(bool b); // TypeDefIndex: 14972; 0x000000018196C5F0-0x000000018196C600
	
		public delegate void OnSelectionChanged(); // TypeDefIndex: 14973; 0x000000018196C270-0x000000018196C280
	
		// Constructors
		public SelectableUI() {} // 0x00000001865B2B50-0x00000001865B2BB0
	
		// Methods
		protected virtual void Awake() {} // 0x0000000186967380-0x0000000186967530
		public bool IsSelected() => default; // 0x0000000185479BF0-0x0000000185479C00
		protected virtual void OnEnable() {} // 0x0000000186967530-0x0000000186967940
		[IteratorStateMachine(typeof(_DelayedColourRefresh_d__43))]
		private IEnumerator DelayedColourRefresh() => default; // 0x0000000186967940-0x00000001869679E0
		public void UpdateAlternateSelectionIconColour() {} // 0x00000001869679E0-0x0000000186967C90
		protected virtual void OnDisable() {} // 0x0000000186967C90-0x0000000186967E00
		[IteratorStateMachine(typeof(_WaitFrame_d__46))]
		private IEnumerator WaitFrame() => default; // 0x0000000186967E00-0x0000000186967EA0
		public void OnSelect(BaseEventData eventData) {} // 0x0000000186967EA0-0x00000001869685A0
		protected virtual void OnDestroy() {} // 0x00000001869685A0-0x0000000186968630
		protected virtual void OnSelected() {} // 0x0000000180B15170-0x0000000180B15180
		public void OnDeselect(BaseEventData eventData) {} // 0x0000000186968630-0x00000001869689E0
		[IteratorStateMachine(typeof(_WaitForEndOfFrameAndReselect_d__51))]
		private IEnumerator WaitForEndOfFrameAndReselect() => default; // 0x00000001869689E0-0x0000000186968A80
		[IteratorStateMachine(typeof(_WaitForEndOfFrameAndReselectPrevious_d__52))]
		private static IEnumerator WaitForEndOfFrameAndReselectPrevious() => default; // 0x0000000186968A80-0x0000000186968AC0
		protected virtual void OnDeselected() {} // 0x0000000180B15170-0x0000000180B15180
		public void Deselect() {} // 0x0000000186968AC0-0x0000000186968B20
		public void Update() {} // 0x0000000186968B20-0x0000000186968F60
	}
}
