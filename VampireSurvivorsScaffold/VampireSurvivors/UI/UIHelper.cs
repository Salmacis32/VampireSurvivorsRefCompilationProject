/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class UIHelper : MonoBehaviour // TypeDefIndex: 15045
	{
		// Fields
		[SerializeField]
		private bool _ForceAspectRatio; // 0x20
		[SerializeField]
		private RectTransform _SafeArea; // 0x28
		[SerializeField]
		private RectTransform _AspectMask; // 0x30
		[SerializeField]
		private bool _DisablePixelPerfectOnLowEndDevices; // 0x38
		private Vector3 _prevMousePos; // 0x3C
		private ActiveInputType _prevInput; // 0x48
		private Canvas _canvas; // 0x50
		private ActiveInputType _currentInput; // 0x58
		private static UIHelper Instance; // 0x08
		private static float _scaleFactor; // 0x10
		public static float JS_MAGIC_SCALE_NUMBER; // 0x14
	
		// Properties
		public static Canvas Canvas { get => default; } // 0x00000001869CACE0-0x00000001869CAE10 
		public static ActiveInputType ActiveInput { get => default; } // 0x00000001869CAE10-0x00000001869CAF40 
		public static float ScaleFactor { get => default; } // 0x00000001869CAF40-0x00000001869CB170 
		public static float ScreenHeight { get => default; } // 0x00000001869CB170-0x00000001869CB340 
		public static float SafeScreenHeight { get => default; } // 0x00000001869CB340-0x00000001869CB520 
		public static float SafeScreenWidth { get => default; } // 0x00000001869CB520-0x00000001869CB700 
		public static bool IsPortrait { get => default; } // 0x00000001869CB700-0x00000001869CB840 
		public static bool IsPortraitAndMobile { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		public static float ScreenWidth { get => default; } // 0x00000001869CB840-0x00000001869CBA10 
		public static Vector2 SafeArea { get => default; } // 0x00000001869CBC00-0x00000001869CBED0 
		public static float AspectRatio { get => default; } // 0x0000000184E0A9C0-0x0000000184E0AA70 
	
		// Events
		public static event OnInputMethodChanged InputMethodChanged;
	
		// Nested types
		public delegate void OnInputMethodChanged(ActiveInputType newInput); // TypeDefIndex: 15043; 0x000000018196C5F0-0x000000018196C600
	
		public enum ActiveInputType // TypeDefIndex: 15044
		{
			VOID = 0,
			MOUSE = 1,
			KEYBOARD = 2,
			CONTROLLER = 3
		}
	
		// Constructors
		public UIHelper() {} // 0x00000001869CC9A0-0x00000001869CCA30
		static UIHelper() {} // 0x00000001869CCA30-0x00000001869CCA90
	
		// Methods
		public static float GetAspectLockedWidth() => default; // 0x00000001869CBA10-0x00000001869CBC00
		public static RectTransform GetSafeAreaObject() => default; // 0x00000001869CBED0-0x00000001869CBF40
		private void Awake() {} // 0x00000001869CBF40-0x00000001869CC090
		private void Update() {} // 0x00000001869CC090-0x00000001869CC600
		private void OnDestroy() {} // 0x00000001869CC600-0x00000001869CC7D0
		private void SetUpLandscape() {} // 0x00000001869CC7D0-0x00000001869CC9A0
	}
}
