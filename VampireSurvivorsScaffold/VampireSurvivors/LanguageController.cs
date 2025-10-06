/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class LanguageController : MonoBehaviour // TypeDefIndex: 14170
	{
		// Fields
		[SerializeField]
		private GameObject LanguageButtonPrefab; // 0x20
		[SerializeField]
		private RectTransform Container; // 0x28
		private List<GameObject> spawned; // 0x30
		private SignalBus signalBus; // 0x38
		private PlayerOptions _playerOptions; // 0x40
	
		// Constructors
		public LanguageController() {} // 0x0000000186DA4150-0x0000000186DA4250
	
		// Methods
		[Inject]
		private void Construct(SignalBus _signal, PlayerOptions playerOptions) {} // 0x000000018686BE80-0x000000018686BF30
		private void Start() {} // 0x0000000186DA3530-0x0000000186DA3670
		public void Set() {} // 0x0000000186DA3670-0x0000000186DA36D0
		public static string GetCurrentLanguageName() => default; // 0x0000000186DA36D0-0x0000000186DA37D0
		private void OnEnable() {} // 0x0000000186DA37D0-0x0000000186DA3C40
		[IteratorStateMachine(typeof(_FixLayout_d__10))]
		private IEnumerator FixLayout() => default; // 0x0000000186DA3C40-0x0000000186DA3CE0
		private void OnDisable() {} // 0x0000000186DA3CE0-0x0000000186DA3ED0
		public void ApplyLanguage(string code) {} // 0x0000000186DA3ED0-0x0000000186DA40E0
		public GameObject GetFirstObject() => default; // 0x0000000186DA40E0-0x0000000186DA4150
	}
}
