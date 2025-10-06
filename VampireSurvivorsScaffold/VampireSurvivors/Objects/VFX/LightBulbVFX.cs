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

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.VFX
{
	public class LightBulbVFX : PoolableMonoBehaviour // TypeDefIndex: 15192
	{
		// Fields
		[FormerlySerializedAs("_screenFillRenderer")]
		[SerializeField]
		private SpriteRenderer _ScreenFillRenderer; // 0x30
		private VampireSurvivors.Framework.TimerSystem.Timer _timer; // 0x38
		private Transform _originalParent; // 0x40
		private PhaserSprite _StarSprite; // 0x48
		private PhaserSprite _BulbSprite; // 0x50
		private float _orthographicSize; // 0x58
		private PhaserText _techniqueNameText; // 0x60
		private PhaserSprite _techniqueNameBackground; // 0x68
		private List<Transform> _originalCameraTargets; // 0x70
	
		// Constructors
		public LightBulbVFX() {} // 0x0000000184C44C90-0x0000000184C44CE0
	
		// Methods
		private new void Awake() {} // 0x0000000186A84F30-0x0000000186A85250
		public void setDepth(int depth) {} // 0x0000000186A85250-0x0000000186A852F0
		public void SetParent(Transform newParent) {} // 0x0000000186A852F0-0x0000000186A85450
		public void Play(string techniqueName, float volume = 1.8f /* Metadata: 0x0197744D */) {} // 0x0000000186A85450-0x0000000186A85D20
		private void SetupTextBox(string techniqueName) {} // 0x0000000186A85D20-0x0000000186A86490
		public void EndEffect() {} // 0x0000000186A86490-0x0000000186A86750
		private void Cleanup() {} // 0x0000000186A86750-0x0000000186A867C0
		private void SetupScreenFill() {} // 0x0000000186A867C0-0x0000000186A86D40
		private void ResetParent() {} // 0x0000000186A86D40-0x0000000186A86D80
	}
}
