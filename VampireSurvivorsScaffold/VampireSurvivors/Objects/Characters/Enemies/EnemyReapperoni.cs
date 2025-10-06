/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyReapperoni : EnemyController // TypeDefIndex: 17373
	{
		// Fields
		private bool _legitKill; // 0x270
	
		// Constructors
		public EnemyReapperoni() {} // 0x0000000187293250-0x00000001872932A0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x0000000187292D30-0x0000000187292D60
		protected override void Die() {} // 0x0000000187292D60-0x0000000187292DA0
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x019784BF */, float damageKb = 1f /* Metadata: 0x019784C0 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x019784C4 */, bool hasKb = true /* Metadata: 0x019784C5 */) {} // 0x0000000187292DA0-0x0000000187292DF0
		private void HandleLegitKill() {} // 0x0000000187292DF0-0x0000000187293250
	}
}
