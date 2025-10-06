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
using UnityEngine.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class OptionsMultipleChoice : MonoBehaviour, ISelectableUI // TypeDefIndex: 14904
	{
		// Fields
		[SerializeField]
		private TextMeshProUGUI _Label; // 0x20
		[SerializeField]
		private GameObject _OptionPrefab; // 0x28
		[SerializeField]
		private RectTransform _Container; // 0x30
		private OptionsMultipleChoiceOption _selected; // 0x38
		private List<GameObject> _spawned; // 0x40
		private Selectable _above; // 0x48
		private Selectable _below; // 0x50
	
		// Constructors
		public OptionsMultipleChoice() {} // 0x0000000186926B70-0x0000000186926C70
	
		// Methods
		public void Initialize(string text, List<string> optionLabels, List<Action> callbacks, int selectedIndex) {} // 0x0000000186926100-0x00000001869265A0
		public void OptionSelected(OptionsMultipleChoiceOption option) {} // 0x00000001869265A0-0x0000000186926640
		public Selectable GetSelectable() => default; // 0x0000000186926640-0x00000001869266D0
		public GameObject GetGameObject() => default; // 0x0000000182774DD0-0x0000000182774DE0
		public void UpdateNavigation(Selectable up, Selectable down, Selectable left, Selectable right) {} // 0x00000001869266D0-0x0000000186926B30
		[IteratorStateMachine(typeof(_FrameDelay_d__12))]
		private IEnumerator FrameDelay() => default; // 0x0000000186926B30-0x0000000186926B70
	}
}
