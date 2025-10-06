/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class ParticleEventCall : MonoBehaviour // TypeDefIndex: 13912
	{
		// Fields
		[Tooltip("Time in seconds after which the event will be triggered (EventTriggerTime).")]
		public float EventTriggerTime; // 0x20
		[Tooltip("The UnityEvent to invoke after the specified time.")]
		public UnityEvent onEventTriggered; // 0x28
		[SerializeField]
		private bool CallEventsOnParticleSystemStopped; // 0x30
		[HideInInspector]
		public UnityEvent OnParticleSystemStoppedEvent; // 0x38
		private ParticleSystem _particleSystem; // 0x40
		private bool _eventCalled; // 0x48
	
		// Constructors
		public ParticleEventCall() {} // 0x00000001865C2580-0x00000001865C26E0
	
		// Methods
		private void Start() {} // 0x00000001865C1FE0-0x00000001865C2390
		private void Update() {} // 0x00000001865C2390-0x00000001865C24B0
		private void CallEvents() {} // 0x00000001865C24B0-0x00000001865C24E0
		public void RestartEventTimer() {} // 0x00000001865C24E0-0x00000001865C24F0
		private void OnParticleSystemStopped() {} // 0x00000001865C24F0-0x00000001865C2530
		private void PlayFX() {} // 0x00000001865C2530-0x00000001865C2560
		private void StopFX() {} // 0x00000001865C2560-0x00000001865C2580
	}
}
