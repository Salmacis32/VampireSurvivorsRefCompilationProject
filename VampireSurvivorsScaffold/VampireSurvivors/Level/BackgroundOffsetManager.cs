/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Level
{
	public class BackgroundOffsetManager : GameMonoBehaviour // TypeDefIndex: 14515
	{
		// Fields
		[SerializeField]
		private float _edgeOffset; // 0x28
		private Camera _mainCamera; // 0x30
		private Bounds _backgroundBounds; // 0x38
		private Bounds _camBounds; // 0x50
	
		// Constructors
		public BackgroundOffsetManager() {} // 0x0000000186F119D0-0x0000000186F11A20
	
		// Methods
		private new void Awake() {} // 0x0000000187053290-0x0000000187053300
		private void Start() {} // 0x0000000187053300-0x0000000187053310
		protected override void OnEnable() {} // 0x0000000187053310-0x0000000187053330
		protected override void OnUpdate() {} // 0x0000000187053330-0x0000000187053340
		private void OnDrawGizmosSelected() {} // 0x0000000187053340-0x0000000187053660
		private void CalculateBounds() {} // 0x0000000187053660-0x00000001870537A0
		private void OffsetBackgroundTiles() {} // 0x00000001870537A0-0x0000000187053BB0
	}
}
