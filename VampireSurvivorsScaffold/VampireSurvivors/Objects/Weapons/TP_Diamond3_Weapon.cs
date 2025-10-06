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
	public class TP_Diamond3_Weapon : Weapon // TypeDefIndex: 16315
	{
		// Fields
		public float AnglePerIndex; // 0x158
	
		// Constructors
		public TP_Diamond3_Weapon() {} // 0x0000000186F9EC80-0x0000000186F9ECD0
	
		// Methods
		public override float PAmount() => default; // 0x0000000186F9E850-0x0000000186F9E8B0
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F28A70-0x0000000186F28A90
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977C49 */) {} // 0x0000000186F9E8B0-0x0000000186F9E9A0
		public override void CheckArcanas() {} // 0x0000000186F9E9A0-0x0000000186F9EAE0
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F9EAE0-0x0000000186F9EC80
	}
}
