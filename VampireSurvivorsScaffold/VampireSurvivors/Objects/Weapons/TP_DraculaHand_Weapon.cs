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
	public class TP_DraculaHand_Weapon : Weapon // TypeDefIndex: 16326
	{
		// Fields
		private TP_DraculaHand_Projectile[] _hands; // 0x158
		private int _nextHandToMove; // 0x160
	
		// Constructors
		public TP_DraculaHand_Weapon() {} // 0x0000000186FA5ED0-0x0000000186FA5F20
	
		// Methods
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F9DBA0-0x0000000186F9DBD0
		public override void Fire() {} // 0x0000000180B15170-0x0000000180B15180
		public override void InternalUpdate() {} // 0x0000000186FA57C0-0x0000000186FA5CA0
		private void UpdateHands() {} // 0x0000000186FA5CA0-0x0000000186FA5E20
		public override void SetVisible(bool visible) {} // 0x0000000186FA5E20-0x0000000186FA5ED0
	}
}
