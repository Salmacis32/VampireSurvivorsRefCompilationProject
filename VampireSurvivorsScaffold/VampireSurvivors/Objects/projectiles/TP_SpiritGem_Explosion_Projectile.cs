/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_SpiritGem_Explosion_Projectile : Projectile // TypeDefIndex: 15672
	{
		// Fields
		private ParticleEmitterManager _particlesManager; // 0xD0
		private ParticleSystem _pfxEmitter; // 0xD8
		private ParticleSystem _pfxEmitter2; // 0xE0
		private uint[] _onEmitCustomTint; // 0xE8
		private SpriteRenderer _windowVfx; // 0xF0
		private SpriteAnimation _windowVfxAnimation; // 0xF8
		private SpriteRenderer _exploSprite; // 0x100
		private Tween _scaleTween; // 0x108
		private MultiTargetTween _scaleTween2; // 0x110
		private const float ExplosionDuration = 500f; // Metadata: 0x019777A7
		private Transform _cachedRendererTransform; // 0x118
	
		// Constructors
		public TP_SpiritGem_Explosion_Projectile() {} // 0x0000000186D20E40-0x0000000186D20F30
	
		// Methods
		protected override void Awake() {} // 0x0000000186D1E780-0x0000000186D203C0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D203C0-0x0000000186D20DF0
		public override void Despawn() {} // 0x0000000186D20DF0-0x0000000186D20E40
	}
}
