/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class MirageRobeWeapon : Weapon // TypeDefIndex: 16735
	{
		// Fields
		protected bool collides; // 0x158
		private SpriteRenderer _ringSprite; // 0x160
		private MultiTargetTween _ringTween; // 0x168
		private MultiTargetTween _ringTween2; // 0x170
		private Collider ProjectileOnProjectileCollider; // 0x178
	
		// Constructors
		public MirageRobeWeapon() {} // 0x000000018709ECF0-0x000000018709ED50
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x000000018709ED50-0x000000018709F090
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977E08 */) {} // 0x000000018709F090-0x000000018709F5F0
		protected override void OnStart() {} // 0x000000018709F5F0-0x000000018709F720
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x000000018709F720-0x000000018709FA20
		public override float SecondaryPPower() => default; // 0x0000000184E5D5E0-0x0000000184E5D600
		public override void CheckArcanas() {} // 0x000000018709FA20-0x000000018709FBB0
	}
}
