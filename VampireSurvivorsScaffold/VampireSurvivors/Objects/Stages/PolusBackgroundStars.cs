/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	public class PolusBackgroundStars : GameMonoBehaviour // TypeDefIndex: 15350
	{
		// Fields
		[SerializeField]
		private Vector2 _DefaultPosition; // 0x28
		[SerializeField]
		private Vector2 _InversePosition; // 0x30
		[SerializeField]
		private Material _DefaultStarsMaterial; // 0x38
		[SerializeField]
		private Material _InvertedStarsMaterial; // 0x40
		private SpriteRenderer _starsRenderer; // 0x48
	
		// Properties
		private SpriteRenderer StarsRenderer { get => default; } // 0x0000000186B92C10-0x0000000186B92D50 
	
		// Constructors
		public PolusBackgroundStars() {} // 0x0000000184C44C90-0x0000000184C44CE0
	
		// Methods
		protected override void OnEnable() {} // 0x0000000186B92D50-0x0000000186B92E30
		protected override void OnDisable() {} // 0x0000000186B92E30-0x0000000186B92F10
		private void OnGameInitialized() {} // 0x0000000186B92F10-0x0000000186B93300
	}
}
