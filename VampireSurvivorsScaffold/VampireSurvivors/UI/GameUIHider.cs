/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Objects;
using VampireSurvivors.Signals;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class GameUIHider : MonoBehaviour // TypeDefIndex: 14790
	{
		// Fields
		private SignalBus _signalBus; // 0x20
		private PlayerOptions _playerOptions; // 0x28
	
		// Constructors
		public GameUIHider() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		[Inject]
		private void Construct(SignalBus signal, PlayerOptions playerOptions) {} // 0x00000001852686F0-0x00000001852687A0
		private void Start() {} // 0x00000001868A0000-0x00000001868A0240
		private void OnDestroy() {} // 0x00000001868A0240-0x00000001868A0370
		private void HandleHideGameUISignal(UISignals.ToggleHideGameUISignal signal) {} // 0x00000001868A0370-0x00000001868A03A0
	}
}
