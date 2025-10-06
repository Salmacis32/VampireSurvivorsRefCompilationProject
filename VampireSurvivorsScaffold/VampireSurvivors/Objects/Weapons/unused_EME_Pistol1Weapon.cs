/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class unused_EME_Pistol1Weapon : EME_Weapon // TypeDefIndex: 16650
	{
		// Fields
		private VampireSurvivors.Framework.TimerSystem.Timer _prefireTimer; // 0x1C8
		private BulletPool _bdShotPool; // 0x1D0
		[SerializeField]
		protected Projectile _bdShotPrefsb; // 0x1D8
	
		// Properties
		protected override int EvolutionLevel { get => default; } // 0x0000000180B22260-0x0000000180B22270 
		protected override int _comboIndex1 { get => default; } // 0x0000000180B209C0-0x0000000180B209D0 
		protected override int _comboIndex2 { get => default; } // 0x0000000181BA4B30-0x0000000181BA4B40 
		protected override int ComboIndexFinal { get => default; } // 0x000000018700A1C0-0x000000018700A1D0 
	
		// Constructors
		public unused_EME_Pistol1Weapon() {} // 0x0000000187009980-0x0000000187009990
	
		// Methods
		public override float PSpeed() => default; // 0x0000000187032070-0x00000001870321C0
		protected override WeaponType GetWeaponTypeForGlimmerLevel(int level) => default; // 0x000000018701EF50-0x000000018701EF70
		protected override void OnStart() {} // 0x00000001870321C0-0x00000001870324C0
		public void DoBoundingShotExplosionAt(Vector2 position) {} // 0x00000001870324C0-0x0000000187032500
		protected override void Fire_FireBasicProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) {} // 0x000000018702F0E0-0x000000018702F100
		protected override void Fire_FireGlimmerProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) {} // 0x0000000187032500-0x0000000187032740
		private void FireCrossShotAfterDelay(Vector2 pos, int index, BulletPool pool) {} // 0x0000000187032740-0x0000000187032830
		public override void ParadoxFire() {} // 0x0000000187032830-0x0000000187032970
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B21570-0x0000000180B21580
	}
}
