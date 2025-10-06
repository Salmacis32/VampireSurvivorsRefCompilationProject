/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class CustomDropDown : MonoBehaviour, ISelectableUI // TypeDefIndex: 14743
	{
		// Fields
		[SerializeField]
		private TextMeshProUGUI _Label; // 0x20
		[SerializeField]
		private Graphic _SelectedItem; // 0x28
		[SerializeField]
		private Image _Arrow; // 0x30
		[SerializeField]
		private GameObject _OptionPrefab; // 0x38
		[FormerlySerializedAs("_Container")]
		[SerializeField]
		private RectTransform _ContentContainer; // 0x40
		[SerializeField]
		private UnityEngine.UI.Button _DropDown; // 0x48
		[SerializeField]
		private int _ItemsToShow; // 0x50
		[SerializeField]
		private ScrollEnhancer _Scroll; // 0x58
		[SerializeField]
		private GameObject _DropdownScrollContainer; // 0x60
		private List<CustomDropdownItem> _spawned; // 0x68
		private List<object> _options; // 0x70
		private Action<int> _callback; // 0x78
		private int _selectedIndex; // 0x80
	
		// Properties
		public bool IsOpen { get => default; } // 0x0000000186879590-0x0000000186879630 
	
		// Constructors
		public CustomDropDown() {} // 0x000000018687B390-0x000000018687B530
	
		// Methods
		public void InitialSet(string text, List<object> options, int selectedIndex, Action<int> callbackWithNewSelectedIndex, bool clearCurrentOptions = false /* Metadata: 0x019771F9 */) {} // 0x0000000186879630-0x0000000186879A10
		private void ClearOptions() {} // 0x0000000186879A10-0x0000000186879C70
		public void RegenerateOptions(List<object> options, int selectedIndex) {} // 0x0000000186879C70-0x0000000186879E90
		private void UpdateSelectedItem(object value) {} // 0x0000000186879E90-0x000000018687A020
		public void SetItemsToShow(int count, bool force = false /* Metadata: 0x019771FA */) {} // 0x000000018687A020-0x000000018687A0F0
		[IteratorStateMachine(typeof(_WaitAndFormat_d__20))]
		private IEnumerator WaitAndFormat(int count) => default; // 0x000000018687A0F0-0x000000018687A1A0
		private void Format(int count) {} // 0x000000018687A1A0-0x000000018687A4C0
		private void ApplyNavigation() {} // 0x000000018687A4C0-0x000000018687A6C0
		public void Open() {} // 0x000000018687A6C0-0x000000018687A7A0
		public void SelectItem(CustomDropdownItem item) {} // 0x000000018687A7A0-0x000000018687AA10
		public void Close() {} // 0x000000018687AA10-0x000000018687AA90
		public void Toggle() {} // 0x000000018687AA90-0x000000018687AB80
		public void Update() {} // 0x000000018687AB80-0x000000018687B1B0
		public Selectable GetSelectable() => default; // 0x0000000180B15760-0x0000000180B15770
		public GameObject GetGameObject() => default; // 0x0000000182774DD0-0x0000000182774DE0
		public void UpdateNavigation(Selectable up, Selectable down, Selectable left, Selectable right) {} // 0x000000018687B1B0-0x000000018687B390
	}
}
