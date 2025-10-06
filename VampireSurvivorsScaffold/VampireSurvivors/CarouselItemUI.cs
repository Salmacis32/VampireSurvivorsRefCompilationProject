/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class CarouselItemUI : MonoBehaviour // TypeDefIndex: 14187
	{
		// Fields
		protected CanvasGroup _cg; // 0x20
		protected float _maxDistance; // 0x28
		protected float _minAlpha; // 0x2C
		protected float _minScale; // 0x30
		protected RectTransform _mTrans; // 0x38
		protected RectTransform _tTrans; // 0x40
		protected float _progress; // 0x48
		protected RectTransform _target; // 0x50
		private Tween _moveTween; // 0x58
		private Tween _scaleTween; // 0x60
	
		// Constructors
		public CarouselItemUI() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		public virtual void Initialize(float maxDistance) {} // 0x0000000186DAA1F0-0x0000000186DAA4E0
		private void OnDestroy() {} // 0x0000000186DAA4E0-0x0000000186DAA530
		private void KillAllTweens() {} // 0x0000000186DAA4E0-0x0000000186DAA530
		public Tween SetTarget(Transform t, bool completeImmediately = false /* Metadata: 0x01977053 */) => default; // 0x0000000186DAA530-0x0000000186DAA970
		private void Update() {} // 0x0000000186DAA970-0x0000000186DAA9F0
		protected virtual void ApplyProgress() {} // 0x0000000180B15170-0x0000000180B15180
		public virtual void Deselect(bool completeImmediately = false /* Metadata: 0x01977054 */) {} // 0x0000000180B15170-0x0000000180B15180
		public virtual void Select(bool completeImmediately = false /* Metadata: 0x01977055 */) {} // 0x0000000180B15170-0x0000000180B15180
	}
}
