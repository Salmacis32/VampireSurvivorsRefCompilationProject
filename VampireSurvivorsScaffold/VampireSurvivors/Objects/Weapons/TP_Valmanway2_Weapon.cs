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
	public class TP_Valmanway2_Weapon : Weapon // TypeDefIndex: 16508
	{
		// Fields
		private const float BonusAreaGainedPerSecond = 0.1f; // Metadata: 0x01977D0B
		private const float BonusAreaLostPerSecond = 0.25f; // Metadata: 0x01977D0F
		private const float BonusAreaMax = 1f; // Metadata: 0x01977D13
		private float _bonusArea; // 0x158
	
		// Constructors
		public TP_Valmanway2_Weapon() {} // 0x0000000186FFC330-0x0000000186FFC380
	
		// Methods
		public override float PArea() => default; // 0x0000000186FFBEF0-0x0000000186FFBF50
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FFBF50-0x0000000186FFBF80
		public override void InternalUpdate() {} // 0x0000000186FFBF80-0x0000000186FFC050
		private void UpdateBonusArea() {} // 0x0000000186FFC050-0x0000000186FFC120
		public override void CheckArcanas() {} // 0x0000000186FFC120-0x0000000186FFC330
	}
}
