/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using VampireSurvivors.UI;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class ConnectionErrorPage : BaseUIPage // TypeDefIndex: 14190
	{
		// Fields
		[SerializeField]
		private TextMeshProUGUI _errorText; // 0xE0
		private SignalBus _signalBus; // 0xE8
		private LobbiesManager _lobbiesManager; // 0xF0
	
		// Constructors
		public ConnectionErrorPage() {} // 0x0000000186DAAD20-0x0000000186DAAD70
	
		// Methods
		[Inject]
		private void Construct(SignalBus signalBus, LobbiesManager lobbiesManager) {} // 0x0000000186DAA9F0-0x0000000186DAAAB0
		protected override void OnShowStart(GameObject g) {} // 0x0000000186DAAAB0-0x0000000186DAAB60
		public async void Quit() {} // 0x0000000186DAAB60-0x0000000186DAAD20
	}
}
