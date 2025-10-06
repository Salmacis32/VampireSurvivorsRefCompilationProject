/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Dreamteck.Splines;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class UISplineFollower : MonoBehaviour // TypeDefIndex: 14258
	{
		// Fields
		[SerializeField]
		private SplineComputer Spline; // 0x20
		[SerializeField]
		private float Duration; // 0x28
		[SerializeField]
		private float InitialDelay; // 0x2C
		[SerializeField]
		private bool ShouldLoop; // 0x30
		[SerializeField]
		private int LoopCount; // 0x34
		[SerializeField]
		private float LoopInterval; // 0x38
		[SerializeField]
		private bool PlayOnAwake; // 0x3C
		private Tween _toTween; // 0x40
		private Tween _fromTween; // 0x48
		private TrailRenderer _trail; // 0x50
		private DG.Tweening.Sequence _sequence; // 0x58
	
		// Constructors
		public UISplineFollower() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		private void OnEnable() {} // 0x000000018703CBF0-0x000000018703CD10
		public void Play() {} // 0x000000018703CD10-0x000000018703CD60
		public void Complete() {} // 0x000000018703CD60-0x000000018703CE80
		public void Play(float duration, float initialDelay = 0f /* Metadata: 0x0197710C */, bool shouldLoop = false /* Metadata: 0x01977110 */, int loopCount = 1 /* Metadata: 0x01977111 */, Ease ease = Ease.Linear /* Metadata: 0x01977112 */) {} // 0x000000018703CE80-0x000000018703CF10
		public SplineComputer GetCurve() => default; // 0x0000000180B15530-0x0000000180B15540
		[IteratorStateMachine(typeof(_BeginPlaying_d__16))]
		private IEnumerator BeginPlaying(float duration, float initialDelay = 0f /* Metadata: 0x01977113 */, bool shouldLoop = false /* Metadata: 0x01977117 */, int loopCount = 1 /* Metadata: 0x01977118 */, Ease ease = Ease.Linear /* Metadata: 0x01977119 */) => default; // 0x000000018703CF10-0x000000018703CFF0
		private void DoAnimation(float duration, bool shouldLoop = false /* Metadata: 0x0197711A */, int loopCount = 1 /* Metadata: 0x0197711B */, Ease ease = Ease.Linear /* Metadata: 0x0197711C */) {} // 0x000000018703CFF0-0x000000018703D860
		private void OnDestroy() {} // 0x000000018703D860-0x000000018703D870
		public void SetSpline(SplineComputer spline) {} // 0x000000018703D870-0x000000018703DA80
		[IteratorStateMachine(typeof(_WaitAndMove_d__20))]
		private IEnumerator WaitAndMove() => default; // 0x000000018703DA80-0x000000018703DB20
	}
}
