/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_PistolProjectile : Projectile // TypeDefIndex: 15820
	{
		// Fields
		[SerializeField]
		private ParticleSystem pistolBasicVFX; // 0xD0
		[SerializeField]
		private ParticleSystem pistolTargetingVFX; // 0xD8
		[SerializeField]
		private ParticleEventCall pistolBasicParticleEventCall; // 0xE0
		[SerializeField]
		private ParticleEventCall pistolTargetingParticleEventCall; // 0xE8
		protected EnemyController _targetEnemyController; // 0xF0
		private VampireSurvivors.Framework.TimerSystem.Timer _prefireTimer; // 0xF8
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x100
	
		// Constructors
		public EME_PistolProjectile() {} // 0x0000000186DD3E20-0x0000000186DD3E70
	
		// Methods
		protected override void Awake() {} // 0x0000000186DD3470-0x0000000186DD3510
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DD3510-0x0000000186DD3550
		public void setEnemyTarget(EnemyController enemyTarget) {} // 0x0000000186DD3550-0x0000000186DD3B50
		public void EnableProjectileLaunch() {} // 0x0000000186DD3B50-0x0000000186DD3DA0
		public override void Despawn() {} // 0x0000000186DD3DA0-0x0000000186DD3E20
	}
}
