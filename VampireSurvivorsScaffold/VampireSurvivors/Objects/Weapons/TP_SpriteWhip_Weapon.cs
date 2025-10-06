/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_SpriteWhip_Weapon : Weapon // TypeDefIndex: 16497
	{
		// Fields
		[SerializeField]
		private Projectile _fireballPrefab; // 0x158
		private BulletPool _fireballPool; // 0x160
		[SerializeField]
		private Projectile _explosionPrefab; // 0x168
		private BulletPool _explosionPool; // 0x170
		private List<float> _fireBallAngles; // 0x178
		private List<float> _fireBallAnglesFlipped; // 0x180
		public int _activationsCount; // 0x188
		public int _specialCounter; // 0x18C
		private float BossBonus; // 0x190
	
		// Properties
		public virtual bool ShootFireballs { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
	
		// Constructors
		public TP_SpriteWhip_Weapon() {} // 0x0000000186FF6B50-0x0000000186FF6F00
	
		// Methods
		public override float PPower() => default; // 0x0000000186FF5AD0-0x0000000186FF5AF0
		public void CalculateBossBonus() {} // 0x0000000186FF5AF0-0x0000000186FF5BB0
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B209C0-0x0000000180B209D0
		protected override void OnStart() {} // 0x0000000186FF5BB0-0x0000000186FF6150
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977CE4 */) {} // 0x0000000186FF6150-0x0000000186FF6630
		public Projectile FireFireballProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) => default; // 0x0000000186FF6630-0x0000000186FF6840
		public Projectile FireExplosionProjectile(Vector2 pos, int index, EnemyController target = null, BulletPool pool = null) => default; // 0x0000000186FF6840-0x0000000186FF6A00
		public override void CheckArcanas() {} // 0x0000000186F8E930-0x0000000186F8E9F0
		protected override void OnDestroy() {} // 0x0000000186FF6A00-0x0000000186FF6B10
		public override void Cleanup() {} // 0x0000000186FF6B10-0x0000000186FF6B50
	}
}
