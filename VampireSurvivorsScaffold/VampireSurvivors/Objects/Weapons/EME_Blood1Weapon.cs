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
	public class EME_Blood1Weapon : EME_Weapon // TypeDefIndex: 16553
	{
		// Fields
		[SerializeField]
		protected Projectile _BasicBloodPrefab; // 0x1C8
		[SerializeField]
		protected Projectile _BloodRagePrefab; // 0x1D0
		[SerializeField]
		protected Projectile _ScarletPrefab; // 0x1D8
		protected BulletPool _basicBloodPool; // 0x1E0
		protected BulletPool _bloodRagePool; // 0x1E8
		protected BulletPool _scarletPool; // 0x1F0
	
		// Properties
		protected override int EvolutionLevel { get => default; } // 0x0000000180B22260-0x0000000180B22270 
		protected override int _comboIndex1 { get => default; } // 0x0000000181F01BA0-0x0000000181F01BB0 
		protected override int _comboIndex2 { get => default; } // 0x0000000181DEFEC0-0x0000000181DEFED0 
		protected override int _comboIndex3 { get => default; } // 0x0000000181B669B0-0x0000000181B669C0 
		protected override int ComboIndexFinal { get => default; } // 0x000000018700A1C0-0x000000018700A1D0 
	
		// Constructors
		public EME_Blood1Weapon() {} // 0x0000000187009980-0x0000000187009990
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x000000018700A1D0-0x000000018700A1F0
		protected override WeaponType GetWeaponTypeForGlimmerLevel(int level) => default; // 0x000000018700A1F0-0x000000018700A210
		protected override void OnStart() {} // 0x000000018700A210-0x000000018700ABB0
		protected override void Fire_FireBasicProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) {} // 0x000000018700ABB0-0x000000018700AC30
		protected override void Fire_FireGlimmerProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) {} // 0x000000018700AC30-0x000000018700AC50
		public void SpawnSpecialProjectiles(float2 position, BulletPool pool, float amountMul = 1f /* Metadata: 0x01977D48 */, float areaMul = 1f /* Metadata: 0x01977D4C */) {} // 0x000000018700AC50-0x000000018700B2D0
		public void DoBasicAttacks(float2 position) {} // 0x000000018700B2D0-0x000000018700B300
		public void DoBloodRage(float2 position) {} // 0x000000018700B300-0x000000018700B340
		public void DoScarletHarbinger(float2 position) {} // 0x000000018700B340-0x000000018700B370
		protected bool OnBulletOverlapsEnemyDamagex2(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x000000018700B370-0x000000018700B4E0
		protected bool OnBulletOverlapsEnemyDamageGreed(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x000000018700B4E0-0x000000018700B920
		public override void CheckArcanas() {} // 0x000000018700B920-0x000000018700B9E0
	}
}
