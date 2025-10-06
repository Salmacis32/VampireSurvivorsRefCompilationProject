/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class GameOptionsNavigationConfig : MonoBehaviour // TypeDefIndex: 14199
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Button _QuitButton; // 0x20
		[SerializeField]
		private UnityEngine.UI.Button _ResumeButton; // 0x28
		[SerializeField]
		private Selectable _FancyBackground; // 0x30
		[SerializeField]
		private Selectable _VisibleJoystick; // 0x38
		[SerializeField]
		private Selectable _DamageNumbers; // 0x40
		[SerializeField]
		private Selectable _FlashingVFX; // 0x48
	
		// Constructors
		public GameOptionsNavigationConfig() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		private void OnEnable() {} // 0x0000000186DAE450-0x0000000186DAE500
		[IteratorStateMachine(typeof(_WaitFrame_d__7))]
		private IEnumerator WaitFrame() => default; // 0x0000000186DAE500-0x0000000186DAE5A0
		protected void SetNavigationUp(Selectable origin, Selectable target = null) {} // 0x0000000186DAE5A0-0x0000000186DAE800
		protected void SetNavigationDown(Selectable origin, Selectable target = null) {} // 0x0000000186DAE800-0x0000000186DAEA90
		protected void SetNavigationLeft(Selectable origin, Selectable target = null) {} // 0x0000000186DAEA90-0x0000000186DAED20
		protected void SetNavigationRight(Selectable origin, Selectable target = null) {} // 0x0000000186DAED20-0x0000000186DAEF80
	}
}
