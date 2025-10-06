/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_Spite2_Weapon : Weapon // TypeDefIndex: 16495
	{
		// Fields
		private bool _initialisedParticles; // 0x158
		private PhaserSprite _cursor; // 0x160
		private BulletPool _centralProjectilePool; // 0x168
		[SerializeField]
		private Projectile _centralProjectilePrefab; // 0x170
		private float _hahaSfxCounter; // 0x178
		private float _hahaSfxThreshold; // 0x17C
	
		// Properties
		public virtual float PlayerFacing { get => default; } // 0x0000000185C0CCB0-0x0000000185C0CCC0 
		public virtual bool IsPrimaryWeapon { get => default; } // 0x0000000181958370-0x0000000181958380 
	
		// Constructors
		public TP_Spite2_Weapon() {} // 0x0000000186FF5590-0x0000000186FF55E0
	
		// Methods
		public override float PPower() => default; // 0x0000000186FF4420-0x0000000186FF4530
		public override float PSpeed() => default; // 0x0000000186FF4530-0x0000000186FF4680
		protected override void Awake() {} // 0x0000000186FF4680-0x0000000186FF4960
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FC9200-0x0000000186FC9250
		public override void InternalUpdate() {} // 0x0000000186FA0DD0-0x0000000186FA0E70
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977CE3 */) {} // 0x0000000186FF4960-0x0000000186FF4A80
		public void FireProjectiles(Vector2 pos) {} // 0x0000000186FF4A80-0x0000000186FF5130
		private void PlayFiringSfx() {} // 0x0000000186FF5130-0x0000000186FF5590
	}
}
