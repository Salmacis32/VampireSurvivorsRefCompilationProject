/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class EME_Spear1Weapon : EME_Weapon // TypeDefIndex: 16632
	{
		// Fields
		[Header("Triumvirate Transforms")]
		[SerializeField]
		protected Transform TriumvirateContainer; // 0x1C8
		[SerializeField]
		protected List<Transform> TriumvirateSpawnPoints; // 0x1D0
		private const float BaseOffsetY = 0.16f; // Metadata: 0x01977D86
		private List<float> _basicAttackRepeatOffsets; // 0x1E0
		private const float StardustOffsetAngleMin = 105f; // Metadata: 0x01977D8A
		private const float StardustOffsetAngleMax = 170f; // Metadata: 0x01977D8E
		private VampireSurvivors.Framework.TimerSystem.Timer _glimmerShotTimer; // 0x1E8
	
		// Properties
		protected override int EvolutionLevel { get => default; } // 0x00000001819170A0-0x00000001819170B0 
		protected override int _comboIndex1 { get => default; } // 0x0000000181BA4B30-0x0000000181BA4B40 
		protected override int _comboIndex2 { get => default; } // 0x00000001819170A0-0x00000001819170B0 
		protected override int _comboIndex3 { get => default; } // 0x0000000181BA6070-0x0000000181BA6080 
		protected override int ComboIndexFinal { get => default; } // 0x000000018700A1C0-0x000000018700A1D0 
		public Vector2 CachedPlayerDirection { get; set; } // 0x0000000187027410-0x0000000187027430 0x0000000187027430-0x0000000187027440
	
		// Constructors
		public EME_Spear1Weapon() {} // 0x0000000187028830-0x0000000187028B20
	
		// Methods
		protected override WeaponType GetWeaponTypeForGlimmerLevel(int level) => default; // 0x0000000187027440-0x0000000187027470
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B209C0-0x0000000180B209D0
		protected override void Fire_FireBasicProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) {} // 0x0000000187027470-0x0000000187027560
		protected override void Fire_FireGlimmerProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) {} // 0x0000000187027560-0x0000000187027C60
		private Vector2 GetBasicProjectilePosition(float offsetPos) => default; // 0x0000000187027C60-0x0000000187027DA0
		private Vector2 GetStarDustProjectilePosition(float offsetAngle) => default; // 0x0000000187027DA0-0x0000000187027EC0
		private float GetBasicProjectileOffset(int index) => default; // 0x0000000187027EC0-0x0000000187027F50
		private float GetStardustProjectileOffset(int index) => default; // 0x0000000187027F50-0x0000000187027FC0
		public override void CheckArcanas() {} // 0x000000018700B920-0x000000018700B9E0
		public override void Cleanup() {} // 0x000000018700EEC0-0x000000018700EF10
		protected override void InitGlimmer1BulletPool() {} // 0x0000000187027FC0-0x0000000187028340
		protected override void InitGlimmer3BulletPool() {} // 0x0000000187028340-0x00000001870286C0
		protected bool OnBulletOverlapsEnemyHighDamage(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x00000001870286C0-0x0000000187028830
	}
}
