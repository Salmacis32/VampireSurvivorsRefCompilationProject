/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Scripts.UI
{
	public class EME_BiomeNameUI : MonoBehaviour // TypeDefIndex: 18629
	{
		// Fields
		[SerializeField]
		private RectTransform _rectTransform; // 0x20
		[SerializeField]
		private TMP_Text _biomeNameText; // 0x28
		[SerializeField]
		private CanvasGroup _canvasGroup; // 0x30
		[SerializeField]
		private float _fadeInDuration; // 0x38
		[SerializeField]
		private AnimationCurve _fadeInCurve; // 0x40
		[SerializeField]
		private float _showDuration; // 0x48
		[SerializeField]
		private float _fadeOutDuration; // 0x4C
		[SerializeField]
		private AnimationCurve _fadeOutCurve; // 0x50
		private ShowState _currentState; // 0x58
		private float _stateTimer; // 0x5C
	
		// Properties
		public RectTransform GetRectTransform { get => default; } // 0x0000000180B15530-0x0000000180B15540 
	
		// Nested types
		private enum ShowState // TypeDefIndex: 18628
		{
			Hidden = 0,
			FadeIn = 1,
			Showing = 2,
			FadeOut = 3
		}
	
		// Constructors
		public EME_BiomeNameUI() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		public void Show(string biomeName) {} // 0x00000001867FE340-0x00000001867FE380
		public void HideImmediate() {} // 0x00000001867FE380-0x00000001867FE3B0
		private void SetState(ShowState newState) {} // 0x00000001867FE3B0-0x00000001867FE460
		public void UpdateNameUi(float deltaTime) {} // 0x00000001867FE460-0x00000001867FE640
	}
}
