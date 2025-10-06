/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.App.Scripts.Framework.Adventures;
using VampireSurvivors.App.UI;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Framework.Adventures
{
	public class AdventureMeltManager : MonoBehaviour // TypeDefIndex: 18613
	{
		// Fields
		[SerializeField]
		private CanvasGroup _CanvasGroup; // 0x20
		[SerializeField]
		private RawImage _FullScreenImage; // 0x28
		[SerializeField]
		private MainMenuBackgroundManager _MainMenuBackgroundManager; // 0x30
		[SerializeField]
		private Camera _UICamera; // 0x38
		[SerializeField]
		private float _MeltDelay; // 0x40
		[SerializeField]
		private float _MeltDuration; // 0x44
		[SerializeField]
		private Ease _MeltEase; // 0x48
		private AdventureManager _adventureManager; // 0x50
		private bool _isRunning; // 0x58
		private static readonly int MeltProgressId; // 0x00
	
		// Constructors
		public AdventureMeltManager() {} // 0x00000001867F41E0-0x00000001867F4240
		static AdventureMeltManager() {} // 0x00000001867F4240-0x00000001867F42A0
	
		// Methods
		[Inject]
		private void Construct(AdventureManager adventureManager) {} // 0x00000001867F3DF0-0x00000001867F3F70
		private void Awake() {} // 0x0000000180B15170-0x0000000180B15180
		private void Start() {} // 0x00000001863456E0-0x00000001863456F0
		private void OnDestroy() {} // 0x00000001867F3F70-0x00000001867F4090
		private void OnAdventureExit() {} // 0x00000001867F4090-0x00000001867F4140
		[IteratorStateMachine(typeof(_PerformMeltEffect_d__15))]
		private IEnumerator PerformMeltEffect() => default; // 0x00000001867F4140-0x00000001867F41E0
	}
}
