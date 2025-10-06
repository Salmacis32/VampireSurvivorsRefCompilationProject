/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class SliderUI : MonoBehaviour, ISelectableUI // TypeDefIndex: 14234
	{
		// Fields
		[SerializeField]
		private Slider _slider; // 0x20
		[SerializeField]
		private TextMeshProUGUI _label; // 0x28
		private TextMeshProUGUI _optionalValueLabel; // 0x30
	
		// Constructors
		public SliderUI() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		public void SetLabel(string text) {} // 0x0000000186932A40-0x0000000186932A70
		public void AddOnValueChange(Action<float> cb) {} // 0x0000000186F024B0-0x0000000186F02570
		public void AddOnValueChange(Action<int> cb) {} // 0x0000000186F02570-0x0000000186F02700
		public void InitialSet(float f, float minValue = 0f /* Metadata: 0x01977098 */, float maxValue = 1f /* Metadata: 0x0197709C */) {} // 0x0000000186F02700-0x0000000186F027A0
		public void InitialSet(int v, int minValue = 0 /* Metadata: 0x019770A0 */, int maxValue = 100 /* Metadata: 0x019770A1 */) {} // 0x0000000186F027A0-0x0000000186F02BA0
		public Selectable GetSelectable() => default; // 0x0000000180B15530-0x0000000180B15540
		public GameObject GetGameObject() => default; // 0x0000000182774DD0-0x0000000182774DE0
		public void UpdateNavigation(Selectable up, Selectable down, Selectable left, Selectable right) {} // 0x0000000186F02BA0-0x0000000186F02CD0
	}
}
