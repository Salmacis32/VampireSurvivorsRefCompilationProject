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
	public class TrapanoWeapon : Weapon // TypeDefIndex: 16791
	{
		// Fields
		private const float Mul = 16.666666f; // Metadata: 0x01977E46
	
		// Constructors
		public TrapanoWeapon() {} // 0x00000001870C39E0-0x00000001870C3A30
	
		// Methods
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x00000001870C3630-0x00000001870C3680
		public override void InternalUpdate() {} // 0x00000001870C2DD0-0x00000001870C2EA0
		public override void ResetFiringTimer() {} // 0x0000000186F292B0-0x0000000186F292D0
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x00000001870C3680-0x00000001870C3870
		public override void CheckArcanas() {} // 0x00000001870C3870-0x00000001870C39E0
	}
}
