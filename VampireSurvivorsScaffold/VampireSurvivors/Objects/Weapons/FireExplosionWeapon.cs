/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Signals;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class FireExplosionWeapon : Weapon // TypeDefIndex: 16679
	{
		// Fields
		private bool _canExplode; // 0x158
		private Tween _explodeTimer; // 0x160
	
		// Constructors
		public FireExplosionWeapon() {} // 0x0000000187070250-0x00000001870702A0
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x000000018706F8B0-0x000000018706F9E0
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x000000018706F9E0-0x000000018706FB00
		public override void Cleanup() {} // 0x000000018706FB00-0x000000018706FC10
		public void TriggerExplosion(Vector2 pos, int index) {} // 0x000000018706FC10-0x000000018706FC40
		public override void ResetFiringTimer() {} // 0x0000000186F292B0-0x0000000186F292D0
		private void ExplodeOnPlayerDamage(GameplaySignals.CharacterReceivedDamageSignal signal) {} // 0x000000018706FC40-0x000000018706FD70
		private void ExplodeOnPlayerShield(GameplaySignals.CharacterLostShieldSignal signal) {} // 0x000000018706FD70-0x000000018706FEA0
		private void ExplodeOnPlayer() {} // 0x000000018706FEA0-0x000000018706FF90
		private void ExplodeAt(Vector2 position, bool ignoreCooldown = false /* Metadata: 0x01977DCA */) {} // 0x000000018706FF90-0x0000000187070250
	}
}
