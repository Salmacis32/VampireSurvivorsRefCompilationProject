/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class EME_Pistol1Weapon : EME_Weapon // TypeDefIndex: 16608
	{
		// Fields
		private BulletPool _bdShotPool; // 0x1C8
		[SerializeField]
		protected Projectile _bdShotPrefsb; // 0x1D0
		private BulletPool _ffExplosionPool; // 0x1D8
		[SerializeField]
		protected Projectile _ffExplosionPrefsb; // 0x1E0
		private BulletPool _destructibleProjectilePool; // 0x1E8
		[SerializeField]
		private Projectile _destructibleProjectilePrefab; // 0x1F0
		private float _range; // 0x1F8
		private float _defaultRange; // 0x1FC
	
		// Properties
		protected override int EvolutionLevel { get => default; } // 0x0000000180B22260-0x0000000180B22270 
		protected override int _comboIndex1 { get => default; } // 0x0000000180B21B50-0x0000000180B21B60 
		protected override int _comboIndex2 { get => default; } // 0x0000000180B22260-0x0000000180B22270 
		protected override int ComboIndexFinal { get => default; } // 0x000000018700A1C0-0x000000018700A1D0 
	
		// Constructors
		public EME_Pistol1Weapon() {} // 0x0000000187009980-0x0000000187009990
	
		// Methods
		public override float PSpeed() => default; // 0x000000018701EE00-0x000000018701EF50
		protected override WeaponType GetWeaponTypeForGlimmerLevel(int level) => default; // 0x000000018701EF50-0x000000018701EF70
		protected override void OnStart() {} // 0x000000018701EF70-0x000000018701F730
		public void DoFalconFireExplosionAt(Vector2 position) {} // 0x000000018701F730-0x000000018701F8F0
		public void DoBoundingShotExplosionAt(Vector2 position) {} // 0x000000018701F8F0-0x000000018701F930
		protected override void Fire_FireBasicProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) {} // 0x000000018700AC30-0x000000018700AC50
		protected override void Fire_FireGlimmerProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) {} // 0x000000018700AC30-0x000000018700AC50
		public void SpawnSpecialProjectiles(float2 position, BulletPool pool, float amountMul = 1f /* Metadata: 0x01977D77 */, float areaMul = 1f /* Metadata: 0x01977D7B */) {} // 0x000000018701F930-0x000000018701FD40
		protected bool OnBulletOverlapsEnemyHighDamage(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x000000018701FD40-0x000000018701FEB0
		public override void InternalUpdate() {} // 0x000000018701FEB0-0x000000018701FF40
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
		public float GetRange() => default; // 0x000000018701FF40-0x000000018701FF80
		protected override void Fire_DoAttacks(BulletPool glimmerPool, bool skipTriggers = false /* Metadata: 0x01977D7F */) {} // 0x000000018701FF80-0x0000000187020350
		public override void ParadoxFire() {} // 0x0000000187020350-0x0000000187020490
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B21570-0x0000000180B21580
	}
}
