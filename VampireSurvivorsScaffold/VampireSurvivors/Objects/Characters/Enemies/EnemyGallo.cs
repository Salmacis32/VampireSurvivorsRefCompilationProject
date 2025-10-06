/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using QFSW.MOP2;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyGallo : EnemyController // TypeDefIndex: 17319
	{
		// Fields
		[SerializeField]
		private GameObject _LancetPierceEffectPrefab; // 0x270
		[SerializeField]
		private GameObject _EnemyLancetPrefab; // 0x278
		private DiContainer _diContainer; // 0x280
		private ObjectPool _effectPool; // 0x288
		private ObjectPool _enemyLancetPool; // 0x290
		private int _keepMoving; // 0x298
		private const float Distance = 50000f; // Metadata: 0x01978440
		private float _fireTime; // 0x29C
		private float _fireDelay; // 0x2A0
		private float _previousDistance; // 0x2A4
		private int _ticks; // 0x2A8
		private List<float> _angles; // 0x2B0
		private List<Vector2> _targets; // 0x2B8
		private List<EnemyLancet> _enemyLancetProjectiles; // 0x2C0
		private EnemyType _bulletType; // 0x2C8
		private Tween _onEnterTween; // 0x2D0
		private Tween _onFireTimer; // 0x2D8
		private Tween _lancetTween; // 0x2E0
	
		// Constructors
		public EnemyGallo() {} // 0x0000000187266CF0-0x0000000187266DF0
	
		// Methods
		protected override void FakeConstruct() {} // 0x0000000187264930-0x00000001872649E0
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001872649E0-0x0000000187265050
		public override void Despawn() {} // 0x0000000187265050-0x00000001872651C0
		protected override void OnUpdate() {} // 0x00000001872651C0-0x0000000187265860
		public void OnLancetDied(EnemyLancet enemyLancet) {} // 0x0000000187265860-0x0000000187265930
		private void InitLancet() {} // 0x0000000187265930-0x0000000187265D70
		private void GenerateEffectPool() {} // 0x0000000187265D70-0x0000000187266090
		private void GenerateEnemyLancetPool() {} // 0x0000000187266090-0x0000000187266200
		protected override void Die() {} // 0x0000000187266200-0x0000000187266240
		private void Fire() {} // 0x0000000187266240-0x0000000187266870
		private void FireOneLancet(int index, float angle, Vector2 targetPos) {} // 0x0000000187266870-0x0000000187266B90
		protected void SetLancetPoolItemsDuration(float duration) {} // 0x0000000187266B90-0x0000000187266CF0
	}
}
