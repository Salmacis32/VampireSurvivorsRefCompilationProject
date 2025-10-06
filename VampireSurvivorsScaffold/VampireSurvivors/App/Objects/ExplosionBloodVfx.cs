/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Objects
{
	public class ExplosionBloodVfx : PoolablePhaserSprite // TypeDefIndex: 18562
	{
		// Fields
		[SerializeField]
		private PhaserSprite _RingSprite; // 0x48
		[SerializeField]
		private PhaserSprite _GroundFx; // 0x50
		private float _radius; // 0x58
		private Circle _circleArea; // 0x60
		private MultiTargetTween _despawnTimer; // 0x68
		private ParticleEmitterManager _particlesManager; // 0x70
		private ParticleSystem _pfxEmitter; // 0x78
		private ParticleSystem _pfxEmitter2; // 0x80
		private GravityWell _well; // 0x88
	
		// Constructors
		public ExplosionBloodVfx() {} // 0x0000000184C44C90-0x0000000184C44CE0
	
		// Methods
		protected override void Awake() {} // 0x00000001867E03B0-0x00000001867E0500
		public void OnRecycle(float radius) {} // 0x00000001867E0500-0x00000001867E0800
		public void SetDepthPlease(float depth) {} // 0x00000001867E0800-0x00000001867E08B0
		private void GenerateParticles() {} // 0x00000001867E08B0-0x00000001867E1E00
		private void InitGravityWell() {} // 0x00000001867E1E00-0x00000001867E1E30
		private void ReleaseGravityWell() {} // 0x00000001867E1E30-0x00000001867E1F20
		private void Explode() {} // 0x00000001867E1F20-0x00000001867E2510
		private void Despawn() {} // 0x00000001867E2510-0x00000001867E2690
		private void Die() {} // 0x00000001867E2690-0x00000001867E26A0
	}
}
