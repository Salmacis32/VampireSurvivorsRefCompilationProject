/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Confodere2_Projectile : Projectile // TypeDefIndex: 15515
	{
		// Fields
		private ParticleEmitterManager _pfxManager; // 0xD0
		private ParticleSystem _emitter1; // 0xD8
		private ParticleSystem _emitter2; // 0xE0
		private VampireSurvivors.Framework.TimerSystem.Timer expireTimer; // 0xE8
		private bool _isDespawning; // 0xF0
		private PhaserSprite _lanceSprite; // 0xF8
		private Vector2 _collisionPos; // 0x100
		private Vector2 _spritePos; // 0x108
		private float _life; // 0x110
		private Transform _cachedSpriteTransform; // 0x118
		private MultiTargetTween _tween1; // 0x120
		private MultiTargetTween _tween2; // 0x128
		private MultiTargetTween _tween3; // 0x130
		private Tween lifeTween; // 0x138
	
		// Constructors
		public TP_Confodere2_Projectile() {} // 0x0000000186C77CE0-0x0000000186C77D30
	
		// Methods
		protected override void Awake() {} // 0x0000000186C74DB0-0x0000000186C75120
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C75120-0x0000000186C76110
		public override void InternalUpdate() {} // 0x0000000186C76110-0x0000000186C76260
		public void StartDespawn() {} // 0x0000000186C76260-0x0000000186C76550
		public override void Despawn() {} // 0x0000000186C76550-0x0000000186C765C0
		private void MakeEmitters() {} // 0x0000000186C765C0-0x0000000186C77CE0
	}
}
