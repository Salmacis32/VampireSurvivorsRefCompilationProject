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
using VampireSurvivors.Objects.Projectiles;
using VampireSurvivors.Signals;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class EX_Gaea2_Weapon : EX_Gaea1_Weapon // TypeDefIndex: 16660
	{
		// Fields
		private BulletPool _retaliationPool; // 0x158
		private bool _canRetaliate; // 0x160
		private VampireSurvivors.Framework.TimerSystem.Timer _retaliationTimer; // 0x168
	
		// Constructors
		public EX_Gaea2_Weapon() {} // 0x0000000187037B10-0x0000000187037B60
	
		// Methods
		public override float PPower() => default; // 0x0000000186F9EE60-0x0000000186F9EF20
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000187037B60-0x0000000187037C90
		public override void Cleanup() {} // 0x0000000187037C90-0x0000000187037DD0
		protected override void OnStart() {} // 0x0000000187037DD0-0x00000001870380D0
		private void OnPlayerHitDamage(GameplaySignals.CharacterReceivedDamageSignal signal) {} // 0x00000001870380D0-0x0000000187038200
		private void OnPlayerHitShield(GameplaySignals.CharacterLostShieldSignal signal) {} // 0x0000000187038200-0x0000000187038330
		private void OnPlayerHit() {} // 0x0000000187038330-0x00000001870384B0
		private Projectile FireOneRetaliatoryProjectile(Vector2 pos, int index) => default; // 0x00000001870384B0-0x0000000187038500
	}
}
