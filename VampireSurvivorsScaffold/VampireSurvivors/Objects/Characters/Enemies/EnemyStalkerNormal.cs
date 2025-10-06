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
	public class EnemyStalkerNormal : EnemyController // TypeDefIndex: 17399
	{
		// Fields
		private bool _hasLostTreasure; // 0x270
		private bool _done; // 0x271
		private float _sineF; // 0x274
		private Tween _onEnterTween; // 0x278
		private DG.Tweening.Sequence _onSineTween; // 0x280
		private GameObject _spritte; // 0x288
		private SpriteRenderer _ringSprite; // 0x290
	
		// Properties
		public Action OnDefeat { get; set; } // 0x0000000186A13420-0x0000000186A13430 0x0000000186A13430-0x0000000186A13490
	
		// Constructors
		public EnemyStalkerNormal() {} // 0x00000001872A5890-0x00000001872A58F0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001872A3F20-0x00000001872A49E0
		public override void Disappear() {} // 0x00000001872A49E0-0x00000001872A4BB0
		public override void Despawn() {} // 0x00000001872A4BB0-0x00000001872A4CB0
		protected override void OnUpdate() {} // 0x00000001872A4CB0-0x00000001872A50C0
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x0197850B */, float damageKb = 1f /* Metadata: 0x0197850C */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x01978510 */, bool hasKb = true /* Metadata: 0x01978511 */) {} // 0x00000001872A50C0-0x00000001872A5140
		private void SpawnSpritte() {} // 0x00000001872A5140-0x00000001872A54E0
		protected override void Die() {} // 0x00000001872A54E0-0x00000001872A5890
	}
}
