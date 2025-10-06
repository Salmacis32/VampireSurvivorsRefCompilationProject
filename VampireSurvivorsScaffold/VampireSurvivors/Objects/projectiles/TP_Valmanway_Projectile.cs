/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Valmanway_Projectile : Projectile // TypeDefIndex: 15706
	{
		// Fields
		private Vector2 _collisionPos; // 0xD0
		private Vector2 _spritePos; // 0xD8
		private ParticleEmitterManager _pfxManager; // 0xE0
		private ParticleSystem _pfx; // 0xE8
		private uint[] _colors; // 0xF0
		private readonly VampireSurvivors.Framework.Particles.BlendMode[] _blendModes; // 0xF8
		private readonly float[] _angles; // 0x100
		private SoundManager.SoundConfig _soundConfig; // 0x108
		private float _life; // 0x110
		private Transform _cachedSpriteTransform; // 0x118
		private MultiTargetTween _tween1; // 0x120
		private MultiTargetTween _tween2; // 0x128
		private MultiTargetTween _tween3; // 0x130
		private PhaserSprite _lanceSprite; // 0x138
		private MultiTargetTween _tween2b; // 0x140
		private List<int> _modifiers; // 0x148
		private Tween lifeTween; // 0x150
	
		// Properties
		public override float ProjectileSpeed { get => default; } // 0x0000000186D41E60-0x0000000186D41F20 
	
		// Constructors
		public TP_Valmanway_Projectile() {} // 0x0000000186D43410-0x0000000186D439E0
	
		// Methods
		protected override void Awake() {} // 0x0000000186D41F20-0x0000000186D422E0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D422E0-0x0000000186D42630
		private void OnRecycle() {} // 0x0000000186D42630-0x0000000186D43220
		public override void InternalUpdate() {} // 0x0000000186D43220-0x0000000186D43370
		public override void Despawn() {} // 0x0000000186D43370-0x0000000186D43410
	}
}
