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

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class EME_DualSwordsWeapon : EME_Weapon // TypeDefIndex: 16565
	{
		// Properties
		protected override int EvolutionLevel { get => default; } // 0x0000000180B22260-0x0000000180B22270 
		protected override int _comboIndex1 { get => default; } // 0x0000000181BA4B30-0x0000000181BA4B40 
		protected override int _comboIndex2 { get => default; } // 0x00000001819170A0-0x00000001819170B0 
		protected override int _comboIndex3 { get => default; } // 0x0000000181EE0060-0x0000000181EE0070 
		protected override int ComboIndexFinal { get => default; } // 0x0000000187009350-0x0000000187009360 
	
		// Constructors
		public EME_DualSwordsWeapon() {} // 0x0000000187009980-0x0000000187009990
	
		// Methods
		public override float PPower() => default; // 0x0000000187010F90-0x0000000187011060
		protected override WeaponType GetWeaponTypeForGlimmerLevel(int level) => default; // 0x0000000187011060-0x0000000187011080
		protected override float FinalGlimmerChance() => default; // 0x0000000187011080-0x0000000187011100
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000187011100-0x0000000187011110
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B209C0-0x0000000180B209D0
		protected override void OnStart() {} // 0x0000000187011110-0x0000000187011160
		protected override void Fire_FireBasicProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) {} // 0x0000000187011160-0x00000001870111F0
		protected override void Fire_FireGlimmerProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) {} // 0x0000000187011160-0x00000001870111F0
		public override void InternalUpdate() {} // 0x0000000186F98360-0x0000000186F98370
		protected override void InitGlimmer1BulletPool() {} // 0x00000001870111F0-0x0000000187011570
		protected override void InitGlimmer2BulletPool() {} // 0x0000000187011570-0x00000001870118F0
		protected bool OnBulletOverlapsEnemyNormalDamage(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x00000001870118F0-0x0000000187011AB0
	}
}
