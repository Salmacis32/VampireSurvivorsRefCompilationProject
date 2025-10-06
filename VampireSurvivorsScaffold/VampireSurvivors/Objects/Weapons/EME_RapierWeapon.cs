/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class EME_RapierWeapon : EME_Weapon // TypeDefIndex: 16618
	{
		// Fields
		[SerializeField]
		protected Projectile _MegaSinglePrefab; // 0x1C8
		[SerializeField]
		protected Projectile _NoDamageFreezePrefab; // 0x1D0
		[SerializeField]
		protected Projectile _NoDamageSlowPrefab; // 0x1D8
		[HideInInspector]
		public int[] _FireAngles; // 0x1E0
		[HideInInspector]
		public int[] _FireX; // 0x1E8
		[HideInInspector]
		public int[] _FireY; // 0x1F0
		protected BulletPool _megaSinglePool; // 0x1F8
		protected BulletPool _freezeOnlyPool; // 0x200
		protected BulletPool _slowOnlyPool; // 0x208
	
		// Properties
		public BulletPool FreezeOnlyPool { get => default; } // 0x00000001858341D0-0x00000001858341E0 
		public BulletPool SlowOnlyPool { get => default; } // 0x00000001854006C0-0x00000001854006D0 
		public BulletPool MegaSinglePool { get => default; } // 0x0000000182767040-0x0000000182767050 
		protected override int _comboIndex1 { get => default; } // 0x0000000180B209C0-0x0000000180B209D0 
		protected override int _comboIndex2 { get => default; } // 0x0000000181BA4B30-0x0000000181BA4B40 
		protected override int _comboIndex3 { get => default; } // 0x0000000181F01BA0-0x0000000181F01BB0 
		protected override int ComboIndexFinal { get => default; } // 0x000000018700FE40-0x000000018700FE50 
	
		// Constructors
		public EME_RapierWeapon() {} // 0x0000000187026720-0x0000000187026900
	
		// Methods
		public virtual int DisplayedSlashes() => default; // 0x0000000180B209C0-0x0000000180B209D0
		protected override WeaponType GetWeaponTypeForGlimmerLevel(int level) => default; // 0x0000000187024D00-0x0000000187024D30
		public override float PPower() => default; // 0x0000000187024D30-0x0000000187024DE0
		protected override float FinalGlimmerChance() => default; // 0x0000000187024DE0-0x0000000187024E60
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000187024E60-0x0000000187024E90
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B209C0-0x0000000180B209D0
		protected override void InitGlimmer1BulletPool() {} // 0x0000000187024E90-0x0000000187025160
		protected override void InitGlimmer2BulletPool() {} // 0x0000000187025160-0x0000000187025430
		protected override void OnStart() {} // 0x0000000187025430-0x0000000187025C00
		protected bool OnBulletOverlapsEnemy_Mega(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000187025C00-0x0000000187025D70
		protected bool OnBulletOverlapsEnemy_Freeze(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000187025D70-0x0000000187025EA0
		protected bool OnBulletOverlapsEnemy_Shock(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000187025EA0-0x0000000187026100
		protected bool OnBulletOverlapsEnemy_NoDamageFreeze(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000187026100-0x0000000187026210
		protected bool OnBulletOverlapsEnemy_NoDamageSlow(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000187026210-0x0000000187026440
		protected override void Fire_DoTargeting() {} // 0x0000000187026440-0x0000000187026720
	}
}
