/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Signals;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class Fader : MonoBehaviour // TypeDefIndex: 14764
	{
		// Fields
		private Image _image; // 0x20
		private SignalBus _signalBus; // 0x28
	
		// Constructors
		public Fader() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		[Inject]
		private void Construct(SignalBus signal) {} // 0x0000000180B1D4C0-0x0000000180B1D520
		private void OnEnable() {} // 0x00000001868850B0-0x00000001868852A0
		private void OnDestroy() {} // 0x00000001868852A0-0x00000001868853D0
		private void Awake() {} // 0x00000001868853D0-0x0000000186885460
		private void Fade(UISignals.FadeScreenSignal sig) {} // 0x0000000186885460-0x00000001868857B0
	}
}
