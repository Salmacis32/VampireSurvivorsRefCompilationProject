/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class GlassFandangoProjectile : Projectile // TypeDefIndex: 15888
	{
		// Fields
		[SerializeField]
		private PhaserSprite _lanceSprite; // 0xD0
		[SerializeField]
		private PhaserSprite _lanceTipSprite; // 0xD8
		[SerializeField]
		private bool IsEvolved; // 0xE0
		private Vector2 _collisionPos; // 0xE4
		private Vector2 _spritePos; // 0xEC
		private ParticleEmitterManager _pfxManager; // 0xF8
		private ParticleSystem _pfx; // 0x100
		private int _sfxIndex; // 0x108
		private readonly SfxType[] _sounds; // 0x110
		private uint[] _colors; // 0x118
		private readonly VampireSurvivors.Framework.Particles.BlendMode[] _blendModes; // 0x120
		private readonly float[] _timeFreezeAngles; // 0x128
		private readonly float[] _angles; // 0x130
		private SoundManager.SoundConfig _soundConfig; // 0x138
		public float _life; // 0x140
		private Transform _cachedSpriteTransform; // 0x148
		private Transform _cachedSpriteTipTransform; // 0x150
		private MultiTargetTween _tween1; // 0x158
		private MultiTargetTween _tween2; // 0x160
		private MultiTargetTween _tween3; // 0x168
	
		// Properties
		public override float ProjectileSpeed { get => default; } // 0x0000000186E25FB0-0x0000000186E26070 
	
		// Constructors
		public GlassFandangoProjectile() {} // 0x0000000186E27AB0-0x0000000186E27E40
	
		// Methods
		protected override void Awake() {} // 0x0000000186E26070-0x0000000186E26770
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E26770-0x0000000186E26B50
		private void OnRecycle() {} // 0x0000000186E26B50-0x0000000186E278B0
		public override void InternalUpdate() {} // 0x0000000186E278B0-0x0000000186E279A0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186E279A0-0x0000000186E27AB0
		public override void Despawn() {} // 0x0000000186C17550-0x0000000186C175A0
	}
}
