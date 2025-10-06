/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class AspectMask : MonoBehaviour // TypeDefIndex: 14691
	{
		// Fields
		[SerializeField]
		private RectTransform _Top; // 0x20
		[SerializeField]
		private RectTransform _Bottom; // 0x28
		[SerializeField]
		private RectTransform _Left; // 0x30
		[SerializeField]
		private RectTransform _Right; // 0x38
		[SerializeField]
		private Canvas _Canvas; // 0x40
		private RectTransform _rectTransform; // 0x48
		private AspectRatioFitter _fitter; // 0x50
		private int _prevWidth; // 0x58
		private int _prevHeight; // 0x5C
	
		// Properties
		public static AspectMask Instance { get; private set; } // 0x0000000186792890-0x00000001867928D0 0x00000001867928D0-0x0000000186792970
		public RectTransform Top { get => default; } // 0x0000000180B15530-0x0000000180B15540 
		public RectTransform Bottom { get => default; } // 0x0000000180B15540-0x0000000180B15550 
		public RectTransform Left { get => default; } // 0x0000000180B15550-0x0000000180B15560 
		public RectTransform Right { get => default; } // 0x0000000180B15560-0x0000000180B15570 
	
		// Constructors
		public AspectMask() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		private void Awake() {} // 0x0000000186792970-0x0000000186792C70
		public void Enable() {} // 0x0000000186792C70-0x0000000186792CD0
		public void Disable() {} // 0x0000000186792CD0-0x0000000186792D30
		private void SetImageEnabled(RectTransform obj, bool isEnabled) {} // 0x0000000186792D30-0x0000000186792E40
		private void Start() {} // 0x0000000186792E40-0x0000000186792F00
		private void Update() {} // 0x0000000186792F00-0x0000000186793040
		private void OnResize() {} // 0x0000000186793040-0x0000000186793400
		private void SetImageAlpha(Image image, float alpha) {} // 0x0000000186793400-0x0000000186793490
		[IteratorStateMachine(typeof(_Wait_d__29))]
		private IEnumerator Wait() => default; // 0x0000000186793490-0x0000000186793530
		private void CalculateHeight() {} // 0x0000000186793530-0x0000000186793760
		private void CalculateWidth() {} // 0x0000000186793760-0x00000001867938F0
	}
}
