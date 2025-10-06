/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class EME_WaveWeapon : Weapon // TypeDefIndex: 16641
	{
		// Fields
		[SerializeField]
		private ParticleSystem _pfxEmitter; // 0x158
		[SerializeField]
		private ParticleSystem _pfxEmitter2; // 0x160
		[SerializeField]
		protected Projectile _LinePrefab; // 0x168
		protected BulletPool _linePool; // 0x170
	
		// Properties
		public virtual bool IsEvolved { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		protected override int ProjectilePoolSize { get => default; } // 0x0000000181B53370-0x0000000181B53380 
	
		// Constructors
		public EME_WaveWeapon() {} // 0x000000018702CA10-0x000000018702CA60
	
		// Methods
		protected override void OnStart() {} // 0x000000018702CA60-0x000000018702CC60
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x000000018702CC60-0x000000018702CD70
		protected bool OnBulletOverlapsEnemyWave(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x000000018702CD70-0x000000018702CE80
		public void Rapture(EnemyController enemy) {} // 0x000000018702CE80-0x000000018702D180
		public void RaptureDamage(EnemyController enemy, bool risky = true /* Metadata: 0x01977DA8 */) {} // 0x000000018702D180-0x000000018702D5C0
	}
}
