/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class unused_EME_LongswordProjectile_LifeSprinkler : Projectile // TypeDefIndex: 15850
	{
		// Fields
		[SerializeField]
		private ParticleSystem lifeSprinklerFullVFX; // 0xD0
		[SerializeField]
		private ParticleEventCall lifeSprinklerFullVFXParticleEventCall; // 0xD8
		[SerializeField]
		private ParticleSystem lifeSprinklerCrossVFX; // 0xE0
		[SerializeField]
		private ParticleEventCall lifeSprinklerCrossVFXParticleEventCall; // 0xE8
		[SerializeField]
		private float radius; // 0xF0
		[SerializeField]
		private int hitMultiplier; // 0xF4
		private int _amountOfHits; // 0xF8
		private float _spriteHalfHeight; // 0xFC
		private EnemyController _strongestEnemy; // 0x100
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x108
		private Camera _camera; // 0x110
	
		// Constructors
		public unused_EME_LongswordProjectile_LifeSprinkler() {} // 0x0000000186DEF760-0x0000000186DEF7D0
	
		// Methods
		protected override void Awake() {} // 0x0000000186DEE4D0-0x0000000186DEE620
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DEE620-0x0000000186DEE650
		public override void InternalUpdate() {} // 0x0000000186DEE650-0x0000000186DEEC50
		private void SetupMechanics() {} // 0x0000000186DEEC50-0x0000000186DEEEA0
		private void SetupVFX() {} // 0x0000000186DEEEA0-0x0000000186DEF0C0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186DEF0C0-0x0000000186DEF250
		private void RefreshHitbox() {} // 0x0000000186DEF250-0x0000000186DEF2E0
		private EnemyController GetStrongestTarget() => default; // 0x0000000186DEF2E0-0x0000000186DEF530
		public override void Despawn() {} // 0x0000000186DEF530-0x0000000186DEF5D0
		private void SprinklerFullVFXStopped() {} // 0x0000000186DEF5D0-0x0000000186DEF690
		private void SprinklerCrossVFXStopped() {} // 0x0000000186DEF690-0x0000000186DEF750
		private void FinishDespawn() {} // 0x0000000186DEF750-0x0000000186DEF760
	}
}
