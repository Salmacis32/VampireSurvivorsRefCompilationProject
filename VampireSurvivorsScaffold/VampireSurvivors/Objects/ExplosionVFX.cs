/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using QFSW.MOP2;
using UnityEngine;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.TimerSystem;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects
{
	public class ExplosionVFX : PoolableMonoBehaviour // TypeDefIndex: 15169
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _GroundFx; // 0x30
		[SerializeField]
		private SpriteRenderer _RingSprite; // 0x38
		private Transform _cachedTransform; // 0x40
		private ParticleEmitterManager _particlesManager; // 0x48
		private ParticleSystem _pfxEmitter; // 0x50
		private ParticleSystem _pfxEmitter2; // 0x58
		private GravityWell _well; // 0x60
		private Tween _scaleTween; // 0x68
		private Tween _scaleRingTween; // 0x70
		private VampireSurvivors.Framework.TimerSystem.Timer _despawnTimer; // 0x78
		private Circle _circleArea; // 0x80
		private float _damage; // 0x88
		private float _radius; // 0x8C
		private uint[] _tints; // 0x90
	
		// Constructors
		public ExplosionVFX() {} // 0x0000000186A748B0-0x0000000186A749C0
	
		// Methods
		private new void Awake() {} // 0x0000000186A72580-0x0000000186A725F0
		private void OnDrawGizmosSelected() {} // 0x0000000186A725F0-0x0000000186A726E0
		public void SpawnAt(float damage, float radius, bool flashingVFX) {} // 0x0000000186A726E0-0x0000000186A72BF0
		public void SetDepthPlease(float depth) {} // 0x0000000186A72BF0-0x0000000186A72CA0
		private void Explode(bool flashingVFX) {} // 0x0000000186A72CA0-0x0000000186A73170
		private void TriggerDespawnTimer() {} // 0x0000000186A73170-0x0000000186A73400
		private void Despawn() {} // 0x0000000184E3DC10-0x0000000184E3DC80
		private void GenerateParticleSystems() {} // 0x0000000186A73400-0x0000000186A748B0
	}
}
