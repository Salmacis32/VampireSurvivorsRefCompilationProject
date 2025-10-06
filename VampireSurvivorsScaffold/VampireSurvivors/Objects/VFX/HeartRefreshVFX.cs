/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using QFSW.MOP2;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.VFX
{
	public class HeartRefreshVFX : PoolableMonoBehaviour // TypeDefIndex: 15187
	{
		// Fields
		public MeshRenderer _banner; // 0x30
		public ParticleSystem _flash; // 0x38
		public ParticleSystem _HeartVfx; // 0x40
		public float _animT; // 0x48
		private MultiTargetTween _tween; // 0x50
		private VampireSurvivors.Framework.TimerSystem.Timer _flashTimer; // 0x58
	
		// Constructors
		public HeartRefreshVFX() {} // 0x0000000184C44C90-0x0000000184C44CE0
	
		// Methods
		private void Start() {} // 0x0000000186A81EC0-0x0000000186A82240
		public void PlaySequence() {} // 0x0000000186A82240-0x0000000186A82730
		protected override void OnDestroy() {} // 0x0000000186A82730-0x0000000186A82770
	}
}
