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
	public class RuneStripVfx : GameMonoBehaviour // TypeDefIndex: 15353
	{
		// Fields
		private float _heightAlpha; // 0x28
		private float _alpha; // 0x2C
		private List<Rune> _followers; // 0x30
		private PhaserSpline _runeSpline; // 0x38
		private Tween _alphaTween; // 0x40
		private Transform _cachedTransform; // 0x48
	
		// Properties
		private Camera MainCam { get => default; } // 0x000000018678FD00-0x000000018678FD10 
		private Bounds CamBounds { get => default; } // 0x0000000186B934E0-0x0000000186B93560 
	
		// Constructors
		public RuneStripVfx() {} // 0x0000000186B94FD0-0x0000000186B950D0
	
		// Methods
		public static RuneStripVfx Create(float x, float duration, int flip = 1 /* Metadata: 0x0197759E */, float alphaStart = 1f /* Metadata: 0x0197759F */, float alphaEnd = 0.5f /* Metadata: 0x019775A3 */) => default; // 0x0000000186B93560-0x0000000186B936A0
		public void InternalUpdate(float prop) {} // 0x0000000186B936A0-0x0000000186B93A20
		private void Init(float x, float duration, int flip = 1 /* Metadata: 0x019775A7 */, float alphaStart = 1f /* Metadata: 0x019775A8 */, float alphaEnd = 0.5f /* Metadata: 0x019775AC */) {} // 0x0000000186B93A20-0x0000000186B94DF0
		private Rune CreateRune(float x, float y) => default; // 0x0000000186B94DF0-0x0000000186B94FD0
	}
}
