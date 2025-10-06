/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class UIPositionHelper : MonoBehaviour // TypeDefIndex: 13975
	{
		// Fields
		[SerializeField]
		private bool _ShowDebug; // 0x20
		[SerializeField]
		private RectTransform _PositionHelperTarget; // 0x28
		private GameObject UITarget; // 0x30
		private GameObject WorldTarget; // 0x38
		private Canvas _canvas; // 0x40
		private static UIPositionHelper Instance; // 0x00
		[SerializeField]
		private RectTransform rTrans; // 0x48
	
		// Constructors
		public UIPositionHelper() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		private void Awake() {} // 0x000000018697F2C0-0x000000018697F360
		private void Start() {} // 0x000000018697F360-0x000000018697F660
		private void Update() {} // 0x000000018697F660-0x000000018697F750
		public static Vector3 GetWorldPosition(Vector2 pos) => default; // 0x000000018697F750-0x000000018697F860
		public static Vector3 GetWorldPositionFromUIElement(RectTransform rTransform) => default; // 0x000000018697F860-0x000000018697FCD0
		public static float GetYPositionFromScreenPosition(float screenPosY) => default; // 0x000000018697FCD0-0x000000018697FE30
		public static float GetXPositionFromScreenPosition(float screenPosX) => default; // 0x000000018697FE30-0x000000018697FF90
		public static float ScreenWidth() => default; // 0x000000018697FF90-0x0000000186980020
		public static float ScreenHeight() => default; // 0x0000000186980020-0x00000001869800B0
	}
}
