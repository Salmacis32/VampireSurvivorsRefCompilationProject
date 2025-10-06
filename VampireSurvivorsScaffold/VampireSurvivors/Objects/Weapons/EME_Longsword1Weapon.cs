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
	public class EME_Longsword1Weapon : EME_Weapon // TypeDefIndex: 16590
	{
		// Fields
		private float swallowSliceInterval; // 0x1C8
		[SerializeField]
		protected Projectile _slicesPrefab; // 0x1D0
		private BulletPool _slicesPool; // 0x1D8
	
		// Properties
		protected override int EvolutionLevel { get => default; } // 0x00000001819170A0-0x00000001819170B0 
		protected override int _comboIndex1 { get => default; } // 0x0000000181BA4B30-0x0000000181BA4B40 
		protected override int _comboIndex2 { get => default; } // 0x0000000181E31950-0x0000000181E31960 
		protected override int _comboIndex3 { get => default; } // 0x0000000182008710-0x0000000182008720 
		protected override int ComboIndexFinal { get => default; } // 0x000000018700A1C0-0x000000018700A1D0 
	
		// Constructors
		public EME_Longsword1Weapon() {} // 0x0000000187009980-0x0000000187009990
	
		// Methods
		protected override WeaponType GetWeaponTypeForGlimmerLevel(int level) => default; // 0x00000001870184A0-0x00000001870184C0
		protected override void OnStart() {} // 0x00000001870184C0-0x00000001870187C0
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000187011100-0x0000000187011110
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B209C0-0x0000000180B209D0
		protected override void Fire_FireGlimmerProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) {} // 0x00000001870187C0-0x0000000187018C20
		private void FireSwallowSwing(Vector2 pos, float _amount) {} // 0x0000000187018C20-0x0000000187019110
		protected override void InitGlimmer2BulletPool() {} // 0x0000000187019110-0x0000000187019490
		protected bool OnBulletOverlapsEnemyHighDamage(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000187019490-0x0000000187019600
		public void FireLSSlashes(Vector2 pos, Projectile parent, float __amount = 1f /* Metadata: 0x01977D6E */) {} // 0x0000000187019600-0x0000000187019A30
	}
}
