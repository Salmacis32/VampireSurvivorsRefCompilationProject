/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	public class EME_RibbonController : MonoBehaviour // TypeDefIndex: 15342
	{
		// Fields
		[SerializeField]
		private EME_Ribbon _ribbon; // 0x20
		[SerializeField]
		private float _travelToNewTargetDuration; // 0x28
		[SerializeField]
		private float _fadeTimeOnTargetChanged; // 0x2C
		private RibbonState _currentState; // 0x30
		private float _timeInCurrentState; // 0x34
		private float _toTargetPercent; // 0x38
		private Vector3 _targetPosition; // 0x3C
		private Vector3 _nextTargetPosition; // 0x48
		private Camera _mainCamera; // 0x58
	
		// Properties
		public bool RibbonDisabled { get => default; } // 0x0000000186B8D050-0x0000000186B8D060 
	
		// Nested types
		private enum RibbonState // TypeDefIndex: 15341
		{
			TravelingToNewTarget = 0,
			ReachedTarget = 1,
			FadingOnTargetChanged = 2,
			Disabled = 3
		}
	
		// Constructors
		public EME_RibbonController() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		private void Awake() {} // 0x0000000186B8CF90-0x0000000186B8D000
		public void DisableRibbon() {} // 0x0000000186B8D000-0x0000000186B8D050
		public void UpdateRibbon(Vector3 playerPosition) {} // 0x0000000186B8D060-0x0000000186B8D5E0
		public void SetNewTargetPosition(Vector3 newTargetPosition, bool skipFadeOut = false /* Metadata: 0x0197758F */, bool skipFadeIn = false /* Metadata: 0x01977590 */) {} // 0x0000000186B8D5E0-0x0000000186B8D6F0
		private void ChangeState(RibbonState newState) {} // 0x0000000186B8D6F0-0x0000000186B8D740
	}
}
