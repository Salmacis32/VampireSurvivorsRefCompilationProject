/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyTricksterNormal : EnemyController // TypeDefIndex: 17414
	{
		// Fields
		private bool _hasLostTreasure; // 0x270
		private bool _done; // 0x271
		private float _sineF; // 0x274
		private VampireSurvivors.Framework.TimerSystem.Timer _gemSummonTimer; // 0x278
		private Tween _onEnterTween; // 0x280
		private Tween _onSineTween; // 0x288
		private GameObject _spritte; // 0x290
		private SpriteRenderer _ringSprite; // 0x298
	
		// Properties
		public Action OnDefeat { get; set; } // 0x0000000185EAA030-0x0000000185EAA040 0x0000000186AB2660-0x0000000186AB26C0
	
		// Constructors
		public EnemyTricksterNormal() {} // 0x00000001872B3510-0x00000001872B3560
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001872B1460-0x00000001872B1F60
		protected override void OnUpdate() {} // 0x00000001872B1F60-0x00000001872B2370
		public override void Disappear() {} // 0x00000001872B2370-0x00000001872B2540
		public override void Despawn() {} // 0x00000001872B2540-0x00000001872B2640
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x01978559 */, float damageKb = 1f /* Metadata: 0x0197855A */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x0197855E */, bool hasKb = true /* Metadata: 0x0197855F */) {} // 0x00000001872B2640-0x00000001872B26C0
		private void SpawnSpritte() {} // 0x00000001872B26C0-0x00000001872B2A60
		protected override void Die() {} // 0x00000001872B2A60-0x00000001872B2E10
		private void SummonGems(float? duration, int moreX, float moreZ, bool useStatic) {} // 0x00000001872B2E10-0x00000001872B3510
	}
}
