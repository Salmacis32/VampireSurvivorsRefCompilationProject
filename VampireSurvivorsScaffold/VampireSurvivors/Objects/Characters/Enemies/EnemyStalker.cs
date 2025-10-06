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
	public class EnemyStalker : EnemyController // TypeDefIndex: 17396
	{
		// Fields
		private bool _hasLostTreasure; // 0x270
		private bool _done; // 0x271
		private float _sineF; // 0x274
		private DG.Tweening.Sequence _onSineTween; // 0x278
		private GameObject _spritte; // 0x280
	
		// Constructors
		public EnemyStalker() {} // 0x00000001872A1830-0x00000001872A1890
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001872A02F0-0x00000001872A07C0
		public void MulSpeed(float factor) {} // 0x000000018722B2C0-0x000000018722B2F0
		public override void Disappear() {} // 0x00000001872A07C0-0x00000001872A0990
		public override void Despawn() {} // 0x00000001872A0990-0x00000001872A0A90
		protected override void OnUpdate() {} // 0x00000001872A0A90-0x00000001872A0EA0
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x019784FD */, float damageKb = 1f /* Metadata: 0x019784FE */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x01978502 */, bool hasKb = true /* Metadata: 0x01978503 */) {} // 0x00000001872A0EA0-0x00000001872A1490
		private void SpawnSpritte() {} // 0x00000001872A1490-0x00000001872A1830
	}
}
