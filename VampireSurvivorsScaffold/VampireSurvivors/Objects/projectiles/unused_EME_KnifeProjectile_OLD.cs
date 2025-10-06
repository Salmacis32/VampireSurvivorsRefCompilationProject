/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
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
	public class unused_EME_KnifeProjectile_OLD : Projectile // TypeDefIndex: 15849
	{
		// Fields
		[SerializeField]
		private TrailRenderer _trail; // 0xD0
		private ParticleEmitterManager _pfxManager; // 0xD8
		private ParticleSystem _pfxEmitter; // 0xE0
		private bool _expired; // 0xE8
		private float _updateLoops; // 0xEC
		private MultiTargetTween _fadeTrailTween; // 0xF0
		private MultiTargetTween _angleTween; // 0xF8
		private Vector2 _startingPoint; // 0x100
		public float angleLerp; // 0x108
		private float _trailTime; // 0x10C
	
		// Constructors
		public unused_EME_KnifeProjectile_OLD() {} // 0x0000000186DEE400-0x0000000186DEE450
	
		// Methods
		protected override void Awake() {} // 0x0000000186DECB20-0x0000000186DED270
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DED270-0x0000000186DED7B0
		public override void InternalUpdate() {} // 0x0000000186DED7B0-0x0000000186DEDD30
		public override void Despawn() {} // 0x0000000186DEDD30-0x0000000186DEDDC0
		private void InitTrail() {} // 0x0000000186DEDDC0-0x0000000186DEE0B0
		protected override void OnHasHitAnObject(IDamageable target) {} // 0x0000000186DEE0B0-0x0000000186DEE0C0
		private void FadeOut() {} // 0x0000000186DEE0C0-0x0000000186DEE400
		private Vector2 Rotate_point(float targetX, float targetY, float angle, Vector2 origin) => default; // 0x0000000186BFAF80-0x0000000186BFB020
	}
}
