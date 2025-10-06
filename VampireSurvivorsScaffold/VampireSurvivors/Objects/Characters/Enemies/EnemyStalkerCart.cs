/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyStalkerCart : EnemyController // TypeDefIndex: 17397
	{
		// Fields
		protected float2 _CartOffset; // 0x270
		private bool _hasLostTreasure; // 0x278
		private bool _done; // 0x279
		private float _sineF; // 0x27C
		private DG.Tweening.Sequence _onSineTween; // 0x280
		private GameObject _spritte; // 0x288
		private PhaserSprite _frontSprite; // 0x290
		private PhaserSprite _backSprite; // 0x298
	
		// Constructors
		public EnemyStalkerCart() {} // 0x00000001872A3210-0x00000001872A3280
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001872A1890-0x00000001872A1F60
		public void MulSpeed(float factor) {} // 0x000000018722B2C0-0x000000018722B2F0
		public override void Disappear() {} // 0x00000001872A1F60-0x00000001872A2130
		public override void Despawn() {} // 0x00000001872A2130-0x00000001872A2380
		protected override void OnUpdate() {} // 0x00000001872A2380-0x00000001872A2870
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x01978504 */, float damageKb = 1f /* Metadata: 0x01978505 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x01978509 */, bool hasKb = true /* Metadata: 0x0197850A */) {} // 0x00000001872A2870-0x00000001872A2E70
		private void SpawnSpritte() {} // 0x00000001872A2E70-0x00000001872A3210
	}
}
