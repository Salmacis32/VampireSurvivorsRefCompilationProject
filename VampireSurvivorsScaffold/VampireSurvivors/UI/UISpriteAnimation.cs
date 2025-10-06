/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class UISpriteAnimation : MonoBehaviour // TypeDefIndex: 15046
	{
		// Fields
		[SerializeField]
		private int FPS; // 0x20
		[SerializeField]
		private bool PlayManually; // 0x24
		[SerializeField]
		private bool _UseCustomScaleTween; // 0x25
		[SerializeField]
		private bool _UseCustomPositionTween; // 0x26
		[SerializeField]
		private bool _ScaleBasedOnSpriteSize; // 0x27
		[SerializeField]
		private bool _hideWhenDone; // 0x28
		public bool _FreezeOnLastFrame; // 0x29
		public Action OnComplete; // 0x30
		[SerializeField]
		private Vector3 _StartScale; // 0x38
		[SerializeField]
		private Vector3 _EndScale; // 0x44
		[SerializeField]
		private Vector2 _StartPos; // 0x50
		[SerializeField]
		private Vector2 _EndPos; // 0x58
		[FormerlySerializedAs("Sprites")]
		public List<Sprite> sprites; // 0x60
		private RectTransform _rTrans; // 0x68
		private Image _image; // 0x70
		private float _currentTimer; // 0x78
		private float _triggerTimer; // 0x7C
		private int _index; // 0x80
		private bool _isPlayingManually; // 0x84
		private Action _onComplete; // 0x88
		public bool ScaleBasedOnSpriteSizeWithoutMagic; // 0x91
	
		// Properties
		public bool IsPaused { get; set; } // 0x00000001819643B0-0x00000001819643C0 0x00000001826FAF20-0x00000001826FAF30
	
		// Constructors
		public UISpriteAnimation() {} // 0x00000001869CD6E0-0x00000001869CD7E0
	
		// Methods
		private void Awake() {} // 0x00000001869CCB10-0x00000001869CCC50
		private void Update() {} // 0x00000001869CCC50-0x00000001869CCFB0
		public void Play(bool hideWhenDone = false /* Metadata: 0x01977286 */, float startTimer = 0f /* Metadata: 0x01977287 */) {} // 0x00000001869CCFB0-0x00000001869CD140
		private void RefreshScale() {} // 0x00000001869CD140-0x00000001869CD4F0
		public void SetScaleBasedOnSpriteSize(bool b) {} // 0x0000000184BA5720-0x0000000184BA5730
		public void SetCallback(Action cb) {} // 0x00000001819A03F0-0x00000001819A0450
		public void SetFPS(int fps) {} // 0x0000000181962000-0x0000000181962010
		public void RecalculateTriggerTime() {} // 0x00000001869CD4F0-0x00000001869CD510
		public void Reset() {} // 0x00000001869CD510-0x00000001869CD5A0
		public void Clean() {} // 0x00000001869CD5A0-0x00000001869CD610
		public void ResetScale() {} // 0x00000001869CD610-0x00000001869CD6E0
	}
}
