/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class DraculaCutsceneTeleport : GameMonoBehaviour // TypeDefIndex: 13969
	{
		// Fields
		[SerializeField]
		private Vector3 _ScaleAtThrone; // 0x28
		[SerializeField]
		private Vector3 _ScaleInForeground; // 0x34
		[SerializeField]
		private Vector3 _ThronePosition; // 0x40
		[SerializeField]
		private Vector3 _ForeGroundPosition; // 0x4C
		[Header("Inner Column")]
		[SerializeField]
		private SpriteRenderer _InnerColumn; // 0x58
		[SerializeField]
		[Space]
		private float _InnerColumnMoveInDuration; // 0x60
		[SerializeField]
		private Vector3 _InnerColumnEndPosition; // 0x64
		[SerializeField]
		[Space]
		private float _InnerColumnScaleInDuration; // 0x70
		[SerializeField]
		private float _InnerColumnScaleInXScale; // 0x74
		[SerializeField]
		[Space]
		private float _InnerColumnScaleOutDuration; // 0x78
		[Header("Outer Column")]
		[SerializeField]
		private Transform _OuterColumnParent; // 0x80
		[SerializeField]
		private SpriteRenderer _OuterColumn; // 0x88
		[SerializeField]
		[Space]
		private float _OuterColumnScaleInDuration; // 0x90
		[SerializeField]
		private float _OuterColumnScaleInYScale; // 0x94
		[SerializeField]
		[Space]
		private float _OuterColumnAlphaInDuration; // 0x98
		[SerializeField]
		private float _OuterColumnFadeToBlackDuration; // 0x9C
		[SerializeField]
		private float _OuterColumnWaitBeforeAlphaOut; // 0xA0
		[SerializeField]
		private float _OuterColumnAlphaOutDuration; // 0xA4
		private Vector3 _innerColumnStartPosition; // 0xA8
		private Vector3 _innerColumnStartScale; // 0xB4
		private Color _outerColumnStartColour; // 0xC0
		private const string GradientSpriteName = "Gradient2"; // Metadata: 0x01976C49
		private const string VfxTextureName = "vfx"; // Metadata: 0x01976C53
	
		// Nested types
		public enum TeleportPosition // TypeDefIndex: 13962
		{
			Throne = 0,
			Foreground = 1
		}
	
		// Constructors
		public DraculaCutsceneTeleport() {} // 0x000000018697BDF0-0x000000018697BE80
	
		// Methods
		private void Start() {} // 0x000000018697ACC0-0x000000018697B020
		protected override void OnDestroy() {} // 0x00000001827DC690-0x00000001827DC730
		private void Reset() {} // 0x000000018697B020-0x000000018697B390
		public void PlayTeleportEffect(TeleportPosition position, Action onFadeToBlackComplete, Action onComplete) {} // 0x000000018697B390-0x000000018697B990
		[IteratorStateMachine(typeof(_InnerColumnCoroutine_d__28))]
		private IEnumerator InnerColumnCoroutine(Action onScaleInComplete) => default; // 0x000000018697B990-0x000000018697BA90
		[IteratorStateMachine(typeof(_OuterColumnCoroutine_d__29))]
		private IEnumerator OuterColumnCoroutine(Action onFadeToBlackComplete, Action onComplete) => default; // 0x000000018697BA90-0x000000018697BBF0
		[IteratorStateMachine(typeof(_ScaleTransform_d__30))]
		private IEnumerator ScaleTransform(Transform transformToScale, Vector3 startScale, Vector3 endScale, float duration) => default; // 0x000000018697BBF0-0x000000018697BCD0
		[IteratorStateMachine(typeof(_ColourTween_d__31))]
		private IEnumerator ColourTween(SpriteRenderer spriteRenderer, Color startColour, Color endColour, float duration) => default; // 0x000000018697BCD0-0x000000018697BDA0
		[IteratorStateMachine(typeof(_WaitForSecondsPausable_d__32))]
		private IEnumerator WaitForSecondsPausable(float seconds) => default; // 0x000000018697BDA0-0x000000018697BDF0
	}
}
