/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
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
	public class SwordWeapon : Weapon // TypeDefIndex: 16185
	{
		// Fields
		private int _firingCounter; // 0x158
		private int _lastFiringCounter; // 0x15C
		private int _maxFiringCounter; // 0x160
		private BulletPool _finisherPool; // 0x168
		private BulletPool _retaliationPool; // 0x170
		private bool _canRetaliate; // 0x178
		private VampireSurvivors.Framework.TimerSystem.Timer _retaliationTimer; // 0x180
		private VampireSurvivors.Framework.TimerSystem.Timer _meleeAnimEvent; // 0x188
		protected bool _canDoFinisher; // 0x190
	
		// Constructors
		public SwordWeapon() {} // 0x0000000186F4B2D0-0x0000000186F4B330
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F496A0-0x0000000186F497D0
		public override void Cleanup() {} // 0x0000000186F497D0-0x0000000186F49930
		public override void CheckArcanas() {} // 0x0000000186F49930-0x0000000186F499F0
		public override void ParadoxFire() {} // 0x0000000186F499F0-0x0000000186F49A10
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BB1 */) {} // 0x0000000186F49A10-0x0000000186F49A30
		public void ScreenShake() {} // 0x0000000186F49A30-0x0000000186F49F50
		protected override void OnStart() {} // 0x0000000186F49F50-0x0000000186F4A4D0
		private void OnPlayerHitDamage(GameplaySignals.CharacterReceivedDamageSignal signal) {} // 0x0000000186F4A4D0-0x0000000186F4A600
		private void OnPlayerHitShield(GameplaySignals.CharacterLostShieldSignal signal) {} // 0x0000000186F4A600-0x0000000186F4A730
		private void OnPlayerHit() {} // 0x0000000186F4A730-0x0000000186F4A870
		protected virtual void FireInternal(bool isRetaliatory = false /* Metadata: 0x01977BB2 */, bool skipTriggers = false /* Metadata: 0x01977BB3 */) {} // 0x0000000186F4A870-0x0000000186F4AEB0
		public Projectile FireOneProjectile(Vector2 pos, int index, float volume) => default; // 0x0000000186F4AEB0-0x0000000186F4B030
		private Projectile FireOneRetaliatoryProjectile(Vector2 pos, int index, float volume) => default; // 0x0000000186F4B030-0x0000000186F4B200
		private Projectile FireOneFinisherProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) => default; // 0x0000000186F4B200-0x0000000186F4B2D0
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F33A30-0x0000000186F33A80
	}
}
