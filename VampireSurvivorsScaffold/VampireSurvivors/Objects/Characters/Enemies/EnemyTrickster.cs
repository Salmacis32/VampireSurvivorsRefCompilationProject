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
	public class EnemyTrickster : EnemyController // TypeDefIndex: 17412
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
		public EnemyTrickster() {} // 0x00000001872B1160-0x00000001872B11B0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001872AEF90-0x00000001872AFA60
		protected override void OnUpdate() {} // 0x00000001872AFA60-0x00000001872AFDE0
		public override void Disappear() {} // 0x00000001872AFDE0-0x00000001872B0030
		public override void Despawn() {} // 0x00000001872B0030-0x00000001872B0130
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x01978552 */, float damageKb = 1f /* Metadata: 0x01978553 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x01978557 */, bool hasKb = true /* Metadata: 0x01978558 */) {} // 0x00000001872B0130-0x00000001872B0190
		private void SpawnSpritte() {} // 0x00000001872B0190-0x00000001872B0530
		protected override void Die() {} // 0x00000001872B0530-0x00000001872B08E0
		private void SummonAll(float? duration, int moreX, float moreZ) {} // 0x00000001872B08E0-0x00000001872B1160
	}
}
