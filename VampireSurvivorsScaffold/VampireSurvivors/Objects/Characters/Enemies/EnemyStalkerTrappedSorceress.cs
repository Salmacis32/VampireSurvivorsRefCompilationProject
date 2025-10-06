/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyStalkerTrappedSorceress : EnemyController // TypeDefIndex: 17400
	{
		// Fields
		private float _sineF; // 0x270
		private float _fireTime; // 0x274
		private float _fireDelay; // 0x278
		private EnemyType _bulletType; // 0x27C
		private int _activated; // 0x280
		private Tween _onEnterTween; // 0x288
		private Tween _onFireTimer; // 0x290
		private DG.Tweening.Sequence _onSineTween; // 0x298
		public Action OnDefeat; // 0x2A0
	
		// Constructors
		public EnemyStalkerTrappedSorceress() {} // 0x00000001872A6580-0x00000001872A65F0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001872A58F0-0x00000001872A6190
		public override void Disappear() {} // 0x00000001872A6190-0x00000001872A6350
		public override void Despawn() {} // 0x00000001872A6350-0x00000001872A63B0
		protected override void OnUpdate() {} // 0x00000001872A63B0-0x00000001872A64E0
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x01978512 */, float damageKb = 1f /* Metadata: 0x01978513 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x01978517 */, bool hasKb = true /* Metadata: 0x01978518 */) {} // 0x00000001872A64E0-0x00000001872A6510
		protected override void Die() {} // 0x00000001872A6510-0x00000001872A6580
		private void Fire() {} // 0x00000001872A3DA0-0x00000001872A3EB0
	}
}
