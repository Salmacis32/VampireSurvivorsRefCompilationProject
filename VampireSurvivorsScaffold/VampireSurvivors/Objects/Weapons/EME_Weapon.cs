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
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class EME_Weapon : Weapon // TypeDefIndex: 16644
	{
		// Fields
		[Header("Glimmer Visual Prefabs")]
		[SerializeField]
		[Tooltip("Prefab for the first glimmer projectile. Shouldn\'t be left blank.")]
		protected Projectile _Glimmer1Prefab; // 0x158
		[SerializeField]
		[Tooltip("Prefab for the second glimmer projectile. Can be left blank.")]
		protected Projectile _Glimmer2Prefab; // 0x160
		[SerializeField]
		[Tooltip("Prefab for the third glimmer projectile. Can be left blank.")]
		protected Projectile _Glimmer3Prefab; // 0x168
		[Header("Pre-Unlock Mechanics")]
		private float timeBeforeGlimmer; // 0x170
		private const float FIVE_SECOND_TIMER = 5000f; // Metadata: 0x01977DAC
		private float finalGlimmerTimer; // 0x174
		private VampireSurvivors.Framework.TimerSystem.Timer glimmerUnlockTimer; // 0x178
		private bool glimmerUnlocked; // 0x180
		protected BulletPool _glimmer1Pool; // 0x188
		protected BulletPool _glimmer2Pool; // 0x190
		protected BulletPool _glimmer3Pool; // 0x198
		private static List<TechniqueUsage> s_techniqueUsages; // 0x00
		private static float s_lastUpdateTime; // 0x08
		protected bool _hasGlimmeredFirstTime; // 0x1A0
		protected bool _hasProcessedFirstGlimmer; // 0x1A1
		protected bool _hasSentFirstGlimmer; // 0x1A2
		protected bool _hasAddedEvo; // 0x1A3
		protected bool _hasEvolution; // 0x1A4
		protected bool _ShouldGlimmerNextFire; // 0x1A5
		protected float _glimmerChance; // 0x1A8
		protected int _fireCounter; // 0x1AC
		protected int _lastFiredGlimmerLevel; // 0x1B0
		private readonly Dictionary<WeaponType, string> _glimmerNames; // 0x1B8
		public int OwnerComboModifier; // 0x1C0
		private bool _forceGlimmer; // 0x1C4
		public const int DefaultPoolSize = 20; // Metadata: 0x01977DB0
	
		// Properties
		protected virtual int GlimmerTier { get => default; } // 0x0000000180B209C0-0x0000000180B209D0 
		protected virtual float GlimmerChanceBaseValue { get => default; } // 0x000000018702D5C0-0x000000018702D5D0 
		protected virtual float GlimmerChanceEntropyValue { get => default; } // 0x000000018702D5D0-0x000000018702D5E0 
		protected virtual int EvolutionLevel { get => default; } // 0x00000001819170A0-0x00000001819170B0 
		protected virtual int _comboIndex1 { get => default; } // 0x0000000180B209C0-0x0000000180B209D0 
		protected virtual int _comboIndex2 { get => default; } // 0x0000000180B21570-0x0000000180B21580 
		protected virtual int _comboIndex3 { get => default; } // 0x0000000181BA4B30-0x0000000181BA4B40 
		protected int ComboIndex1 { get => default; } // 0x000000018702D5E0-0x000000018702D680 
		protected int ComboIndex2 { get => default; } // 0x000000018702D680-0x000000018702D720 
		protected int ComboIndex3 { get => default; } // 0x000000018702D720-0x000000018702D7C0 
		protected virtual int ComboIndexFinal { get => default; } // 0x000000018700FE40-0x000000018700FE50 
		protected override int ProjectilePoolSize { get => default; } // 0x0000000181B53370-0x0000000181B53380 
	
		// Constructors
		public EME_Weapon() {} // 0x0000000187030370-0x0000000187030460
	
		// Methods
		protected virtual WeaponType GetWeaponTypeForGlimmerLevel(int level) => default; // 0x0000000180B15D70-0x0000000180B15D80
		protected override void OnStart() {} // 0x0000000187011110-0x0000000187011160
		protected virtual void InitGlimmer1BulletPool() {} // 0x000000018702D7C0-0x000000018702DB30
		protected virtual void InitGlimmer2BulletPool() {} // 0x000000018702DB30-0x000000018702DEA0
		protected virtual void InitGlimmer3BulletPool() {} // 0x000000018702DEA0-0x000000018702E210
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x000000018702E210-0x000000018702E5B0
		public void SetGlimmerFirstTimeOnline() {} // 0x0000000186F8D300-0x0000000186F8D310
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977DA9 */) {} // 0x000000018702E5B0-0x000000018702EC90
		protected virtual void Fire_DoTargeting() {} // 0x000000018702EC90-0x000000018702ECF0
		protected virtual void Fire_DoAttacks(BulletPool glimmerPool, bool skipTriggers = false /* Metadata: 0x01977DAA */) {} // 0x000000018702ECF0-0x000000018702F0E0
		protected virtual void Fire_FireBasicProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) {} // 0x000000018702F0E0-0x000000018702F100
		protected virtual void Fire_FireGlimmerProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) {} // 0x000000018702F0E0-0x000000018702F100
		protected virtual BulletPool GetGlimmerBulletPool(int index, out int glimmerLevel, bool forcedGlimmer = false /* Metadata: 0x01977DAB */) {
			glimmerLevel = default;
			return default;
		} // 0x000000018702F100-0x000000018702F2E0
		protected bool GlimmerChecks() => default; // 0x000000018702F2E0-0x000000018702F5D0
		protected virtual float FinalGlimmerChance() => default; // 0x000000018702F5D0-0x000000018702F620
		public override bool LevelUp() => default; // 0x000000018702F620-0x000000018702F670
		protected virtual bool AddEvolutionChecks() => default; // 0x000000018702F670-0x000000018702F750
		protected virtual BulletPool GetTopLevelTechnique() => default; // 0x000000018702F750-0x000000018702F7C0
		protected virtual int GetTopLevelTechniqueComboIndex() => default; // 0x000000018702F7C0-0x000000018702F830
		public List<EnemyController> Closest(VampireSurvivors.Objects.Characters.CharacterController source, PhysicsGroup targets) => default; // 0x000000018702F830-0x000000018702FB70
		private string GetGlimmerName(WeaponType weaponType) => default; // 0x000000018702FB70-0x000000018702FCE0
		private void RunGlimmerAnimation() {} // 0x000000018702FCE0-0x0000000187030140
		private bool HandleAnyTechniqueTriggers(BulletPool glimmerPool, int glimmerLevel, bool isGlimmering) => default; // 0x0000000187030140-0x0000000187030340
		public override void Cleanup() {} // 0x0000000187030340-0x0000000187030370
	}
}
