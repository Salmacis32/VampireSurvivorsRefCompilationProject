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
using VampireSurvivors;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_PunchProjectile_Raksha : Projectile // TypeDefIndex: 15829
	{
		// Fields
		[SerializeField]
		private ParticleSystem rakshaSparksVFX; // 0xD0
		[SerializeField]
		private ParticleSystem rakshaImpactBigVFX; // 0xD8
		[SerializeField]
		private ParticleSystem rakshaImpactSmallVFX; // 0xE0
		[SerializeField]
		private ParticleSystem rakshaPunchVFX; // 0xE8
		[SerializeField]
		private ParticleSystem rakshaExplosionVFX; // 0xF0
		[SerializeField]
		private ParticleEventCall rakshaExplosionVFXparticleEventCall; // 0xF8
		private float radius; // 0x100
		private bool _isDespawning; // 0x104
		private Tween _radiusTween; // 0x108
		private TweenerCore<Vector3, Vector3, VectorOptions> _moveTween; // 0x110
		private Vector3 _targetPosition; // 0x118
		private bool _showVfx; // 0x124
		private bool _hasExploded; // 0x125
	
		// Constructors
		public EME_PunchProjectile_Raksha() {} // 0x0000000186DDBBA0-0x0000000186DDBC00
	
		// Methods
		protected override void Awake() {} // 0x0000000186DDAEC0-0x0000000186DDAFC0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DDAFC0-0x0000000186DDB150
		private void SetupMechanics() {} // 0x0000000186DDB150-0x0000000186DDB240
		private void SetupVisuals() {} // 0x0000000186DDB240-0x0000000186DDB420
		private void Strike() {} // 0x0000000186DDB420-0x0000000186DDB730
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186DDB730-0x0000000186DDB840
		private void Explode() {} // 0x0000000186DDB840-0x0000000186DDB9F0
		public void SetTargetPosition(Vector3 target) {} // 0x0000000186DDB9F0-0x0000000186DDBAD0
		public void StartDespawn() {} // 0x0000000186DDBAD0-0x0000000186DDBB60
		private void DespawnAfterParticlesStopped() {} // 0x0000000186DDBB60-0x0000000186DDBBA0
		private void FinishDespawn() {} // 0x0000000186DDBB60-0x0000000186DDBBA0
	}
}
