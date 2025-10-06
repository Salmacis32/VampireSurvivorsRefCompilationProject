/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using QFSW.MOP2;
using UnityEngine;
using UnityEngine.Serialization;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.VFX
{
	public class GrenadeVFX : PoolableMonoBehaviour // TypeDefIndex: 15186
	{
		// Fields
		[FormerlySerializedAs("_screenFillRenderer")]
		[SerializeField]
		private SpriteRenderer _ScreenFillRenderer; // 0x30
		[FormerlySerializedAs("_burstAnimation")]
		[SerializeField]
		private SpriteAnimation _BurstAnimation; // 0x38
		private VampireSurvivors.Framework.TimerSystem.Timer _timer; // 0x40
		private Transform _originalParent; // 0x48
		private List<PhaserSprite> explosionSprites; // 0x50
	
		// Constructors
		public GrenadeVFX() {} // 0x0000000184C44C90-0x0000000184C44CE0
	
		// Methods
		private new void Awake() {} // 0x0000000186A80440-0x0000000186A809B0
		public void SetParent(Transform newParent) {} // 0x0000000186A809B0-0x0000000186A80A60
		public void Play(float volume = 1.8f /* Metadata: 0x01977449 */) {} // 0x0000000186A80A60-0x0000000186A81840
		private void Cleanup() {} // 0x0000000186A81840-0x0000000186A818B0
		private void SetupScreenFill() {} // 0x0000000186A818B0-0x0000000186A81E30
		private void SetupBurstAnim() {} // 0x0000000186A81E30-0x0000000186A81E50
		private void ResetParent() {} // 0x0000000186A81E50-0x0000000186A81E90
	}
}
