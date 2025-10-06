/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class ButtonNavigator : MonoBehaviour // TypeDefIndex: 14708
	{
		// Fields
		public SelectableUI.SelectableType SelectionType; // 0x20
		[SerializeField]
		private List<GameObject> _Graphics; // 0x28
		private RectTransform rectTransform; // 0x30
		private RectTransform OriginalParent; // 0x38
		private RectTransform Target; // 0x40
	
		// Constructors
		public ButtonNavigator() {} // 0x00000001867ADA50-0x00000001867ADB50
	
		// Methods
		private void Start() {} // 0x00000001867AC2F0-0x00000001867AC7C0
		private void OnDestroy() {} // 0x00000001867AC7C0-0x00000001867ACB60
		private void LateUpdate() {} // 0x00000001867ACB60-0x00000001867AD2B0
		private void Reset(RectTransform rtrans) {} // 0x00000001867AD2B0-0x00000001867AD540
		private void MoveToSelection(RectTransform rtrans) {} // 0x00000001867AD540-0x00000001867AD750
		private void SetVisibility(bool b) {} // 0x00000001867AD750-0x00000001867AD930
		private void Disable(RectTransform rTrans) {} // 0x00000001867AD930-0x00000001867AD960
		public void DisableAllNavigation() {} // 0x00000001867AD960-0x00000001867ADA50
	}
}
