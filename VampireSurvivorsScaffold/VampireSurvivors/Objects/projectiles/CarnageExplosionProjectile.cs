/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class CarnageExplosionProjectile : Projectile // TypeDefIndex: 15404
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _ScreenSprite; // 0xD0
		[SerializeField]
		private SpriteAnimation _ScreenSpriteAnimation; // 0xD8
		private Tween _alphaTween; // 0xE0
		private Tween _despawnTween; // 0xE8
		private Tween _exploAlphaTween; // 0xF0
		private Tween _exploScaleTween; // 0xF8
		private Tween _colliderTween; // 0x100
		private Transform _cachedWeaponTransform; // 0x108
		private bool _particlesGenerated; // 0x110
		private ParticleEmitterManager _particlesManager; // 0x118
		private ParticleEmitterManager _particlesManagerLine; // 0x120
		private ParticleSystem _pfxEmitter; // 0x128
		private ParticleSystem _pfxEmitter2; // 0x130
		private GravityWell _well; // 0x138
		private float _totalTime; // 0x140
		private CarnageWeapon _trueWeapon; // 0x148
		private float _colliderRadius; // 0x150
	
		// Constructors
		public CarnageExplosionProjectile() {} // 0x0000000186BC8180-0x0000000186BC81E0
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BC5C80-0x0000000186BC5F90
		public override void InternalUpdate() {} // 0x0000000186BC5F90-0x0000000186BC6230
		private void Explode() {} // 0x0000000186BC6230-0x0000000186BC6C80
		public override void Despawn() {} // 0x0000000186BC6C80-0x0000000186BC6DA0
		private void GenerateParticleSystems() {} // 0x0000000186BC6DA0-0x0000000186BC8180
	}
}
