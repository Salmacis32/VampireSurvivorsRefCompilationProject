/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class UICamera : MonoBehaviour // TypeDefIndex: 14252
	{
		// Fields
		private Camera _camera; // 0x20
		private Camera _main; // 0x28
		public static Camera _cameraUI; // 0x00
		private static float _defaultSize; // 0x08
	
		// Properties
		public static float ParticleScaleFactor { get => default; } // 0x0000000186F0EE40-0x0000000186F0EF20 
	
		// Constructors
		public UICamera() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		private void Start() {} // 0x0000000186F0EF20-0x0000000186F0F140
		[IteratorStateMachine(typeof(_WaitAndCacheDefaultOrtoSize_d__7))]
		private IEnumerator WaitAndCacheDefaultOrtoSize() => default; // 0x0000000186F0F140-0x0000000186F0F1E0
		private void Update() {} // 0x0000000186F0F1E0-0x0000000186F0F2A0
		public static Vector3 UIToGame(Vector3 worldPos) => default; // 0x0000000186F0F2A0-0x0000000186F0F640
	}
}
