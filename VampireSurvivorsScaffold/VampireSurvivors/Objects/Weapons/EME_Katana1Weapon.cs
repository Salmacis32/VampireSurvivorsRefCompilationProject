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
	public class EME_Katana1Weapon : EME_Weapon // TypeDefIndex: 16578
	{
		// Fields
		private float MaxBonus; // 0x1C8
		private float MaxEnemies; // 0x1CC
		private float currentBonus; // 0x1D0
		[Header("Additional Projectile Prefabs")]
		[SerializeField]
		private Projectile _gravediggerRockPrefab; // 0x1D8
		[SerializeField]
		private Projectile _scatteredPetalsMiniSlashPrefab; // 0x1E0
		[SerializeField]
		private Projectile _scatteredPetalsMoonPrefab; // 0x1E8
		protected BulletPool _gravediggerRockPool; // 0x1F0
		protected BulletPool _scatteredPetalsMiniSlashPool; // 0x1F8
		protected BulletPool _scatteredPetalsMoonPool; // 0x200
		private VampireSurvivors.Framework.TimerSystem.Timer _glimmerShotTimer; // 0x208
		private const float _scatteredPetalsMaxArea = 2.5f; // Metadata: 0x01977D66
		private float2 _scatteredPetalsOffsetFromPlayer; // 0x210
	
		// Properties
		public BulletPool GravediggerRockPool { get => default; } // 0x0000000186747270-0x0000000186747280 
		public float ScatteredPetalsMaxArea { get => default; } // 0x0000000187014A10-0x0000000187014A20 
		public float2 ScatteredPetalsOffsetFromPlayer { get => default; } // 0x0000000187014A20-0x0000000187014A40 
		protected override int EvolutionLevel { get => default; } // 0x0000000180B22260-0x0000000180B22270 
		protected override int _comboIndex1 { get => default; } // 0x0000000181BA4B30-0x0000000181BA4B40 
		protected override int _comboIndex2 { get => default; } // 0x0000000181B5A2D0-0x0000000181B5A2E0 
		protected override int _comboIndex3 { get => default; } // 0x0000000181EE0060-0x0000000181EE0070 
		protected override int ComboIndexFinal { get => default; } // 0x000000018700A1C0-0x000000018700A1D0 
	
		// Constructors
		public EME_Katana1Weapon() {} // 0x0000000187015DD0-0x0000000187015DF0
	
		// Methods
		public override float PPower() => default; // 0x0000000187014A40-0x0000000187014AD0
		protected override WeaponType GetWeaponTypeForGlimmerLevel(int level) => default; // 0x0000000187014AD0-0x0000000187014AF0
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B209C0-0x0000000180B209D0
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000187014AF0-0x0000000187014B20
		private void LateUpdate() {} // 0x0000000187014B20-0x0000000187014BE0
		protected override void OnStart() {} // 0x0000000187014BE0-0x00000001870153C0
		public virtual void FireScatteredPetalsMiniSlashes() {} // 0x00000001870153C0-0x0000000187015640
		public void FireScatteredPetalsMoon(Vector2 position, int index, Action onProjectileDespawn) {} // 0x0000000187015640-0x0000000187015890
		public override void CheckArcanas() {} // 0x0000000186FDD1D0-0x0000000186FDD290
		public override void Cleanup() {} // 0x0000000187015890-0x00000001870158E0
		protected override void InitGlimmer1BulletPool() {} // 0x00000001870158E0-0x0000000187015C60
		protected bool OnBulletOverlapsEnemyHighDamage(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000187015C60-0x0000000187015DD0
	}
}
