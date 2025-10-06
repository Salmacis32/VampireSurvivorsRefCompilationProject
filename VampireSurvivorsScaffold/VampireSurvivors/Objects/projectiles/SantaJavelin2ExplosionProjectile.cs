/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class SantaJavelin2ExplosionProjectile : Projectile // TypeDefIndex: 15941
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _VisibleSprite; // 0xD0
		private Tween _alphaTween; // 0xD8
		private Tween _despawnTween; // 0xE0
		private Tween _exploAlphaTween; // 0xE8
		private Tween _exploScaleTween; // 0xF0
		private Tween _colliderTween; // 0xF8
		private Transform _cachedWeaponTransform; // 0x100
		private bool _particlesGenerated; // 0x108
		private ParticleEmitterManager _particlesManager; // 0x110
		private ParticleEmitterManager _particlesManagerLine; // 0x118
		private ParticleSystem _pfxEmitter; // 0x120
		private ParticleSystem _pfxEmitter2; // 0x128
		private GravityWell _well; // 0x130
	
		// Constructors
		public SantaJavelin2ExplosionProjectile() {} // 0x0000000186E5C680-0x0000000186E5C6D0
	
		// Methods
		protected override void Awake() {} // 0x0000000186E5A640-0x0000000186E5A7C0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E5A7C0-0x0000000186E5A990
		private void Explode() {} // 0x0000000186E5A990-0x0000000186E5B180
		public override void Despawn() {} // 0x0000000186E5B180-0x0000000186E5B2A0
		private void GenerateParticleSystems() {} // 0x0000000186E5B2A0-0x0000000186E5C680
	}
}
