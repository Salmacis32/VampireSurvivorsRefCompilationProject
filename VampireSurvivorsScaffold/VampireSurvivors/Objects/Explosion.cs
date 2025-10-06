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
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects
{
	public class Explosion : PoolableMonoBehaviour // TypeDefIndex: 15084
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _GroundFx; // 0x30
		private Transform _cachedTransform; // 0x38
		private PlayerOptions _playerOptions; // 0x40
		private ParticleEmitterManager _particlesManager; // 0x48
		private ParticleSystem _pfxEmitter1; // 0x50
		private ParticleSystem _pfxEmitter2; // 0x58
		private GravityWell _gravityWell; // 0x60
		private Tween _scaleTween; // 0x68
		private VampireSurvivors.Framework.TimerSystem.Timer _despawnTimer; // 0x70
		private Circle _circleArea; // 0x78
		private float _damage; // 0x80
		private float _radius; // 0x84
		private bool _hasHit; // 0x88
		private bool _isDespawning; // 0x89
	
		// Constructors
		public Explosion() {} // 0x00000001869F1FF0-0x00000001869F2050
	
		// Methods
		[Inject]
		private void Construct(PlayerOptions playerOptions) {} // 0x000000018260F820-0x000000018260F880
		private new void Awake() {} // 0x00000001869EFC70-0x00000001869EFCE0
		private void OnDrawGizmosSelected() {} // 0x00000001869EFCE0-0x00000001869EFDD0
		public void Init(float damage, float radius) {} // 0x00000001869EFDD0-0x00000001869F0560
		public void SetDepthPlease(float depth) {} // 0x00000001869F0560-0x00000001869F0610
		public void InternalUpdate() {} // 0x00000001869F0610-0x00000001869F08D0
		private void TriggerDespawnTimer() {} // 0x00000001869F08D0-0x00000001869F0B70
		private void Despawn() {} // 0x00000001869F0B70-0x00000001869F0C70
		private void GenerateParticleSystems() {} // 0x00000001869F0C70-0x00000001869F1EE0
		private void InitGravityWell() {} // 0x00000001869F1EE0-0x00000001869F1F10
		private void ReleaseGravityWell() {} // 0x00000001869F1F10-0x00000001869F1FF0
	}
}
