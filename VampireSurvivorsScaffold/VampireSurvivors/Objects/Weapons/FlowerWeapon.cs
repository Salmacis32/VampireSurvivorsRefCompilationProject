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
	public class FlowerWeapon : Weapon // TypeDefIndex: 16684
	{
		// Fields
		private float _mul; // 0x158
	
		// Constructors
		public FlowerWeapon() {} // 0x0000000187076E40-0x0000000187076EA0
	
		// Methods
		public override void CheckArcanas() {} // 0x0000000187076420-0x0000000187076680
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x0000000187076680-0x00000001870767B0
		public override void InternalUpdate() {} // 0x00000001870767B0-0x00000001870768B0
		private bool onBulletOverlapsBullet(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x00000001870768B0-0x0000000187076A20
		public override void ResetFiringTimer() {} // 0x0000000186F292B0-0x0000000186F292D0
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000187076A20-0x0000000187076E40
	}
}
