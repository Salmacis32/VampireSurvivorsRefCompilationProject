/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_Chauve2_Weapon : TP_Chauve1_Weapon // TypeDefIndex: 16287
	{
		// Fields
		private BulletPool _beamPool; // 0x158
		private const float _shootTimeMillis = 250f; // Metadata: 0x01977C2B
	
		// Properties
		public float ShootTimeMillis { get => default; } // 0x0000000186F8EB60-0x0000000186F8EB70 
	
		// Constructors
		public TP_Chauve2_Weapon() {} // 0x0000000186F8EB10-0x0000000186F8EB60
	
		// Methods
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F8EB70-0x0000000186F8EB90
		public Projectile SpawnBeamAt(float2 pos, int enemiesHit = 0 /* Metadata: 0x01977C25 */, int damage = 1 /* Metadata: 0x01977C26 */, float area = 1f /* Metadata: 0x01977C27 */) => default; // 0x0000000186F8EB90-0x0000000186F8EEE0
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F8EEE0-0x0000000186F8F060
		private bool OnBeamOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F8F060-0x0000000186F8F170
		private void DealCritDamage(EnemyController target) {} // 0x0000000186F8F170-0x0000000186F8F2B0
	}
}
