/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_PunchProjectile_Guayim : Projectile // TypeDefIndex: 15828
	{
		// Fields
		[SerializeField]
		private ParticleSystem guayimPunchingVFX; // 0xD0
		[SerializeField]
		private ParticleSystem guayimDustVFX; // 0xD8
		[SerializeField]
		private float radius; // 0xE0
		private const float GUAYIM_DURATION = 5000f; // Metadata: 0x019778DC
		private SpriteRenderer _guayimPlayerSpriteRenderer; // 0xE8
		private Vector3 _guayimPunchingScale; // 0xF0
		private Vector3 _guayimDustScale; // 0xFC
		private Vector3 _guayimPunchingPosition; // 0x108
		private Vector3 _guayimDustPosition; // 0x114
		private EnemyController _strongestEnemy; // 0x120
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x128
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x130
	
		// Constructors
		public EME_PunchProjectile_Guayim() {} // 0x0000000186DDAC40-0x0000000186DDACA0
	
		// Methods
		protected override void Awake() {} // 0x0000000186DD8E10-0x0000000186DD94F0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DD94F0-0x0000000186DD9680
		public override void InternalUpdate() {} // 0x0000000186DD9680-0x0000000186DD9C90
		private void SetupMechanics() {} // 0x0000000186DD9C90-0x0000000186DD9E30
		private void SetupVFX() {} // 0x0000000186DD9E30-0x0000000186DDA2C0
		private void SetupTimers() {} // 0x0000000186DDA2C0-0x0000000186DDA560
		private EnemyController GetStrongestTarget() => default; // 0x0000000186DDA560-0x0000000186DDA770
		private static List<EnemyController> GetAllEnemiesInRectBounds(Rectangle _rect) => default; // 0x0000000186DDA770-0x0000000186DDAA60
		public override void Despawn() {} // 0x0000000186DDAA60-0x0000000186DDABA0
		[IteratorStateMachine(typeof(_WaitForParticlesToFinish_d__21))]
		private IEnumerator WaitForParticlesToFinish() => default; // 0x0000000186DDABA0-0x0000000186DDAC40
	}
}
