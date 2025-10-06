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
	public class TP_Shield1_Weapon : Weapon // TypeDefIndex: 16470
	{
		// Fields
		private BulletPool _standardPool; // 0x158
		private BulletPool _retaliationPool; // 0x160
		private bool _canRetaliate; // 0x168
		private VampireSurvivors.Framework.TimerSystem.Timer _retaliationTimer; // 0x170
		private float RetaliationDelay; // 0x178
		public int SlotNumber; // 0x17C
	
		// Constructors
		public TP_Shield1_Weapon() {} // 0x0000000186FECDE0-0x0000000186FECE50
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FEBA40-0x0000000186FEBBD0
		private void OnPlayerHit() {} // 0x0000000186FEBBD0-0x0000000186FEBDC0
		public override void Cleanup() {} // 0x0000000186FEBDC0-0x0000000186FEBF60
		protected override void OnStart() {} // 0x0000000186FEBF60-0x0000000186FEC4E0
		private void OnPlayerHitDamage(GameplaySignals.CharacterReceivedDamageSignal signal) {} // 0x0000000186FEC4E0-0x0000000186FEC610
		private void OnPlayerHitShield(GameplaySignals.CharacterLostShieldSignal signal) {} // 0x0000000186FEC610-0x0000000186FEC740
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977CD4 */) {} // 0x0000000186FEC740-0x0000000186FEC880
		public void FireStandardProjectiles(Vector2 position) {} // 0x0000000186FEC880-0x0000000186FEC8B0
		public void FireProjectiles(BulletPool pool, Vector2 position, bool allDirections = false /* Metadata: 0x01977CD5 */) {} // 0x0000000186FEC8B0-0x0000000186FECDE0
	}
}
