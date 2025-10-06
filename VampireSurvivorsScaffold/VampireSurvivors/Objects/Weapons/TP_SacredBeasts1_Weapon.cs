/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Signals;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_SacredBeasts1_Weapon : Weapon // TypeDefIndex: 16460
	{
		// Fields
		private BulletPool _standardPool; // 0x158
		private BulletPool _retaliationPool; // 0x160
		private bool _canRetaliate; // 0x168
		private bool _canOverheal; // 0x169
		private VampireSurvivors.Framework.TimerSystem.Timer _retaliationTimer; // 0x170
		private VampireSurvivors.Framework.TimerSystem.Timer _overHealTimer; // 0x178
		private float OverhealTriggerValue; // 0x180
		private float OverhealDelay; // 0x184
		private float RetaliationDelay; // 0x188
		private VampireSurvivors.Framework.TimerSystem.Timer _invulTimer; // 0x190
		private bool _canInvul; // 0x198
		private float invulDelay; // 0x19C
		private PhaserSprite _guardianSprite1; // 0x1A0
		private PhaserSprite _guardianSprite2; // 0x1A8
		private PhaserSprite _guardianSprite3; // 0x1B0
		private PhaserSprite _guardianSprite4; // 0x1B8
		private MultiTargetTween _guardianTween1; // 0x1C0
		private MultiTargetTween _guardianTween2; // 0x1C8
		private MultiTargetTween _guardianTween3; // 0x1D0
		private MultiTargetTween _guardianTween4; // 0x1D8
		private MultiTargetTween _guardianTween5; // 0x1E0
		public int SlotNumber; // 0x1E8
	
		// Properties
		protected virtual bool hasInvulnerabilityBonus { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
	
		// Constructors
		public TP_SacredBeasts1_Weapon() {} // 0x0000000186FE67D0-0x0000000186FE6850
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FE3B60-0x0000000186FE43B0
		private void OnHpRecoveryCallback(float value, float rawValue) {} // 0x0000000186FE43B0-0x0000000186FE4680
		private void PlayInvulAnimation(float duration) {} // 0x0000000186FE4680-0x0000000186FE5690
		private void OnPlayerHit() {} // 0x0000000186FE5690-0x0000000186FE5840
		public override void Cleanup() {} // 0x0000000186FE5840-0x0000000186FE59E0
		protected override void OnStart() {} // 0x0000000186FE59E0-0x0000000186FE5F60
		private void OnPlayerHitDamage(GameplaySignals.CharacterReceivedDamageSignal signal) {} // 0x0000000186FE5F60-0x0000000186FE6090
		private void OnPlayerHitShield(GameplaySignals.CharacterLostShieldSignal signal) {} // 0x0000000186FE6090-0x0000000186FE61C0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977CCA */) {} // 0x0000000186FE61C0-0x0000000186FE6300
		public void FireStandardProjectiles() {} // 0x0000000186FE6300-0x0000000186FE6310
		public void FireProjectiles(BulletPool pool) {} // 0x0000000186FE6310-0x0000000186FE6750
		public override void SetVisible(bool visible) {} // 0x0000000186FE6750-0x0000000186FE67D0
	}
}
