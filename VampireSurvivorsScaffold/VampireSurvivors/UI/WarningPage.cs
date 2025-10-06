/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class WarningPage : BaseUIPage // TypeDefIndex: 15049
	{
		// Fields
		public static bool Corrupt; // 0x00
		[SerializeField]
		private float WaitDuration; // 0xE0
		[SerializeField]
		private CanvasGroup Content; // 0xE8
		[SerializeField]
		private float FadeDuration; // 0xF0
		[SerializeField]
		private bool _DebugCorruptPage; // 0xF4
		private bool _isWaiting; // 0xF5
		private float _currentTime; // 0xF8
		private SignalBus _signalBus; // 0x100
	
		// Constructors
		public WarningPage() {} // 0x00000001869CDFF0-0x00000001869CE040
	
		// Methods
		[Inject]
		private void Construct(SignalBus signalBus) {} // 0x0000000184B1D430-0x0000000184B1D490
		protected override void Awake() {} // 0x00000001869CD920-0x00000001869CDCC0
		protected override void OnShowStart(GameObject g) {} // 0x00000001869CDCC0-0x00000001869CDD50
		protected override void OnHideStart(GameObject g) {} // 0x00000001869CDD50-0x00000001869CDDC0
		protected override void OnHideFinish(GameObject g) {} // 0x00000001869CDDC0-0x00000001869CDEF0
		protected override void Update() {} // 0x00000001869CDEF0-0x00000001869CDFF0
		private void Complete() {} // 0x00000001867BB800-0x00000001867BB830
	}
}
