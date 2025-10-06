/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class VentWeapon : Weapon // TypeDefIndex: 16221
	{
		// Fields
		private int _ventLimit; // 0x158
	
		// Constructors
		public VentWeapon() {} // 0x0000000186F6B730-0x0000000186F6B790
	
		// Methods
		protected override void Awake() {} // 0x0000000186F6AB60-0x0000000186F6AB70
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F6AB70-0x0000000186F6AC30
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BCF */) {} // 0x0000000186F6AC30-0x0000000186F6B380
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F6B380-0x0000000186F6B5F0
		protected override bool OnBulletOverlapsDestructible(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F6B5F0-0x0000000186F6B730
		protected override bool OnBulletOverlapsPlayer(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000180B15290-0x0000000180B152A0
	}
}
