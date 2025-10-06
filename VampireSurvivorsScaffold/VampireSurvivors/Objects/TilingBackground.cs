/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Graphics;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects
{
	public class TilingBackground : GameMonoBehaviour // TypeDefIndex: 15160
	{
		// Fields
		private Stage _stage; // 0x28
		private Vector2 _initialOffset; // 0x30
		private float _timeOffset; // 0x38
		private bool _canScroll; // 0x3C
		private TileSprite _bgtile; // 0x40
		private Color _dayColor; // 0x48
		private Color _nightColor; // 0x58
		private float _yMul; // 0x68
		private const float DayCycleDuration = 900f; // Metadata: 0x01977423
	
		// Properties
		public TileSprite bgtile { get => default; } // 0x0000000180B15750-0x0000000180B15760 
		public bool RunTimeHue { get; set; } // 0x0000000185267770-0x0000000185267780 0x00000001864C3E40-0x00000001864C3E50
	
		// Constructors
		public TilingBackground() {} // 0x0000000186A60750-0x0000000186A608A0
	
		// Methods
		public void Init(Stage stage) {} // 0x0000000186A5F850-0x0000000186A5FFD0
		private void LateUpdate() {} // 0x0000000186A5FFD0-0x0000000186A5FFE0
		public void DayNightHue() {} // 0x0000000186A5FFE0-0x0000000186A601E0
		public void SetBackgroundTilesTint(Color color) {} // 0x0000000186A601E0-0x0000000186A60290
		public void SetVisible(bool visible) {} // 0x0000000186A60290-0x0000000186A602C0
		public void ToggleScrolling(bool value) {} // 0x0000000183A3E000-0x0000000183A3E010
		public void ResetAndStopDayNightHue() {} // 0x0000000186A602C0-0x0000000186A60380
		private void ProcessTiling() {} // 0x0000000186A60380-0x0000000186A60750
	}
}
