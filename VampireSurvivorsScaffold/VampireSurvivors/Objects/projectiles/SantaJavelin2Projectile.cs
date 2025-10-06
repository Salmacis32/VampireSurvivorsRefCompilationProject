/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class SantaJavelin2Projectile : Projectile // TypeDefIndex: 15944
	{
		// Fields
		[SerializeField]
		private SpriteAnimation _AngelAnimation; // 0xD0
		[SerializeField]
		private SpriteRenderer _AngelSprite; // 0xD8
		[SerializeField]
		private SpriteRenderer _JavelinSprite; // 0xE0
		[SerializeField]
		private SpriteRenderer _GroundFx; // 0xE8
		[SerializeField]
		private SpriteTrail _Trail; // 0xF0
		protected SantaJavelin2Weapon _trueWeapon; // 0xF8
		private Camera _camera; // 0x100
		private Tween _positionTween; // 0x108
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x110
		private ParticleSystem _explosionPfx1; // 0x118
		private ParticleSystem _explosionPfx2; // 0x120
		private const float Radius = 32f; // Metadata: 0x0197798A
		private const float ExploRadius = 8f; // Metadata: 0x0197798E
		private bool _isBroken; // 0x128
		private bool _isDespawning; // 0x129
		private MultiTargetTween _tween1; // 0x130
		private MultiTargetTween _tween2; // 0x138
		private MultiTargetTween _tween3; // 0x140
		private MultiTargetTween _tween4; // 0x148
		private float fullSalvoDuration; // 0x150
		private MultiTargetTween _angelAlphaTween; // 0x158
		private TweenerCore<Vector3, Vector3, VectorOptions> _positionTweenAngel; // 0x160
		private GravityWell _well; // 0x168
		private ParticleEmitterManager _particlesManager; // 0x170
	
		// Properties
		protected virtual bool MirrorMotion { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
	
		// Constructors
		public SantaJavelin2Projectile() {} // 0x0000000186E604D0-0x0000000186E60520
	
		// Methods
		protected override void Awake() {} // 0x0000000186E5C6D0-0x0000000186E5CA00
		private void PlaySFX() {} // 0x0000000186E5CA00-0x0000000186E5CC50
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E5CC50-0x0000000186E5DE10
		public override void InternalUpdate() {} // 0x0000000186E5DE10-0x0000000186E5DFA0
		private void Break() {} // 0x0000000186E5DFA0-0x0000000186E5E9F0
		private void StartDespawn() {} // 0x0000000186E5E9F0-0x0000000186E5EDA0
		public override void Despawn() {} // 0x0000000186E5EDA0-0x0000000186E5EE30
		private void GetComponents() {} // 0x0000000186E5EE30-0x0000000186E5EF60
		private void GenerateParticleSystems() {} // 0x0000000186E5EF60-0x0000000186E604D0
	}
}
