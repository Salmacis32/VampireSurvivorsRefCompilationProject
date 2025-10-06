/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyMaddener : EnemyAlias // TypeDefIndex: 17348
	{
		// Fields
		[SerializeField]
		private GameObject _SingleWarningPrefab; // 0x278
		private bool _isSpinning; // 0x280
		private bool _isRunning; // 0x281
		private bool _isPursuing; // 0x282
		private bool _rosaried; // 0x283
		private float _spinAngle; // 0x284
		private float _spinRadius; // 0x288
		private float _runningTweenValue; // 0x28C
		private Tween _lowerScreenTween; // 0x290
		private Tween _spinningTween; // 0x298
		private DG.Tweening.Sequence _killTween; // 0x2A0
		private Bounds _camBounds; // 0x2A8
	
		// Constructors
		public EnemyMaddener() {} // 0x000000018722AA00-0x000000018722AA50
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x000000018727D430-0x000000018727D5E0
		protected override void OnUpdate() {} // 0x000000018727D5E0-0x000000018727DAD0
		public void Spinnn() {} // 0x000000018727DAD0-0x000000018727DD30
		public void StartLowerScreenMotion() {} // 0x000000018727DD30-0x000000018727DF90
		public void StartPursuit() {} // 0x000000018727DF90-0x000000018727E270
		public void StartKill() {} // 0x000000018727E270-0x000000018727E5C0
		public void StopAllTimers() {} // 0x000000018727E5C0-0x000000018727E600
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x01978490 */, float damageKb = 1f /* Metadata: 0x01978491 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x01978495 */, bool hasKb = true /* Metadata: 0x01978496 */) {} // 0x000000018727E600-0x000000018727EC80
		protected override void UpdateDepth() {} // 0x000000018727EC80-0x000000018727ED60
		private void StartRunningTween() {} // 0x000000018727ED60-0x000000018727EFF0
		private void ExecuteKill() {} // 0x000000018727EFF0-0x000000018727F3B0
		private void SingleWarning(Vector2 pos) {} // 0x000000018727F3B0-0x000000018727FBF0
	}
}
