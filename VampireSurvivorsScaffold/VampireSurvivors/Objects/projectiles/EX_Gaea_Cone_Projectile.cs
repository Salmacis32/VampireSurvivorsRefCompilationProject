/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EX_Gaea_Cone_Projectile : Projectile // TypeDefIndex: 15864
	{
		// Fields
		private Vector2 _collisionPos; // 0xD0
		private ParticleEmitterManager _pfxManager; // 0xD8
		private ParticleSystem _pfx; // 0xE0
		private uint[] _colors; // 0xE8
		private readonly VampireSurvivors.Framework.Particles.BlendMode[] _blendModes; // 0xF0
		private SoundManager.SoundConfig _soundConfig; // 0xF8
		private float _life; // 0x100
		private Transform _cachedSpriteTransform; // 0x108
		private MultiTargetTween _tween1; // 0x110
		private MultiTargetTween _tween2; // 0x118
		private MultiTargetTween _tween3; // 0x120
		private PhaserSprite _lanceSprite; // 0x128
		private Tween lifeTween; // 0x130
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x138
	
		// Properties
		protected virtual bool IsEvolved { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		public override float ProjectileSpeed { get => default; } // 0x0000000186DFC060-0x0000000186DFC120 
	
		// Constructors
		public EX_Gaea_Cone_Projectile() {} // 0x0000000186DFDA10-0x0000000186DFDBC0
	
		// Methods
		protected override void Awake() {} // 0x0000000186DFC120-0x0000000186DFC4C0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DFC4C0-0x0000000186DFC830
		private void OnRecycle() {} // 0x0000000186DFC830-0x0000000186DFD300
		private void FadeOut() {} // 0x0000000186DFD300-0x0000000186DFD5C0
		public override void InternalUpdate() {} // 0x0000000186DFD5C0-0x0000000186DFD700
		public override void Despawn() {} // 0x0000000186DFD700-0x0000000186DFD7A0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186DFD7A0-0x0000000186DFDA10
	}
}
