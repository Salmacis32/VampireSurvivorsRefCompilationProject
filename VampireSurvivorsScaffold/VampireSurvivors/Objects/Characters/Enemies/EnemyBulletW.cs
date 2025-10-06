/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using VampireSurvivors.Data;
using VampireSurvivors.Graphics.Blitters;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyBulletW : EnemyController // TypeDefIndex: 17279
	{
		// Fields
		private float _elapsed; // 0x270
		private float _gravity; // 0x274
		private float _wave1Alpha; // 0x278
		private List<Bob> _wave1Group; // 0x280
		private Blitter _blitter; // 0x288
		private Tween _waveTween; // 0x290
	
		// Constructors
		public EnemyBulletW() {} // 0x0000000187231630-0x0000000187231720
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x000000018722F7A0-0x000000018722FBE0
		public void Dismiss() {} // 0x000000018722FBE0-0x000000018722FDD0
		public override void Despawn() {} // 0x000000018722FDD0-0x000000018722FE20
		protected override void OnUpdate() {} // 0x000000018722FE20-0x0000000187230380
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x0197836E */, float damageKb = 1f /* Metadata: 0x0197836F */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x01978373 */, bool hasKb = true /* Metadata: 0x01978374 */) {} // 0x0000000180B15170-0x0000000180B15180
		protected override void ProcessWiggle() {} // 0x0000000180B15170-0x0000000180B15180
		private void MakeBlitter() {} // 0x0000000187230380-0x0000000187230FD0
		private void UpdateBlitter() {} // 0x0000000187230FD0-0x00000001872314E0
		protected override void UpdateDepth() {} // 0x00000001872314E0-0x0000000187231630
	}
}
