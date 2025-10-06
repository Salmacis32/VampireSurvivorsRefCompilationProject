/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyBeelzebubBee : EnemyController // TypeDefIndex: 17226
	{
		// Fields
		private float2 _startPos; // 0x270
		private int _groupIndex; // 0x278
		private int _groupSize; // 0x27C
		private EnemyBeelzebub _parentBoss; // 0x280
		private float _age; // 0x288
		private BeeState _state; // 0x28C
		private float2 _attackVector; // 0x290
		private bool _hasExplosions; // 0x298
		private List<PhaserSprite> explosionSprites; // 0x2A0
		private float offsetRadius; // 0x2A8
		private List<VampireSurvivors.Framework.TimerSystem.Timer> explosionTimers; // 0x2B0
		private int ExplosionsNumber; // 0x2B8
		private bool _initialized; // 0x2BC
	
		// Nested types
		private enum BeeState // TypeDefIndex: 17222
		{
			Entering = 0,
			Circling = 1,
			Attacking = 2
		}
	
		// Constructors
		public EnemyBeelzebubBee() {} // 0x00000001871F25D0-0x00000001871F26D0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001871F0AA0-0x00000001871F0D50
		[Command]
		public void OnlineInit(int groupIndex, int groupSize, float circlingAngle, float attackDelay, CoherenceSync parentBoss) {} // 0x00000001871F0D50-0x00000001871F0DF0
		public void Init(int groupIndex, int groupSize, float circlingAngle, float attackDelay, EnemyBeelzebub parentBoss) {} // 0x00000001871F0DF0-0x00000001871F1270
		private void Attack() {} // 0x00000001871F1270-0x00000001871F1430
		protected override void OnUpdate() {} // 0x00000001871F1430-0x00000001871F1790
		protected override void Die() {} // 0x00000001871F1790-0x00000001871F17B0
		public override void Despawn() {} // 0x00000001871F17B0-0x00000001871F1820
		private void SetupExplosions() {} // 0x00000001871F1820-0x00000001871F2050
		private void PlayExplosions() {} // 0x00000001871F2050-0x00000001871F25D0
	}
}
