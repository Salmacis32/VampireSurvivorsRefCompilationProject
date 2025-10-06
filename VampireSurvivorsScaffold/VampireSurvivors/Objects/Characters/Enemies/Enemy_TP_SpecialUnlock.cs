/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class Enemy_TP_SpecialUnlock : EnemyController // TypeDefIndex: 17263
	{
		// Fields
		protected List<WeaponType> WeaponsToHitWith; // 0x270
	
		// Constructors
		public Enemy_TP_SpecialUnlock() {} // 0x00000001872261D0-0x00000001872262C0
	
		// Methods
		protected virtual void OnKilledBySelectedWeapon() {} // 0x0000000180B15170-0x0000000180B15180
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x01978325 */, float damageKb = 1f /* Metadata: 0x01978326 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x0197832A */, bool hasKb = true /* Metadata: 0x0197832B */) {} // 0x0000000187225D30-0x00000001872261D0
	}
}
