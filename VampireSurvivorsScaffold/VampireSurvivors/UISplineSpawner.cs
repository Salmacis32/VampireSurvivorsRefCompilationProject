/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Dreamteck.Splines;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class UISplineSpawner : MonoBehaviour // TypeDefIndex: 14260
	{
		// Fields
		[SerializeField]
		private UISplineFollower _ContentToSpawn; // 0x20
		private SplineComputer _spline; // 0x28
		private float _interval; // 0x30
		private float _duration; // 0x34
		private float _currentTime; // 0x38
		private float _intervalTime; // 0x3C
		private float _speed; // 0x40
		private float _delay; // 0x44
		private RectTransform _container; // 0x48
		private List<UISplineFollower> _spawned; // 0x50
	
		// Constructors
		public UISplineSpawner() {} // 0x000000018703E730-0x000000018703E830
	
		// Methods
		public void SetContainer(RectTransform rTran) {} // 0x000000018268E650-0x000000018268E6B0
		public void StartSpawning(SplineComputer spline, float interval, float duration, float speed, float delay = 0f /* Metadata: 0x0197711D */) {} // 0x000000018703E290-0x000000018703E3C0
		[IteratorStateMachine(typeof(_DoSpawning_d__12))]
		private IEnumerator DoSpawning() => default; // 0x000000018703E3C0-0x000000018703E460
		private void OnDestroy() {} // 0x000000018703E460-0x000000018703E470
		public void Clear() {} // 0x000000018703E470-0x000000018703E730
	}
}
