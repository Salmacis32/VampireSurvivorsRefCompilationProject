/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class EME_Mech1Weapon : EME_Weapon, EME_iCosmicRaveVFX // TypeDefIndex: 16602
	{
		// Fields
		[Header("Additional Projectile Prefabs")]
		[SerializeField]
		private Projectile _BasicExplosionPrefab; // 0x1C8
		[SerializeField]
		private Projectile _HailstormExplosionPrefab; // 0x1D0
		private BulletPool _cosmicRaveVFXpool; // 0x1D8
		[SerializeField]
		private Projectile _CosmicRaveVFXPrefab; // 0x1E0
		[SerializeField]
		public bool UprightCosmicWaveSilhouette; // 0x1E8
		private VampireSurvivors.Framework.TimerSystem.Timer _glimmerShotTimer; // 0x1F0
		protected BulletPool _basicExplosionPool; // 0x1F8
		protected BulletPool _hailstormExplosionPool; // 0x200
	
		// Properties
		protected override int _comboIndex1 { get => default; } // 0x0000000181BA4B30-0x0000000181BA4B40 
		protected override int _comboIndex2 { get => default; } // 0x00000001819170A0-0x00000001819170B0 
		protected override int _comboIndex3 { get => default; } // 0x0000000181BA6070-0x0000000181BA6080 
		protected override int ComboIndexFinal { get => default; } // 0x0000000187011AB0-0x0000000187011AD0 
		public BulletPool BasicExplosionPool { get => default; } // 0x0000000182767040-0x0000000182767050 
		public BulletPool HailstormExplosionPool { get => default; } // 0x00000001858341D0-0x00000001858341E0 
	
		// Constructors
		public EME_Mech1Weapon() {} // 0x0000000187009980-0x0000000187009990
	
		// Methods
		protected override WeaponType GetWeaponTypeForGlimmerLevel(int level) => default; // 0x000000018701BFB0-0x000000018701BFE0
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B21570-0x0000000180B21580
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x000000018701BFE0-0x000000018701C010
		protected override void OnStart() {} // 0x000000018701C010-0x000000018701C630
		public void DisplayCosmicRaveVFX(float2 position) {} // 0x000000018701C630-0x000000018701C670
		protected bool OnBulletOverlapsEnemy_Freeze(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x000000018701C670-0x000000018701C7A0
		protected override void Fire_DoAttacks(BulletPool glimmerPool, bool skipTriggers = false /* Metadata: 0x01977D74 */) {} // 0x000000018701C7A0-0x000000018701C950
		protected override void Fire_FireGlimmerProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) {} // 0x000000018701C950-0x000000018701D1E0
		public Vector2 RandomPosOnScreenEdge() => default; // 0x000000018701D1E0-0x000000018701D4B0
		public void FireVolley(Vector2 pos, int _amount, Transform target = null) {} // 0x000000018701D4B0-0x000000018701D6C0
		public override void Cleanup() {} // 0x000000018701D6C0-0x000000018701D710
		public override void CheckArcanas() {} // 0x000000018701D710-0x000000018701D8B0
	}
}
