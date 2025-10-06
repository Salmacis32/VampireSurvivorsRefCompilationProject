/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_RapierProjectile_MegaSingle : Projectile // TypeDefIndex: 15838
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _backgroundSprite; // 0xD0
		private const float RADIUS = 8f; // Metadata: 0x019778E0
		private const float INDEX_OFFSET_SCALE_FACTOR = 0.1f; // Metadata: 0x019778E4
		private ParticleEmitterManager _pfxManager; // 0xD8
		private ParticleSystem _pfx; // 0xE0
		private MultiTargetTween _tween; // 0xE8
		private MultiTargetTween _tween2; // 0xF0
		private readonly List<uint> _tints; // 0xF8
		private readonly List<string> _frameNames; // 0x100
	
		// Constructors
		public EME_RapierProjectile_MegaSingle() {} // 0x0000000186DE2780-0x0000000186DE2C50
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DE0D50-0x0000000186DE1E30
		private void GenerateParticleSystem() {} // 0x0000000186DE1E30-0x0000000186DE26F0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186DE26F0-0x0000000186DE2780
	}
}
