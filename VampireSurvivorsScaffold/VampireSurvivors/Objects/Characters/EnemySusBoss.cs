/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class EnemySusBoss : EnemyController // TypeDefIndex: 17175
	{
		// Fields
		private EnemySusBossTentacle _leftTentacle; // 0x270
		private EnemySusBossTentacle _leftTentacle2; // 0x278
		private EnemySusBossTentacle _rightTentacle; // 0x280
		private EnemySusBossTentacle _rightTentacle2; // 0x288
		private List<EnemyController> _meattList; // 0x290
		private PhaserSprite[] _miniTentacles; // 0x298
	
		// Constructors
		public EnemySusBoss() {} // 0x00000001871A3990-0x00000001871A3AC0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001871A03D0-0x00000001871A0E30
		private void OnRemoteEnemySpawned(EnemyController enemy) {} // 0x00000001871A0E30-0x00000001871A0E60
		private PhaserSprite CreateMiniTentacle(string type) => default; // 0x00000001871A0E60-0x00000001871A10C0
		private void LateUpdate() {} // 0x00000001871A10C0-0x00000001871A2570
		public override void Despawn() {} // 0x00000001871A2570-0x00000001871A2BB0
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x0197816E */, float damageKb = 1f /* Metadata: 0x0197816F */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x01978173 */, bool hasKb = true /* Metadata: 0x01978174 */) {} // 0x00000001871A2BB0-0x00000001871A3160
		private void OnMeatSpawned(EnemyController enemy) {} // 0x00000001871A3160-0x00000001871A3990
	}
}
