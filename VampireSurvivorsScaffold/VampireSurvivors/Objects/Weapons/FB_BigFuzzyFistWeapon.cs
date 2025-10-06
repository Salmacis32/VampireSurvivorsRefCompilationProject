/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Signals;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class FB_BigFuzzyFistWeapon : Weapon // TypeDefIndex: 16224
	{
		// Fields
		private PhaserSprite _leftFist; // 0x158
		private PhaserSprite _rightFist; // 0x160
		private FistState[] _fistStates; // 0x168
		private int _nextFist; // 0x170
		private float _rage; // 0x174
		private float maxCooldownOffset; // 0x178
		private float cooldownOffset; // 0x17C
	
		// Nested types
		private class FistState // TypeDefIndex: 16223
		{
			// Fields
			public PhaserSprite _fist; // 0x10
			public float _alpha; // 0x18
			public float _punchProgress; // 0x1C
			public EnemyController _punchTarget; // 0x20
			public Phase _phase; // 0x28
			public int _punchesLeft; // 0x2C
			public float2 _fistOffset; // 0x30
			public float2 _punchTargetPos; // 0x38
			public Vector2 _fistVelocity; // 0x40
	
			// Nested types
			public enum Phase // TypeDefIndex: 16222
			{
				Waiting = 0,
				FadingIn = 1,
				PunchingDown = 2,
				Retracting = 3,
				FadingOut = 4
			}
	
			// Constructors
			public FistState() {} // 0x0000000186F6E0A0-0x0000000186F6E0B0
		}
	
		// Constructors
		public FB_BigFuzzyFistWeapon() {} // 0x0000000186F6DF40-0x0000000186F6DFA0
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F6B790-0x0000000186F6C4F0
		public override void Cleanup() {} // 0x0000000186F6C4F0-0x0000000186F6C6F0
		private void RetaliateOnPlayerDamage(GameplaySignals.CharacterReceivedDamageSignal signal) {} // 0x0000000186F6C6F0-0x0000000186F6C830
		private void RetaliateOnPlayerShield(GameplaySignals.CharacterLostShieldSignal signal) {} // 0x0000000186F6C830-0x0000000186F6C970
		private void Retaliate() {} // 0x0000000186F6C970-0x0000000186F6C990
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BD0 */) {} // 0x0000000186F6C990-0x0000000186F6CC90
		public override void InternalUpdate() {} // 0x0000000186F6CC90-0x0000000186F6CD30
		private void UpdateFist(FistState fist) {} // 0x0000000186F6CD30-0x0000000186F6D2E0
		private bool SwitchToNewFistTarget(FistState fist) => default; // 0x0000000186F6D2E0-0x0000000186F6D460
		private void DoNextPunch(float speedMultiplier = 1f /* Metadata: 0x01977BD1 */) {} // 0x0000000186F6D460-0x0000000186F6D4B0
		private EnemyController GetNextTarget(FistState fist) => default; // 0x0000000186F6D4B0-0x0000000186F6D750
		private float2 GetTargetSearchCenter(FistState fist) => default; // 0x0000000186F6D750-0x0000000186F6D900
		private EnemyController ClosestEnemyInSet(List<EnemyController> set, float2 queryPos) => default; // 0x0000000186F6D900-0x0000000186F6DB90
		protected override void OnUpdate() {} // 0x0000000186F6DB90-0x0000000186F6DC00
		public override float PInterval() => default; // 0x0000000186F6DC00-0x0000000186F6DE00
		public override void SetVisible(bool visible) {} // 0x0000000186F6DE00-0x0000000186F6DF40
	}
}
