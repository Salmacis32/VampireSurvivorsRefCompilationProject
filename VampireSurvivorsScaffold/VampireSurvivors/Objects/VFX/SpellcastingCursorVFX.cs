/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using QFSW.MOP2;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.VFX
{
	public class SpellcastingCursorVFX : PoolableMonoBehaviour // TypeDefIndex: 15195
	{
		// Fields
		private Transform _originalParent; // 0x30
		private PhaserSprite _cursor; // 0x38
		private MultiTargetTween _cursorTween; // 0x40
		private PhaserSprite _cursorAdd; // 0x48
		private MultiTargetTween _cursorAddTween; // 0x50
	
		// Constructors
		public SpellcastingCursorVFX() {} // 0x0000000184C44C90-0x0000000184C44CE0
	
		// Methods
		private new void Awake() {} // 0x0000000186A89470-0x0000000186A89770
		public void SetParent(Transform newParent) {} // 0x0000000186A89770-0x0000000186A89820
		public void Display(int _times, float _duration, Vector3 position, float angle, string texture, string frame, bool flip = false /* Metadata: 0x01977456 */) {} // 0x0000000186A89820-0x0000000186A8A0B0
		private void StartDespawn() {} // 0x0000000186A8A0B0-0x0000000186A8A3B0
		private void Cleanup() {} // 0x0000000186A8A3B0-0x0000000186A8A460
		private void ResetParent() {} // 0x0000000186A8A460-0x0000000186A8A4A0
	}
}
