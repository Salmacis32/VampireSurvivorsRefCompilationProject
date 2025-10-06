/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class CherryStarsWeapon : CherryWeapon // TypeDefIndex: 16153
	{
		// Fields
		private CherryStarProjectile _bulletA; // 0x160
		private bool _hasBullets; // 0x168
		private bool _hasImage; // 0x169
		private bool _hasCharacterImage; // 0x16A
		private PhaserSprite _cow; // 0x170
		private BulletPool _explosionPool; // 0x178
		private BulletPool _drawerPool; // 0x180
		private float _critChance; // 0x188
	
		// Constructors
		public CherryStarsWeapon() {} // 0x0000000186F306E0-0x0000000186F30740
	
		// Methods
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F2F360-0x0000000186F2F420
		public override float SecondaryPPower() => default; // 0x0000000186F2F420-0x0000000186F2F5F0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977B93 */) {} // 0x0000000186F2F5F0-0x0000000186F2F630
		public void ShootStarAt(float x, float y, int index) {} // 0x0000000186F2F630-0x0000000186F2F670
		public void InitBullets() {} // 0x0000000186F2F670-0x0000000186F2FD00
		protected override void OnUpdate() {} // 0x0000000186F2FD00-0x0000000186F2FD30
		private void InitImage() {} // 0x0000000186F2FD30-0x0000000186F30010
		private void LateUpdate() {} // 0x0000000186F30010-0x0000000186F300C0
		private void UpdateImage() {} // 0x0000000186F300C0-0x0000000186F30160
		public override void Cleanup() {} // 0x0000000186F30160-0x0000000186F30310
		public override void SetVisible(bool visible) {} // 0x0000000186F30310-0x0000000186F306E0
	}
}
