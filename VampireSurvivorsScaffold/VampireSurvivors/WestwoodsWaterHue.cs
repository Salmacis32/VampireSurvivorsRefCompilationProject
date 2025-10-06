/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Graphics;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class WestwoodsWaterHue : MonoBehaviour // TypeDefIndex: 13974
	{
		// Fields
		[SerializeField]
		private Gradient _introHueGradient; // 0x20
		[SerializeField]
		private float _introHueIncrease; // 0x28
		[SerializeField]
		private float _introDuration; // 0x2C
		[SerializeField]
		private float _introHueChangeDuration; // 0x30
		[SerializeField]
		private float _hueChangeTransitionTime; // 0x34
		private TileSprite _waterTileSprite; // 0x38
		private HueChangeState _currentHueChangeState; // 0x40
		private float _hueTimer; // 0x44
		private float _hueChangeTimer; // 0x48
		private int _currentHueChangeIndex; // 0x4C
		private bool _transitioning; // 0x50
		private float _transitionTimer; // 0x54
		private Color _transitionStartColour; // 0x58
		[Header("Looping colour changes")]
		[SerializeField]
		private WestwoodsHueChange[] _hueChanges; // 0x68
	
		// Nested types
		private enum HueChangeState // TypeDefIndex: 13972
		{
			Intro = 0,
			Loop = 1
		}
	
		[Serializable]
		private struct WestwoodsHueChange // TypeDefIndex: 13973
		{
			// Fields
			public Gradient HueChangeOverTime; // 0x00
			[Tooltip("How long does this section of the sequence last for in total before going to the next hue change in the list")]
			public float Duration; // 0x08
			[Tooltip("How long is a single loop of this colour gradient")]
			public float HueLoopDuration; // 0x0C
		}
	
		// Constructors
		public WestwoodsWaterHue() {} // 0x000000018697F260-0x000000018697F2C0
	
		// Methods
		public void SetWaterTileSprite(TileSprite waterTileSprite) {} // 0x0000000181953C20-0x0000000181953C80
		private void Update() {} // 0x000000018697EB10-0x000000018697F260
	}
}
