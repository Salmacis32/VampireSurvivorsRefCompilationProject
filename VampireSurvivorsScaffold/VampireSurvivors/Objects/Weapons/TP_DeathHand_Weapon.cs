/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_DeathHand_Weapon : Weapon // TypeDefIndex: 16311
	{
		// Fields
		private TP_DeathHand_Projectile[] _hands; // 0x158
		private int _nextHandToMove; // 0x160
	
		// Constructors
		public TP_DeathHand_Weapon() {} // 0x0000000186F9E1D0-0x0000000186F9E220
	
		// Methods
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F9DBA0-0x0000000186F9DBD0
		public override void Fire() {} // 0x0000000180B15170-0x0000000180B15180
		protected override void OnUpdate() {} // 0x0000000186F9DBD0-0x0000000186F9DF70
		private void UpdateHands() {} // 0x0000000186F9DF70-0x0000000186F9E150
		public override void SetVisible(bool visible) {} // 0x0000000186F9E150-0x0000000186F9E1D0
	}
}
