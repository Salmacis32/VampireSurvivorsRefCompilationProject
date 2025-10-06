/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Graphics;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EX_Rune1_Projectile : Projectile // TypeDefIndex: 15869
	{
		// Fields
		private float _IndexOffsetScaleFactor; // 0xD0
		private ParticleEmitterManager _pfxManager; // 0xD8
		private ParticleSystem _pfx; // 0xE0
		private EX_Rune1_Weapon trueWeapon; // 0xE8
		private EnemyController targetEnemy; // 0xF0
		protected Vector3 start; // 0xF8
		protected Vector3 end; // 0x104
		protected float midYOffset; // 0x110
		protected float t; // 0x114
		protected float speed; // 0x118
		protected SpriteAnimation _spriteAnimation; // 0x120
	
		// Properties
		public virtual List<string> ParticleFrames { get => default; } // 0x0000000186E02400-0x0000000186E02550 
	
		// Constructors
		public EX_Rune1_Projectile() {} // 0x0000000186E03D20-0x0000000186E03D90
	
		// Methods
		public virtual void MakeSpriteAnimation() {} // 0x0000000186E02550-0x0000000186E02780
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E02780-0x0000000186E02960
		public void SetEnemyTarget(EnemyController enemy, bool flipMyY = false /* Metadata: 0x01977931 */) {} // 0x0000000186E02960-0x0000000186E02E10
		private void GenerateParticleSystem() {} // 0x0000000186E02E10-0x0000000186E034E0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186E034E0-0x0000000186E03570
		public override void InternalUpdate() {} // 0x0000000186E03570-0x0000000186E03D00
		private float TriMap(float x) => default; // 0x0000000186E03D00-0x0000000186E03D20
	}
}
