/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_PistolProjectile_BoundingShot : Projectile // TypeDefIndex: 15821
	{
		// Fields
		[SerializeField]
		private ParticleSystem boundingShotVFX; // 0xD0
		[SerializeField]
		private ParticleEventCall boundingShotParticleEventCall; // 0xD8
		private readonly List<int> _targetAngles; // 0xE0
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xE8
		private VampireSurvivors.Framework.TimerSystem.Timer _despawnTimer; // 0xF0
		private float _saveVelX; // 0xF8
		private float _saveVelY; // 0xFC
		private EME_Pistol1Weapon _trueWeapon; // 0x100
		private VampireSurvivors.Framework.TimerSystem.Timer _bounceTimer; // 0x108
		private bool _canBounce; // 0x110
	
		// Constructors
		public EME_PistolProjectile_BoundingShot() {} // 0x0000000186DD5220-0x0000000186DD5630
	
		// Methods
		protected override void Awake() {} // 0x0000000186DD3E70-0x0000000186DD3F90
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DD3F90-0x0000000186DD40C0
		private void SetupMechanics() {} // 0x0000000186DD40C0-0x0000000186DD4710
		private void SetupVisuals() {} // 0x0000000186DD4710-0x0000000186DD4730
		public override void SetTarget(Transform target) {} // 0x0000000186DD4730-0x0000000186DD4880
		public override void InternalUpdate() {} // 0x0000000186DD4880-0x0000000186DD4AF0
		private void Bounce(Body b, bool up, bool down, bool left, bool right) {} // 0x0000000186DD4AF0-0x0000000186DD4BB0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186DD4BB0-0x0000000186DD4E30
		public override void OnHasHitWallPhaser(PhaserTile tile) {} // 0x0000000186DD4E30-0x0000000186DD4F70
		private void StartDespawn() {} // 0x0000000186DD4F70-0x0000000186DD51C0
		public override void Despawn() {} // 0x0000000186DD51C0-0x0000000186DD5220
		private void DespawnAfterParticlesStopped() {} // 0x0000000186C60D40-0x0000000186C60D50
		private void FinishDespawn() {} // 0x0000000186C60D40-0x0000000186C60D50
	}
}
