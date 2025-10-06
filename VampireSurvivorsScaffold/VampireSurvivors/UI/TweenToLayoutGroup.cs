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

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class TweenToLayoutGroup : MonoBehaviour // TypeDefIndex: 15034
	{
		// Fields
		private Vector3 originalPos; // 0x20
		private RectTransform newTarget; // 0x30
		private RectTransform mRectTransform; // 0x38
		private CanvasGroup cg; // 0x40
		private float _delay; // 0x48
		private float _duration; // 0x4C
		private Tween _tween; // 0x50
		private Tween _cgTween; // 0x58
		private Tween _scaleTween; // 0x60
		private Vector3 _from; // 0x68
		private bool _isWorldPos; // 0x74
		private bool _autoComplete; // 0x75
	
		// Constructors
		public TweenToLayoutGroup() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		public void TweenFromLocationToLayoutSpot(Transform sender, Vector3 from, float duration, float delay, bool isWorldPos = false /* Metadata: 0x0197727E */) {} // 0x00000001869C47D0-0x00000001869C5010
		public void Complete() {} // 0x00000001869C5010-0x00000001869C5070
		[IteratorStateMachine(typeof(_WaitAndDo_d__14))]
		private IEnumerator WaitAndDo() => default; // 0x00000001869C5070-0x00000001869C5110
		private void OnDestroy() {} // 0x00000001869C5110-0x00000001869C5360
	}
}
