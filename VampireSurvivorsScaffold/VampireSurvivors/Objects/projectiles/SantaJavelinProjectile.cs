/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class SantaJavelinProjectile : Projectile // TypeDefIndex: 15947
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _JavelinSprite; // 0xD0
		[SerializeField]
		private SpriteRenderer _GroundFx; // 0xD8
		[SerializeField]
		private SpriteTrail _Trail; // 0xE0
		protected SantaJavelinWeapon _trueWeapon; // 0xE8
		private Camera _camera; // 0xF0
		private Tween _positionTween; // 0xF8
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x100
		private ParticleSystem _explosionPfx1; // 0x108
		private ParticleSystem _explosionPfx2; // 0x110
		private const float Radius = 32f; // Metadata: 0x01977992
		private const float ExploRadius = 8f; // Metadata: 0x01977996
		private bool _isBroken; // 0x118
		private bool _isDespawning; // 0x119
		private MultiTargetTween _tween1; // 0x120
		private MultiTargetTween _tween2; // 0x128
		private MultiTargetTween _tween3; // 0x130
		private MultiTargetTween _tween4; // 0x138
		private float fullSalvoDuration; // 0x140
		private MultiTargetTween _tween5; // 0x148
		private MultiTargetTween _tween6; // 0x150
		private float _javelinScale; // 0x158
		private Vector3 _trailScale; // 0x15C
	
		// Properties
		protected virtual bool MirrorMotion { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
	
		// Constructors
		public SantaJavelinProjectile() {} // 0x0000000186E61700-0x0000000186E61750
	
		// Methods
		protected override void Awake() {} // 0x0000000186E61750-0x0000000186E61960
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E61960-0x0000000186E61E50
		public override void SetNullTarget() {} // 0x0000000186BB8730-0x0000000186BB8750
		public void SetTargetVec(Vector3 target) {} // 0x0000000186E61E50-0x0000000186E63200
		public override void InternalUpdate() {} // 0x0000000186E63200-0x0000000186E63390
		private void Break() {} // 0x0000000186E63390-0x0000000186E63E40
		private void StartDespawn() {} // 0x0000000186E63E40-0x0000000186E64200
		public override void Despawn() {} // 0x0000000186E64200-0x0000000186E642E0
		private void GetComponents() {} // 0x0000000186E642E0-0x0000000186E64410
		private void GenerateParticleSystems() {} // 0x0000000186E64410-0x0000000186E65090
	}
}
