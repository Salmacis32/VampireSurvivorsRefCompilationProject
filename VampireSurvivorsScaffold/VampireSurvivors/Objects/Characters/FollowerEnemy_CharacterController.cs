/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data.Enemies;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class FollowerEnemy_CharacterController : CharacterController // TypeDefIndex: 17173
	{
		// Fields
		private EnemyData _enemyData; // 0x3F0
		private Vector3 _OriginalScale; // 0x3F8
		public bool HasSetName; // 0x404
		private bool _needsCart; // 0x405
		[SerializeField]
		private float _PowerMultiplier; // 0x408
		[SerializeField]
		private float _HpMultiplier; // 0x40C
	
		// Properties
		public override bool NeedsCart { get => default; } // 0x000000018719DB60-0x000000018719DB70 
	
		// Constructors
		public FollowerEnemy_CharacterController() {} // 0x000000018719FAA0-0x000000018719FAC0
	
		// Methods
		protected override void MakeLevelOne(bool dontGetCharacterDataForCurrentLevel = false /* Metadata: 0x0197816D */) {} // 0x000000018719DB70-0x000000018719E1E0
		[IteratorStateMachine(typeof(_WaitForEnemyDataForMakeLevelOne_d__9))]
		private IEnumerator WaitForEnemyDataForMakeLevelOne(bool dontGetCharacterDataForCurrentLevel) => default; // 0x000000018719E1E0-0x000000018719E290
		protected override void SetCharacterSprite() {} // 0x000000018719E290-0x000000018719E9D0
		[IteratorStateMachine(typeof(_WaitForEnemyDataForSetCharacterSprite_d__11))]
		private IEnumerator WaitForEnemyDataForSetCharacterSprite() => default; // 0x000000018719E9D0-0x000000018719EA70
		protected override void SetupAnimation() {} // 0x000000018719EA70-0x000000018719EDB0
		[IteratorStateMachine(typeof(_WaitForEnemyDataForSetupAnimation_d__13))]
		private IEnumerator WaitForEnemyDataForSetupAnimation() => default; // 0x000000018719EDB0-0x000000018719EE50
		protected override void AddAttackAnimations() {} // 0x000000018719EE50-0x000000018719F460
		[IteratorStateMachine(typeof(_WaitForEnemyDataForAddAttackAnimations_d__15))]
		private IEnumerator WaitForEnemyDataForAddAttackAnimations() => default; // 0x000000018719F460-0x000000018719F500
		protected override void InternalUpdate() {} // 0x000000018719F500-0x000000018719F580
		protected override void ScheduleDeathConsequences() {} // 0x000000018719F580-0x000000018719F6C0
		private void Deactivate() {} // 0x000000018719F580-0x000000018719F6C0
		public void Activate() {} // 0x000000018719F6C0-0x000000018719FAA0
	}
}
