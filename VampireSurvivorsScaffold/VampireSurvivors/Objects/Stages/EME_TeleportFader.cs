/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	public class EME_TeleportFader : MonoBehaviour // TypeDefIndex: 15344
	{
		// Fields
		[SerializeField]
		private Image _faderImage; // 0x20
		[SerializeField]
		private Image _whiteFade; // 0x28
		[SerializeField]
		[Space]
		private float _fadeInTime; // 0x30
		[SerializeField]
		private float _fadeHoldTime; // 0x34
		[SerializeField]
		private float _fadeOutTime; // 0x38
		[SerializeField]
		[Space]
		private float _maxTrianglesAlpha; // 0x3C
		[SerializeField]
		private bool _fadeInTrianglesAlpha; // 0x40
		[SerializeField]
		private bool _includeBackgroundWhiteFade; // 0x41
		[SerializeField]
		private AnimationCurve _whiteFadeCurve; // 0x48
		private float _fadeTimer; // 0x50
		private FadeState _currentState; // 0x54
		private static readonly int FadeProgress; // 0x00
	
		// Events
		public event Action OnFadeInComplete;
		public event Action OnFadeOutComplete;
	
		// Nested types
		private enum FadeState // TypeDefIndex: 15343
		{
			Idle = 0,
			FadeIn = 1,
			Hold = 2,
			FadeOut = 3
		}
	
		// Constructors
		public EME_TeleportFader() {} // 0x0000000186B8E020-0x0000000186B8E070
		static EME_TeleportFader() {} // 0x0000000186B8E070-0x0000000186B8E0D0
	
		// Methods
		public void Init() {} // 0x0000000186B8DB00-0x0000000186B8DB10
		public void BeginFade(Action onFadeInComplete, Action onFadeOutComplete) {} // 0x0000000186B8DB10-0x0000000186B8DBD0
		public void UpdateFade() {} // 0x0000000186B8DBD0-0x0000000186B8DD30
		private void SetFadeProgress(float fadeValue) {} // 0x0000000186B8DD30-0x0000000186B8DFE0
		public void TestFade() {} // 0x0000000186B8DFE0-0x0000000186B8E020
	}
}
