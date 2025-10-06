/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyShard : EnemyController // TypeDefIndex: 17380
	{
		// Fields
		private MultiTargetTween _onEnterTween; // 0x270
	
		// Constructors
		public EnemyShard() {} // 0x0000000187298280-0x00000001872982D0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x0000000187297C90-0x0000000187297EE0
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x019784E2 */, float damageKb = 1f /* Metadata: 0x019784E3 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x019784E7 */, bool hasKb = true /* Metadata: 0x019784E8 */) {} // 0x00000001871F3DE0-0x00000001871F3E00
		protected override void Die() {} // 0x0000000187297EE0-0x00000001872981E0
		private void BlockInput() {} // 0x00000001872981E0-0x0000000187298280
	}
}
