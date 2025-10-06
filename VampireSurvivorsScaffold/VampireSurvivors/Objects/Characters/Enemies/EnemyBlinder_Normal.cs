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
	public class EnemyBlinder_Normal : EnemyController // TypeDefIndex: 17276
	{
		// Fields
		private bool _done; // 0x270
		private float _sineF; // 0x274
		private Tween _onEnterTween; // 0x278
		private DG.Tweening.Sequence _onSineTween; // 0x280
		private GameObject _spritte; // 0x288
		private SpriteRenderer _ringSprite; // 0x290
	
		// Properties
		public Action OnDefeat { get; set; } // 0x0000000186A13420-0x0000000186A13430 0x0000000186A13430-0x0000000186A13490
	
		// Constructors
		public EnemyBlinder_Normal() {} // 0x000000018722DE00-0x000000018722DE60
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x000000018722C4C0-0x000000018722CF70
		public override void Disappear() {} // 0x000000018722CF70-0x000000018722D140
		public override void Despawn() {} // 0x000000018722D140-0x000000018722D240
		protected override void OnUpdate() {} // 0x000000018722D240-0x000000018722D640
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x01978351 */, float damageKb = 1f /* Metadata: 0x01978352 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x01978356 */, bool hasKb = true /* Metadata: 0x01978357 */) {} // 0x000000018722D640-0x000000018722D6B0
		private void SpawnSpritte() {} // 0x000000018722D6B0-0x000000018722DA50
		protected override void Die() {} // 0x000000018722DA50-0x000000018722DE00
	}
}
