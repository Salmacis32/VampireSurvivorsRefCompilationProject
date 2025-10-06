/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using VampireSurvivors.Signals;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class OnlineErrorPage : BaseUIPage // TypeDefIndex: 14881
	{
		// Fields
		[SerializeField]
		private TextMeshProUGUI _errorTitle; // 0xE0
		[SerializeField]
		private TextMeshProUGUI _errorText; // 0xE8
		[SerializeField]
		private GameObject _okBtn; // 0xF0
		private SignalBus _signalBus; // 0xF8
	
		// Constructors
		public OnlineErrorPage() {} // 0x00000001868F8660-0x00000001868F86B0
	
		// Methods
		[Inject]
		public void Construct(SignalBus signalBus) {} // 0x00000001868F80E0-0x00000001868F8340
		public void GoBack() {} // 0x00000001868F8340-0x00000001868F8450
		private void OnShowError(UISignals.ShowOnlineErrorScreenSignal sig) {} // 0x00000001868F8450-0x00000001868F84B0
		private void OnDestroy() {} // 0x00000001868F84B0-0x00000001868F85E0
		protected override void OnShowStart(GameObject g) {} // 0x00000001868F85E0-0x00000001868F8660
	}
}
