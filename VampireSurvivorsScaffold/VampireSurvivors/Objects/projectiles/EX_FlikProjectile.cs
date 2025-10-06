/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EX_FlikProjectile : Projectile // TypeDefIndex: 15861
	{
		// Fields
		private MultiTargetTween _scaleTween; // 0xD0
		private MultiTargetTween _alphaTween; // 0xD8
		private MultiTargetTween _animTween; // 0xE0
		private SpriteAnimation _anims; // 0xE8
		private Transform _cachedSpriteTransform; // 0xF0
		private Vector2 _collisionPos; // 0xF8
		private Vector2 _spritePos; // 0x100
		private float physArea; // 0x108
		public float _life; // 0x10C
		private ParticleEmitterManager _pfxEmitterManager; // 0x110
		private ParticleSystem _pfxEmitter; // 0x118
		[SerializeField]
		private SpriteRenderer _lanceSprite; // 0x120
		private MultiTargetTween _tween3; // 0x128
		private bool _initialisedParticles; // 0x130
	
		// Constructors
		public EX_FlikProjectile() {} // 0x0000000186DF83E0-0x0000000186DF8440
	
		// Methods
		protected override void Awake() {} // 0x0000000186DF68E0-0x0000000186DF6A10
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DF6A10-0x0000000186DF75B0
		private void OnRecycle() {} // 0x0000000186DF75B0-0x0000000186DF8120
		public override void Despawn() {} // 0x0000000186DF8120-0x0000000186DF81F0
		public override void InternalUpdate() {} // 0x0000000186DF81F0-0x0000000186DF83E0
	}
}
