/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Signals;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_Shield2_Weapon : Weapon // TypeDefIndex: 16473
	{
		// Fields
		private BulletPool _standardPool; // 0x158
		private BulletPool _retaliationPool; // 0x160
		private bool _canRetaliate; // 0x168
		private VampireSurvivors.Framework.TimerSystem.Timer _retaliationTimer; // 0x170
		private float RetaliationDelay; // 0x178
		public int SlotNumber; // 0x17C
	
		// Constructors
		public TP_Shield2_Weapon() {} // 0x0000000186FEE3C0-0x0000000186FEE430
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FED020-0x0000000186FED1B0
		private void OnPlayerHit() {} // 0x0000000186FED1B0-0x0000000186FED3A0
		public override void Cleanup() {} // 0x0000000186FED3A0-0x0000000186FED540
		protected override void OnStart() {} // 0x0000000186FED540-0x0000000186FEDAC0
		private void OnPlayerHitDamage(GameplaySignals.CharacterReceivedDamageSignal signal) {} // 0x0000000186FEDAC0-0x0000000186FEDBF0
		private void OnPlayerHitShield(GameplaySignals.CharacterLostShieldSignal signal) {} // 0x0000000186FEDBF0-0x0000000186FEDD20
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977CD6 */) {} // 0x0000000186FEDD20-0x0000000186FEDE60
		public void FireStandardProjectiles(Vector2 position) {} // 0x0000000186FEDE60-0x0000000186FEDE90
		public void FireProjectiles(BulletPool pool, Vector2 position, bool allDirections = false /* Metadata: 0x01977CD7 */) {} // 0x0000000186FEDE90-0x0000000186FEE3C0
	}
}
