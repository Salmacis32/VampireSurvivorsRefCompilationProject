/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyDrownerNormal : EnemyController // TypeDefIndex: 17311
	{
		// Fields
		private VampireSurvivors.Objects.Stage _stage; // 0x270
		private bool _hasLostTreasure; // 0x278
		private bool _dismissed; // 0x279
		private bool _isFresh; // 0x27A
		private bool _done; // 0x27B
		private Tween _onEnterTween; // 0x280
		private Tween _onFireTimer; // 0x288
		private EnemyBulletW _bullet; // 0x290
		private GameObject _spritte; // 0x298
		private ParticleSystem _pfxEmitter; // 0x2A0
		private SpriteRenderer _ringSprite; // 0x2A8
		protected float _goNutsMinute; // 0x2B0
		protected float _distanceMultiplier; // 0x2B4
	
		// Properties
		public Action OnDefeat { get; set; } // 0x0000000186A134D0-0x0000000186A134E0 0x000000018725CE90-0x000000018725CEF0
	
		// Constructors
		public EnemyDrownerNormal() {} // 0x000000018725FFF0-0x0000000187260060
	
		// Methods
		protected override void FakeConstruct() {} // 0x000000018725CEF0-0x000000018725CFA0
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x000000018725CFA0-0x000000018725D8B0
		public override void Disappear() {} // 0x000000018725D8B0-0x000000018725DAB0
		protected override void OnUpdate() {} // 0x000000018725DAB0-0x000000018725DAC0
		public override void Despawn() {} // 0x000000018725DAC0-0x000000018725DC60
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x01978430 */, float damageKb = 1f /* Metadata: 0x01978431 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x01978435 */, bool hasKb = true /* Metadata: 0x01978436 */) {} // 0x000000018725DC60-0x000000018725DCE0
		protected override void Die() {} // 0x000000018725DCE0-0x000000018725E130
		private void SpawnBullet() {} // 0x000000018725E130-0x000000018725E2D0
		private void SpawnSpritte() {} // 0x000000018725E2D0-0x000000018725E670
		protected virtual float GetSpawnY() => default; // 0x000000018725E670-0x000000018725E770
		private void HandleDrownerUpdate() {} // 0x000000018725E770-0x000000018725F3A0
		private float Approach(float start, float end, float shift) => default; // 0x00000001869DF580-0x00000001869DF5A0
		private void Dismiss() {} // 0x000000018725F3A0-0x000000018725F440
		private void GenerateParticleSystems() {} // 0x000000018725F440-0x000000018725FFF0
	}
}
