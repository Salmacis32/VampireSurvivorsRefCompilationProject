/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class LargeMultiOptionPopup : BasePopup // TypeDefIndex: 14822
	{
		// Fields
		[SerializeField]
		protected TextMeshProUGUI _Title; // 0x48
		[SerializeField]
		protected TextMeshProUGUI _Description; // 0x50
		[SerializeField]
		protected RectTransform _Container; // 0x58
		[SerializeField]
		protected UnityEngine.UI.Button _Confirm; // 0x60
		[SerializeField]
		protected GameObject _OptionPrefab; // 0x68
		protected int _selectedIndex; // 0x70
		private global::Rewired.Player _player; // 0x78
		protected Action<int> _onSelectedCallback; // 0x80
		protected Action _onClosedCallback; // 0x88
	
		// Constructors
		public LargeMultiOptionPopup() {} // 0x00000001867AC2E0-0x00000001867AC2F0
	
		// Methods
		protected void Update() {} // 0x00000001868B88E0-0x00000001868B8970
		public virtual void Initialize(string id, string title, string description, List<OptionDataSet> options, Action<int> callback, Action closedCallback) {} // 0x00000001868B8970-0x00000001868B93F0
		[IteratorStateMachine(typeof(_FrameDelays_d__11))]
		private IEnumerator FrameDelays() => default; // 0x00000001868B93F0-0x00000001868B9490
		public void SelectOption(int index) {} // 0x00000001868B9490-0x00000001868B9600
		public void SelectOption(GameObject g) {} // 0x00000001868B9600-0x00000001868B9890
		public void Confirm() {} // 0x00000001868B9890-0x00000001868B98E0
		public void Closed() {} // 0x00000001868B98E0-0x00000001868B9930
	}
}
