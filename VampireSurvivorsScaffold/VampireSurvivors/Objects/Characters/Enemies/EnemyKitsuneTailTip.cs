/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyKitsuneTailTip : EnemyController // TypeDefIndex: 17338
	{
		// Fields
		[SerializeField]
		private TrailRenderer _Trail; // 0x270
		private float _minAngleRotDeg; // 0x278
		private float _maxAngleRotDeg; // 0x27C
		private float _angleRng; // 0x280
		private float _attackTime; // 0x284
		private float _attackDelay; // 0x288
		private const float ATTACK_DELAY = 15000f; // Metadata: 0x01978466
		private int _headIndex; // 0x28C
		private Vector2 _targetVector; // 0x290
		private Vector2 _startingPosition; // 0x298
		private Vector2 _currentVector; // 0x2A0
		public float _AttackLerp; // 0x2A8
		private Vector2 _neckPosition; // 0x2AC
		private MultiTargetTween _attackTween; // 0x2B8
		private MultiTargetTween _retreatTween; // 0x2C0
		private MultiTargetTween _fadeTrailTween; // 0x2C8
		private Vector2 _headOffset; // 0x2D0
		private Vector2 _invHeadOffset; // 0x2D8
		private EnemyKitsune _trueOwner; // 0x2E0
	
		// Constructors
		public EnemyKitsuneTailTip() {} // 0x00000001872798F0-0x0000000187279990
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001872770B0-0x00000001872772B0
		private void InitTrail() {} // 0x00000001872772B0-0x0000000187277AD0
		public override void SetOwner(GameObject owner) {} // 0x0000000187277AD0-0x0000000187277BE0
		public void SetHeadIndex(int index) {} // 0x0000000187277BE0-0x0000000187277C10
		public void SetRandomStartingPosition() {} // 0x0000000187277C10-0x0000000187277DA0
		protected override void OnUpdate() {} // 0x0000000187277DA0-0x0000000187278890
		private void Attack() {} // 0x0000000187278890-0x0000000187278F00
		private void SetCurrentVector() {} // 0x0000000187278F00-0x00000001872790C0
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x0197845F */, float damageKb = 1f /* Metadata: 0x01978460 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x01978464 */, bool hasKb = true /* Metadata: 0x01978465 */) {} // 0x0000000180B15170-0x0000000180B15180
		protected override void Die() {} // 0x00000001872790C0-0x0000000187279140
		public override void Disappear() {} // 0x0000000187279140-0x0000000187279160
		protected void FadeTrails() {} // 0x0000000187279160-0x00000001872793B0
		private void SingleWarning(float x, float y) {} // 0x00000001872793B0-0x00000001872798F0
	}
}
