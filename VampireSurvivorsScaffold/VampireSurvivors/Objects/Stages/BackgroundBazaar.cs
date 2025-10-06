/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.TimerSystem;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	public class BackgroundBazaar : BackgroundManager // TypeDefIndex: 15250
	{
		// Fields
		private float _colorBgValue; // 0x80
		private Transform _spritesRootTransform; // 0x88
		private List<PhaserSprite> _windows; // 0x90
		private VampireSurvivors.Framework.TimerSystem.Timer _colorBgTimer; // 0x98
		private ParticleEmitterManager _pfxEmitter; // 0xA0
		private ParticleSystem _pfxFire1; // 0xA8
		private ParticleSystem _pfxFire2; // 0xB0
	
		// Constructors
		public BackgroundBazaar() {} // 0x0000000186B009A0-0x0000000186B00A70
	
		// Methods
		protected override void OnDestroy() {} // 0x0000000186AFE290-0x0000000186AFE310
		protected override void OnUpdate() {} // 0x0000000186AFE310-0x0000000186AFE870
		public override void Create() {} // 0x0000000186AFE870-0x0000000186AFED40
		public override void OnInitCompleted() {} // 0x0000000186AFED40-0x0000000186AFEDE0
		private void SnapEggs() {} // 0x0000000186AFEDE0-0x0000000186AFEE80
		private void MakeFireEmitters() {} // 0x0000000186AFEE80-0x0000000186B001C0
		private void MakeWindows() {} // 0x0000000186B001C0-0x0000000186B009A0
	}
}
