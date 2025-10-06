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
	public class GunsWeapon : Weapon // TypeDefIndex: 16706
	{
		// Fields
		protected bool _hasSecondSet; // 0x158
		protected Weapon _secondSet; // 0x160
		protected WeaponType _secondSetType; // 0x168
		protected WeaponType _counterWeaponType; // 0x16C
		protected Weapon _counterWeapon; // 0x170
		[NonSerialized]
		public BulletPool _explosionPool; // 0x178
		[SerializeField]
		private Projectile _explosionPrefab; // 0x180
	
		// Constructors
		public GunsWeapon() {} // 0x000000018708E040-0x000000018708E0B0
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x000000018708E0E0-0x000000018708E1C0
		public override void CheckArcanas() {} // 0x000000018708E1C0-0x000000018708E860
		public override bool LevelUp() => default; // 0x000000018708E860-0x000000018708E980
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977DE2 */) {} // 0x000000018708E980-0x000000018708ED00
		public override Projectile FireOneProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) => default; // 0x000000018708ED00-0x000000018708F1D0
		protected override bool OnSecondaryBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x000000018708F1D0-0x000000018708F390
	}
}
