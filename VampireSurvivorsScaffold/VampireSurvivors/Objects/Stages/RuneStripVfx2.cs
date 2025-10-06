/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Tools;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	public class RuneStripVfx2 : GameMonoBehaviour // TypeDefIndex: 15355
	{
		// Fields
		private float _heightAlpha; // 0x28
		private float _alpha; // 0x2C
		private List<RuneText> _followers; // 0x30
		private PhaserSpline _runeSpline; // 0x38
		private Tween _alphaTween; // 0x40
		private Transform _cachedTransform; // 0x48
		private GameObject _runeTextPrefab; // 0x50
	
		// Properties
		private Camera MainCam { get => default; } // 0x000000018678FD00-0x000000018678FD10 
		private Bounds CamBounds { get => default; } // 0x0000000186B95110-0x0000000186B95190 
	
		// Constructors
		public RuneStripVfx2() {} // 0x0000000186B968D0-0x0000000186B969D0
	
		// Methods
		public static RuneStripVfx2 Create(float x, float durationMillis, int flip = 1 /* Metadata: 0x019775B0 */, float alphaStart = 1f /* Metadata: 0x019775B1 */, float alphaEnd = 0.5f /* Metadata: 0x019775B5 */) => default; // 0x0000000186B95190-0x0000000186B952D0
		public void InternalUpdate(float prop) {} // 0x0000000186B952D0-0x0000000186B956C0
		private void Init(float x, float durationMillis, int flip = 1 /* Metadata: 0x019775B9 */, float alphaStart = 1f /* Metadata: 0x019775BA */, float alphaEnd = 0.5f /* Metadata: 0x019775BE */) {} // 0x0000000186B956C0-0x0000000186B964F0
		private RuneText CreateRune(float x, float y, string text) => default; // 0x0000000186B964F0-0x0000000186B968D0
	}
}
