/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyBlinder : EnemyController // TypeDefIndex: 17275
	{
		// Fields
		private bool _hasLostTreasure; // 0x270
		private bool _done; // 0x271
		private float _sineF; // 0x274
		private DG.Tweening.Sequence _onSineTween; // 0x278
		private GameObject _spritte; // 0x280
	
		// Constructors
		public EnemyBlinder() {} // 0x000000018722C460-0x000000018722C4C0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x000000018722AE00-0x000000018722B2C0
		public void MulSpeed(float factor) {} // 0x000000018722B2C0-0x000000018722B2F0
		public override void Disappear() {} // 0x000000018722B2F0-0x000000018722B4C0
		public override void Despawn() {} // 0x000000018722B4C0-0x000000018722B5C0
		protected override void OnUpdate() {} // 0x000000018722B5C0-0x000000018722B9D0
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x0197834A */, float damageKb = 1f /* Metadata: 0x0197834B */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x0197834F */, bool hasKb = true /* Metadata: 0x01978350 */) {} // 0x000000018722B9D0-0x000000018722C0C0
		private void SpawnSpritte() {} // 0x000000018722C0C0-0x000000018722C460
	}
}
