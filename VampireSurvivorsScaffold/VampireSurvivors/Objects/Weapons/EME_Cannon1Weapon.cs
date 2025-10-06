/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class EME_Cannon1Weapon : EME_Weapon // TypeDefIndex: 16558
	{
		// Fields
		private const float QUANTISATION_STEP = 1f; // Metadata: 0x01977D5A
		private const float SECONDS_TO_ROTATE_AIM_360 = 0.9f; // Metadata: 0x01977D5E
		protected float _amount; // 0x1C8
		private float _firingAngleDegrees; // 0x1CC
		private List<float> _shuffledIndexes; // 0x1D0
	
		// Properties
		protected override int EvolutionLevel { get => default; } // 0x00000001819170A0-0x00000001819170B0 
		protected override int _comboIndex1 { get => default; } // 0x0000000181BA4B30-0x0000000181BA4B40 
		protected override int _comboIndex2 { get => default; } // 0x00000001819170A0-0x00000001819170B0 
		protected override int _comboIndex3 { get => default; } // 0x0000000181BA6070-0x0000000181BA6080 
		protected override int ComboIndexFinal { get => default; } // 0x000000018700A1C0-0x000000018700A1D0 
	
		// Constructors
		public EME_Cannon1Weapon() {} // 0x0000000187009980-0x0000000187009990
	
		// Methods
		protected override WeaponType GetWeaponTypeForGlimmerLevel(int level) => default; // 0x000000018700CF40-0x000000018700CF70
		protected override void InitGlimmer1BulletPool() {} // 0x000000018700CF70-0x000000018700D2F0
		protected override void InitGlimmer2BulletPool() {} // 0x000000018700D2F0-0x000000018700D670
		protected override void InitGlimmer3BulletPool() {} // 0x000000018700D670-0x000000018700D9F0
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x000000018700D9F0-0x000000018700DA20
		public override void InternalUpdate() {} // 0x000000018700DA20-0x000000018700DB20
		public override float PAmount() => default; // 0x000000018700DB20-0x000000018700DB80
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977D59 */) {} // 0x000000018700DB80-0x000000018700DD30
		protected override void Fire_FireBasicProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) {} // 0x000000018700DD30-0x000000018700E140
		private void GenerateShuffleIndexes(float amount) {} // 0x000000018700E140-0x000000018700E2C0
		protected override void Fire_FireGlimmerProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) {} // 0x000000018700E2C0-0x000000018700E560
		public override void CheckArcanas() {} // 0x0000000186F71380-0x0000000186F71480
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x000000018700E560-0x000000018700E860
		protected bool OnBulletOverlapsEnemyHighDamage(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x000000018700E860-0x000000018700E9D0
		public void ShowTinyDamage(float value, Vector3 position) {} // 0x000000018700E9D0-0x000000018700EAC0
	}
}
