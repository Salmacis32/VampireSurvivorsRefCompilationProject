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
	public class EnemyStaticPot : EnemyController // TypeDefIndex: 17405
	{
		// Fields
		private MultiTargetTween _onEnterTween; // 0x270
		private float _invulDelay; // 0x278
		private float _hitsTaken; // 0x27C
		private bool _isInvul; // 0x280
		private float _maxHits; // 0x284
		private int _prevDepth; // 0x288
	
		// Constructors
		public EnemyStaticPot() {} // 0x00000001872A8860-0x00000001872A88D0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001872A7E70-0x00000001872A81C0
		protected override void OnUpdate() {} // 0x00000001872A81C0-0x00000001872A8320
		protected override void Die() {} // 0x00000001872A8320-0x00000001872A8360
		protected override void ProcessWiggle() {} // 0x0000000180B15170-0x0000000180B15180
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x01978520 */, float damageKb = 1f /* Metadata: 0x01978521 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x01978525 */, bool hasKb = true /* Metadata: 0x01978526 */) {} // 0x00000001872A8360-0x00000001872A8670
		public void ChangeFrame() {} // 0x00000001872A8670-0x00000001872A8860
	}
}
