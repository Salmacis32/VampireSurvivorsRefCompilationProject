/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyAGaea : EnemyController // TypeDefIndex: 17272
	{
		// Fields
		private float _bonusTimes; // 0x270
		private bool _isInvul; // 0x274
		private float _recoveredTimes; // 0x278
		private bool _hasBeenDefeated; // 0x27C
		private BgmType _savedBGM; // 0x280
		private BgmModType _savedBGMmod; // 0x284
		private PhaserSprite _ringSprite; // 0x288
		private VampireSurvivors.Framework.TimerSystem.Timer _summonEvent; // 0x290
	
		// Constructors
		public EnemyAGaea() {} // 0x00000001872295A0-0x00000001872295F0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001872275F0-0x0000000187227700
		protected override void OnRecycleEnemy() {} // 0x0000000187227700-0x00000001872278F0
		public void CalculateBonus() {} // 0x00000001872278F0-0x0000000187227C40
		public void StartInvulTimer() {} // 0x0000000187227C40-0x0000000187227E30
		public void RemoveInvul() {} // 0x0000000187227E30-0x0000000187227E40
		public void StartSummons() {} // 0x0000000187227E40-0x0000000187228040
		public void OnDefeat() {} // 0x0000000187228040-0x00000001872281B0
		public void GetEnemyToken() {} // 0x00000001872281B0-0x0000000187228AC0
		public void FakeRecover() {} // 0x0000000187228AC0-0x0000000187228D40
		public override void Despawn() {} // 0x0000000187228D40-0x0000000187228EC0
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x0197832C */, float damageKb = 1f /* Metadata: 0x0197832D */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x01978331 */, bool hasKb = true /* Metadata: 0x01978332 */) {} // 0x0000000187228EC0-0x0000000187228EF0
		protected override void OnUpdate() {} // 0x0000000187228EF0-0x0000000187229230
		protected override void Die() {} // 0x0000000187229230-0x00000001872295A0
	}
}
