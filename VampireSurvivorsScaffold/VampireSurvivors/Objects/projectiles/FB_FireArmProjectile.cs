/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class FB_FireArmProjectile : Projectile // TypeDefIndex: 15468
	{
		// Fields
		private ParticleSystem _pfx; // 0xD0
		private Tween _scaleTween; // 0xD8
		private Tween _radiusTweenX; // 0xE0
		private float _deltaTime; // 0xE8
		private const float Percentage = 0.0625f; // Metadata: 0x01977635
		private const float Radius = 0.25f; // Metadata: 0x01977639
		private const float SpeedModifier = 35f; // Metadata: 0x0197763D
		private Vector3 _centralPos; // 0xEC
		private Vector3 _movement; // 0xF8
		private SpriteAnimation _anim; // 0x108
		private PhaserSprite _coronaSprite; // 0x110
		private MultiTargetTween _coronaTween; // 0x118
		private bool _isDespawning; // 0x120
		private float coronaRatio; // 0x124
	
		// Constructors
		public FB_FireArmProjectile() {} // 0x0000000186C20BF0-0x0000000186C20C50
	
		// Methods
		protected override void Awake() {} // 0x0000000186C1EEB0-0x0000000186C1F320
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C1F320-0x0000000186C1FE50
		public override void InternalUpdate() {} // 0x0000000186C1FE50-0x0000000186C201B0
		public override void Despawn() {} // 0x0000000186C201B0-0x0000000186C204F0
		private void DoDespawn() {} // 0x0000000186C204F0-0x0000000186C20560
		private void GenerateParticleSystem() {} // 0x0000000186C20560-0x0000000186C20A60
		protected override void OnHasHitAnObject(IDamageable target) {} // 0x0000000186C20A60-0x0000000186C20BF0
	}
}
