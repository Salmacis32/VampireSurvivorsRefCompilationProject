/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class AdvancedNavigationConfig : MonoBehaviour, ISelectHandler, IDeselectHandler // TypeDefIndex: 14653
	{
		// Fields
		private Selectable _selectable; // 0x20
		[SerializeField]
		private List<Selectable> _OnUp; // 0x28
		[SerializeField]
		private List<Selectable> _OnDown; // 0x30
		[SerializeField]
		private List<Selectable> _OnLeft; // 0x38
		[SerializeField]
		private List<Selectable> _OnRight; // 0x40
	
		// Constructors
		public AdvancedNavigationConfig() {} // 0x0000000187317E70-0x00000001873180C0
	
		// Methods
		private void Awake() {} // 0x00000001873172E0-0x00000001873173C0
		private void UpdateConfig() {} // 0x00000001873173C0-0x0000000187317D20
		public void OnSelect(BaseEventData eventData) {} // 0x0000000187317D20-0x0000000187317DD0
		[IteratorStateMachine(typeof(_WaitAFrame_d__8))]
		private IEnumerator WaitAFrame() => default; // 0x0000000187317DD0-0x0000000187317E70
		public void OnDeselect(BaseEventData eventData) {} // 0x0000000180B15170-0x0000000180B15180
	}
}
