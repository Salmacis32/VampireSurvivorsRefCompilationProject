/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using QFSW.MOP2;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.VFX
{
	public class SpinningIcosahedron : PoolableMonoBehaviour // TypeDefIndex: 15196
	{
		// Fields
		[SerializeField]
		private Transform _icosahedronTransform; // 0x30
		[SerializeField]
		private Transform _trailRendererTransform; // 0x38
		private Tween rotationTween; // 0x40
	
		// Constructors
		public SpinningIcosahedron() {} // 0x0000000184C44C90-0x0000000184C44CE0
	
		// Methods
		private new void Awake() {} // 0x0000000186A8A540-0x0000000186A8A6E0
		public void Reset() {} // 0x0000000186A8A6E0-0x0000000186A8A880
		public void ShrinkAndRecycle(float durationInSeconds = 0.25f /* Metadata: 0x01977457 */) {} // 0x0000000186A8A880-0x0000000186A8AB30
		private void Cleanup() {} // 0x0000000184E3DC10-0x0000000184E3DC80
	}
}
