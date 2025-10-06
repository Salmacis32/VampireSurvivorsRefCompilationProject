/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.Profiling;
using UnityEngine;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Scripts.Framework
{
	public class PixelFontManager : GameTickable, IInitializable, IDisposable // TypeDefIndex: 18674
	{
		// Fields
		private static Material _defaultMaterial; // 0x00
		private static int _fontSizePropId; // 0x08
		private static int _alphaCutoffBoostPropId; // 0x0C
		private static readonly ProfilerMarker MarkerOnTextChanged; // 0x10
		private static List<int> _ignoreOnce; // 0x18
		private static Dictionary<TextMeshProUGUI, TextCache> _textCache; // 0x20
		private static bool _dirty; // 0x28
		private static List<TextMeshProUGUI> _cacheToRemove; // 0x30
		private static int _tickCount; // 0x38
		private static PlayerOptions _playerOptions; // 0x40
	
		// Constructors
		public PixelFontManager() {} // 0x0000000180B15170-0x0000000180B15180
		static PixelFontManager() {} // 0x000000018681D1D0-0x000000018681D500
	
		// Methods
		[Inject]
		private void Construct(PlayerOptions playerOptions) {} // 0x000000018681B5C0-0x000000018681B680
		public void Initialize() {} // 0x000000018681B680-0x000000018681B810
		public void Dispose() {} // 0x000000018681B810-0x000000018681B860
		protected override void OnTick() {} // 0x000000018681B860-0x000000018681C070
		private static void TriggerListener() {} // 0x000000018681C070-0x000000018681C1A0
		public static void SetDirty(bool value) {} // 0x000000018681C1A0-0x000000018681C200
		public static void TurnOn() {} // 0x000000018681C200-0x000000018681C300
		public static void TurnOff() {} // 0x000000018681C300-0x000000018681C410
		private static void ForceApply() {} // 0x000000018681C410-0x000000018681C4F0
		public static void ClearCache() {} // 0x000000018681C4F0-0x000000018681C690
		[IteratorStateMachine(typeof(_DelayedForce_d__20))]
		private static IEnumerator DelayedForce() => default; // 0x000000018681C690-0x000000018681C6D0
		private static void ON_TEXT_CHANGED(UnityEngine.Object obj) {} // 0x000000018681C6D0-0x000000018681D1D0
	}
}
