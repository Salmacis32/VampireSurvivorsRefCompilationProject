/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class EME_Kick1Weapon : EME_Weapon // TypeDefIndex: 16581
	{
		// Fields
		public float bonusPower; // 0x1C8
		public float overhealingTotal; // 0x1CC
		private BulletPool _dragonBpool; // 0x1D0
		private BulletPool _dragonCpool; // 0x1D8
		private BulletPool _dragonSpool; // 0x1E0
		[SerializeField]
		protected Projectile _DragonBPrefab; // 0x1E8
		[SerializeField]
		protected Projectile _DragonCPrefab; // 0x1F0
		[SerializeField]
		protected Projectile _DragonSPrefab; // 0x1F8
		private bool _cooldownAffectedByMovement; // 0x200
		private const float Mul = 166.66667f; // Metadata: 0x01977D6A
	
		// Properties
		protected override int EvolutionLevel { get => default; } // 0x0000000180B22260-0x0000000180B22270 
		protected override int _comboIndex1 { get => default; } // 0x0000000181BA4B30-0x0000000181BA4B40 
		protected override int _comboIndex2 { get => default; } // 0x00000001819170A0-0x00000001819170B0 
		protected override int _comboIndex3 { get => default; } // 0x0000000181EE0060-0x0000000181EE0070 
		public virtual bool IsEvolved { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		public virtual int WallBounces { get => default; } // 0x0000000180B21570-0x0000000180B21580 
	
		// Constructors
		public EME_Kick1Weapon() {} // 0x00000001870177C0-0x00000001870177E0
	
		// Methods
		public override float PPower() => default; // 0x0000000187015F30-0x0000000187016000
		protected override void OnStart() {} // 0x0000000187016000-0x0000000187016700
		public override void InternalUpdate() {} // 0x0000000187016700-0x0000000187016810
		public override void ResetFiringTimer() {} // 0x0000000186F292B0-0x0000000186F292D0
		protected override void Fire_FireGlimmerProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) {} // 0x0000000187016810-0x0000000187016CC0
		private void BonusOverHealDamage(float value, float rawValue) {} // 0x0000000187016CC0-0x0000000187016CF0
		protected override void InitGlimmer1BulletPool() {} // 0x0000000187016CF0-0x0000000187017070
		protected override void InitGlimmer2BulletPool() {} // 0x0000000187017070-0x00000001870173F0
		protected bool OnBulletOverlapsEnemyDamageX15(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x00000001870173F0-0x0000000187017560
		protected bool OnBulletOverlapsEnemyRecoveryBonus(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000187017560-0x00000001870176E0
		protected override WeaponType GetWeaponTypeForGlimmerLevel(int level) => default; // 0x00000001870176E0-0x0000000187017700
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B209C0-0x0000000180B209D0
		public override void CheckArcanas() {} // 0x0000000187017700-0x00000001870177C0
	}
}
