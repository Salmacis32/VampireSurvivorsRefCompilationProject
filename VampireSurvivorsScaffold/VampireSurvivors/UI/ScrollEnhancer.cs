/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class ScrollEnhancer : MonoBehaviour // TypeDefIndex: 14954
	{
		// Fields
		[SerializeField]
		private bool _DEBUGTHIS; // 0x20
		[SerializeField]
		private bool _AutoInitialize; // 0x21
		[SerializeField]
		private bool _HideSliderWhenNotNeeded; // 0x22
		public bool RequiresMouseOverForScroll; // 0x23
		[SerializeField]
		private float _scrollSpeed; // 0x24
		[SerializeField]
		private RectTransform _scroll; // 0x28
		[SerializeField]
		private RectTransform _content; // 0x30
		[SerializeField]
		private Scrollbar _scrollbar; // 0x38
		[SerializeField]
		private Slider _Slider; // 0x40
		[SerializeField]
		private float _OffsetWhenSliderShown; // 0x48
		private GameObject _previouslySelected; // 0x50
		private Vector3 _baseScrollViewPosition; // 0x58
	
		// Constructors
		public ScrollEnhancer() {} // 0x0000000186950200-0x00000001869502A0
	
		// Methods
		private void Awake() {} // 0x000000018694EBD0-0x000000018694EC10
		private void Update() {} // 0x000000018694EC10-0x000000018694F0B0
		public void Initialize(float scrollSpeed, RectTransform content, Scrollbar scrollbar, Slider slider, float offset) {} // 0x000000018694F0B0-0x000000018694F3F0
		protected void OnSliderDrag(float val) {} // 0x000000018694F3F0-0x000000018694F420
		public void ForceScrollAlignment() {} // 0x000000018694F420-0x000000018694F660
		public void LogOnValueChange(float val) {} // 0x000000018694F660-0x000000018694F730
		public void SetScrollbarActive(bool on) {} // 0x000000018694F730-0x000000018694F840
		protected void ScrollWithSelection(RectTransform _scrollRect, RectTransform _content) {} // 0x000000018694F840-0x0000000186950200
	}
}
