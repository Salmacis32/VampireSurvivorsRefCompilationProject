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

namespace VampireSurvivors.UI
{
	public class ScenePreloader : MonoBehaviour // TypeDefIndex: 14553
	{
		// Fields
		public RawImage _loadingBackground; // 0x20
		public GameObject _loadingIcon; // 0x28
		public GameObject _loadingText; // 0x30
	
		// Constructors
		public ScenePreloader() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		private void Awake() {} // 0x00000001871AF9F0-0x00000001871AFE30
		private void Start() {} // 0x00000001871AFE30-0x00000001871B0150
		private void TransitionGameplayIntoGameplay() {} // 0x00000001871B0150-0x00000001871B0210
		private void TransitionMainMenuIntoGameplay() {} // 0x00000001871B0210-0x00000001871B0450
		private void TransitionGameplayIntoMainMenu() {} // 0x00000001871B0450-0x00000001871B04B0
		[IteratorStateMachine(typeof(_DelayedLoadMainMenuRoutine_d__8))]
		private IEnumerator DelayedLoadMainMenuRoutine() => default; // 0x00000001871B04B0-0x00000001871B04F0
		private void ReleaseGameplay() {} // 0x00000001871B04F0-0x00000001871B0730
		private void HideVisuals() {} // 0x00000001871B0730-0x00000001871B08C0
	}
}
