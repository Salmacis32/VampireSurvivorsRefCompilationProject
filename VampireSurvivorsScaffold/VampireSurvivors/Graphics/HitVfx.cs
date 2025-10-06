/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Serialization;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Graphics
{
	public class HitVfx : GameMonoBehaviour // TypeDefIndex: 14524
	{
		// Fields
		[FormerlySerializedAs("Hit")]
		[SerializeField]
		private SpriteRenderer _Hit; // 0x28
		[FormerlySerializedAs("Impact")]
		[SerializeField]
		private SpriteRenderer _Impact; // 0x30
		private Vector3 _baseHitScale; // 0x38
		private Vector3 _baseImpactScale; // 0x44
		private Vector3 _targetHitScale; // 0x50
		private Vector3 _targetImpactScale; // 0x5C
		private Transform _hitTransform; // 0x68
		private Transform _impactTransform; // 0x70
		private Vector3 _targetRotation; // 0x78
		private HitVFXData _data; // 0x88
		private DG.Tweening.Sequence _tweens; // 0x90
		private bool _tweensInitialised; // 0x98
		private Sprite _defaultHitSprite; // 0xA0
		private Sprite _defaultImpactSprite; // 0xA8
		private Tween _doTween1; // 0xB0
		private Tween _doTween2; // 0xB8
		private Tween _doTween3; // 0xC0
	
		// Constructors
		public HitVfx() {} // 0x00000001870575A0-0x0000000187057610
	
		// Methods
		public new void Awake() {} // 0x0000000187056600-0x0000000187056BE0
		private void CacheDefaultSprites() {} // 0x0000000187056BE0-0x0000000187056D50
		private void Start() {} // 0x0000000187056D50-0x0000000187056DA0
		public void Play(Vector2 pos, HitVFXData data) {} // 0x0000000187056DA0-0x0000000187056F30
		private void SetData() {} // 0x0000000187056F30-0x0000000187056F90
		private void PlayAnim() {} // 0x0000000187056F90-0x00000001870574D0
		private void Despawn() {} // 0x00000001870574D0-0x00000001870575A0
	}
}
