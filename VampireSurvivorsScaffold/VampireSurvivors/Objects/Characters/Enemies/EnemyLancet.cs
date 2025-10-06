/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using QFSW.MOP2;
using UnityEngine;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyLancet : PoolableMonoBehaviour // TypeDefIndex: 17339
	{
		// Fields
		private SpriteRenderer _groundFx; // 0x30
		private Transform _cachedTransform; // 0x38
		private GameSessionData _gameSessionData; // 0x40
		private PlayerOptions _playerOptions; // 0x48
		private EnemyGallo _owner; // 0x50
		private ParticleEmitterManager _particlesManager; // 0x58
		private ParticleSystem _pfxEmitter; // 0x60
		private ParticleSystem _pfxEmitter2; // 0x68
		private GravityWell _gravityWell; // 0x70
		private bool _hasHit; // 0x78
		private Tween _despawnTimer; // 0x80
		private Circle _circle; // 0x88
		private const float Radius = 30f; // Metadata: 0x0197846A
		private const float Diameter = 60f; // Metadata: 0x0197846E
	
		// Properties
		public float Duration { get; set; } // 0x0000000184E163F0-0x0000000184E16400 0x000000018675D2C0-0x000000018675D2D0
	
		// Constructors
		public EnemyLancet() {} // 0x000000018727C240-0x000000018727C2A0
	
		// Methods
		protected virtual void FakeConstruct() {} // 0x0000000187279CF0-0x0000000187279E20
		private new void Awake() {} // 0x0000000187279E20-0x000000018727A120
		private void OnDrawGizmos() {} // 0x000000018727A120-0x000000018727A230
		public void Init() {} // 0x000000018727A230-0x000000018727A690
		public void SetDepthPlease(float depth) {} // 0x000000018727A690-0x000000018727A740
		public void InternalUpdate() {} // 0x000000018727A740-0x000000018727AAA0
		public void SetOwner(EnemyGallo enemyGallo) {} // 0x000000018261D810-0x000000018261D870
		private void Despawn() {} // 0x000000018727AAA0-0x000000018727ACC0
		private void OnHit() {} // 0x000000018727ACC0-0x000000018727B150
		private void GenerateParticleSystems() {} // 0x000000018727B150-0x000000018727C240
	}
}
