/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class LuminaireWeapon : Weapon // TypeDefIndex: 16165
	{
		// Fields
		private List<PhaserSprite> _doilies; // 0x158
		private ParticleEmitterManager _particlesManager; // 0x160
		private ParticleSystem _pfxEmitter; // 0x168
		private Rectangle _rectangle; // 0x170
		private List<string> _frames; // 0x178
		private float _firingCounter; // 0x180
		private bool _isInitialised; // 0x184
		private uint[] _colors; // 0x188
		[NonSerialized]
		public float FiredTimes; // 0x190
		[NonSerialized]
		public ArcanaType FirstArcana; // 0x194
	
		// Constructors
		public LuminaireWeapon() {} // 0x0000000186F38E60-0x0000000186F39170
	
		// Methods
		protected override void OnStart() {} // 0x0000000186F36930-0x0000000186F36B00
		protected override void OnUpdate() {} // 0x0000000186F36B00-0x0000000186F38100
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977B9F */) {} // 0x0000000186F38100-0x0000000186F386E0
		public override void CheckArcanas() {} // 0x0000000186F386E0-0x0000000186F38A10
		public override void Cleanup() {} // 0x0000000186F38A10-0x0000000186F38C30
		public override void SetVisible(bool visible) {} // 0x0000000186F38C30-0x0000000186F38E60
	}
}
