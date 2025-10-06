/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_CannonProjectile_SunlightShowerCluster : Projectile // TypeDefIndex: 15761
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _GroundFx; // 0xD0
		[SerializeField]
		private TrailRenderer _orangeTrail; // 0xD8
		[SerializeField]
		private TrailRenderer _blueTrail; // 0xE0
		[SerializeField]
		private ParticleSystem _orangeExplosionVFX; // 0xE8
		[SerializeField]
		private ParticleSystem _blueExplosionVFX; // 0xF0
		private Camera _camera; // 0xF8
		private Tween _angleTween; // 0x100
		private Tween _positionTween; // 0x108
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x110
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x118
		private Circle _explosionCircle; // 0x120
		private const float Radius = 16f; // Metadata: 0x019777DE
		private bool _isBroken; // 0x128
	
		// Constructors
		public EME_CannonProjectile_SunlightShowerCluster() {} // 0x0000000186D7C880-0x0000000186D7C8D0
	
		// Methods
		protected override void Awake() {} // 0x0000000186D7B220-0x0000000186D7B350
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D7B350-0x0000000186D7B430
		private void SetupMechanics() {} // 0x0000000186D7B430-0x0000000186D7BFF0
		private void SetupVisuals() {} // 0x0000000186D7BFF0-0x0000000186D7C0B0
		private void Break() {} // 0x0000000186D7C0B0-0x0000000186D7C7E0
		public override void Despawn() {} // 0x0000000186D7C7E0-0x0000000186D7C880
	}
}
