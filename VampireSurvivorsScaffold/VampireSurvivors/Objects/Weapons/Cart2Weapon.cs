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
	public class Cart2Weapon : Weapon // TypeDefIndex: 16151
	{
		// Fields
		private float _mul; // 0x158
		private bool _cooldownAffectedByMovement; // 0x15C
	
		// Properties
		public ArcadeBodyBounds CustomWorldBounds { get; private set; } // 0x00000001827668E0-0x00000001827668F0 0x00000001827668F0-0x0000000182766950
		public ArcadeBodyBounds CustomWorldBoundsHoming { get; private set; } // 0x00000001829176E0-0x00000001829176F0 0x0000000185F8DFD0-0x0000000185F8E030
	
		// Constructors
		public Cart2Weapon() {} // 0x0000000186F2F160-0x0000000186F2F1C0
	
		// Methods
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F2E3E0-0x0000000186F2E5B0
		private void UpdateCollisionBounds() {} // 0x0000000186F2E5B0-0x0000000186F2E810
		private void SetHomingCollisionBounds() {} // 0x0000000186F2E810-0x0000000186F2EA70
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977B92 */) {} // 0x0000000186F2EA70-0x0000000186F2EC60
		public override void CheckArcanas() {} // 0x0000000186F2EC60-0x0000000186F2F000
		public override int PBounces() => default; // 0x0000000186F2F000-0x0000000186F2F040
		public override void InternalUpdate() {} // 0x0000000186F2F040-0x0000000186F2F160
		public override void ResetFiringTimer() {} // 0x0000000186F292B0-0x0000000186F292D0
	}
}
