/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class AmmoAppalate_1Projectile : Projectile // TypeDefIndex: 15379
	{
		// Fields
		[SerializeField]
		private SpriteRenderer mainVisuals; // 0xD0
		[SerializeField]
		private SpriteTrail trail; // 0xD8
		private float _hitboxSize; // 0xE0
		private const float MAX_HOMING_ANGLE_CHANGE_PER_SECOND = 360f; // Metadata: 0x01977604
		private float penetrationAmount; // 0xE4
		protected EnemyController _targetEnemyController; // 0xE8
		private SpriteAnimation _anims; // 0xF0
		private VampireSurvivors.Framework.TimerSystem.Timer _prefireTimer; // 0xF8
		private Bounds _camBounds; // 0x100
		private Ex_Ammo1Weapon trueWeapon; // 0x118
		private float _IndexOffsetScaleFactor; // 0x120
	
		// Properties
		public override float ProjectileSpeed { get => default; } // 0x0000000186BAA1A0-0x0000000186BAA290 
	
		// Constructors
		public AmmoAppalate_1Projectile() {} // 0x0000000186BAAE30-0x0000000186BAAEA0
	
		// Methods
		protected override void Awake() {} // 0x0000000186BAA290-0x0000000186BAA320
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BAA320-0x0000000186BAA950
		private void SetupMechanics() {} // 0x0000000186BAA950-0x0000000186BAAB30
		public override void Despawn() {} // 0x0000000186BAAB30-0x0000000186BAABD0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186BAABD0-0x0000000186BAAE30
	}
}
