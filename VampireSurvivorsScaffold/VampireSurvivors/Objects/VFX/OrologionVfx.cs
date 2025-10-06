/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using QFSW.MOP2;
using UnityEngine;
using UnityEngine.Serialization;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.VFX
{
	public class OrologionVfx : PoolableMonoBehaviour // TypeDefIndex: 15193
	{
		// Fields
		[FormerlySerializedAs("_screenFillRenderer")]
		[SerializeField]
		private SpriteRenderer _ScreenFillRenderer; // 0x30
		[FormerlySerializedAs("_shockwaveRenderer")]
		[SerializeField]
		private SpriteRenderer _ShockwaveRenderer; // 0x38
		private float _worldScreenHeight; // 0x40
		private float _worldScreenWidth; // 0x44
		private Transform _originalParent; // 0x48
	
		// Constructors
		public OrologionVfx() {} // 0x0000000184C44C90-0x0000000184C44CE0
	
		// Methods
		private new void Awake() {} // 0x0000000180B15170-0x0000000180B15180
		public void SetParent(Transform newParent) {} // 0x0000000186A809B0-0x0000000186A80A60
		public void Play() {} // 0x0000000186A86E90-0x0000000186A86F80
		private void Init() {} // 0x0000000186A86F80-0x0000000186A87550
		private void PerformScreenFill() {} // 0x0000000186A87550-0x0000000186A87D10
		private void PerformShockwave() {} // 0x0000000186A87D10-0x0000000186A88520
		private void Cleanup() {} // 0x0000000186A88520-0x0000000186A887B0
		private void ResetParent() {} // 0x0000000186A81E50-0x0000000186A81E90
	}
}
