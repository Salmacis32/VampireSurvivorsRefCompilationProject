/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class TickBoxUI : MonoBehaviour, ISelectableUI // TypeDefIndex: 15012
	{
		// Fields
		[SerializeField]
		private GameObject _On; // 0x20
		[SerializeField]
		private GameObject _Off; // 0x28
		[SerializeField]
		private UnityEvent<bool> OnToggle; // 0x30
		private bool isOn; // 0x38
	
		// Properties
		public bool IsOn { get => default; } // 0x000000018274EAA0-0x000000018274EAB0 
	
		// Constructors
		public TickBoxUI() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		private void Start() {} // 0x00000001869ACDF0-0x00000001869ACEB0
		public void Toggle() {} // 0x00000001869ACEB0-0x00000001869ACFB0
		public void SetOn() {} // 0x00000001869ACFB0-0x00000001869AD120
		public void SetOff() {} // 0x00000001869AD120-0x00000001869AD290
		public void PlaySound(bool b) {} // 0x00000001869AD290-0x00000001869AD320
		public void InitialSet(bool b) {} // 0x00000001869AD320-0x00000001869AD500
		public void Initialize(bool _isOn) {} // 0x00000001869AD500-0x00000001869AD6E0
		public void AddOnToggle(Action<bool> cb) {} // 0x00000001869AD6E0-0x00000001869AD790
		public void SetInteractive(bool isInteractive) {} // 0x00000001869AD790-0x00000001869AD890
		public Selectable GetSelectable() => default; // 0x00000001869AD890-0x00000001869AD8D0
		public GameObject GetGameObject() => default; // 0x00000001869AD8D0-0x00000001869AD910
		public void UpdateNavigation(Selectable up, Selectable down, Selectable left, Selectable right) {} // 0x0000000180B15170-0x0000000180B15180
		public void MakeVisuallyDisabled() {} // 0x00000001869AD910-0x00000001869ADA60
		public void MakeVisuallyEnabled() {} // 0x00000001869ADA60-0x00000001869ADBB0
	}
}
