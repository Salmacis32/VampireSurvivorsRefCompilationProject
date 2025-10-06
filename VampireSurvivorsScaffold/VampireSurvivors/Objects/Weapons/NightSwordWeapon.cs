/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Projectiles;
using VampireSurvivors.Signals;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class NightSwordWeapon : Weapon // TypeDefIndex: 16743
	{
		// Fields
		public int _FireCounter; // 0x158
		public int[] _FireAngles; // 0x160
		public int[] _FireX; // 0x168
		private bool _canExplode; // 0x170
		public bool _CanFinish; // 0x171
		private VampireSurvivors.Framework.TimerSystem.Timer _expodeTimer; // 0x178
		private float _retaliationDelay; // 0x180
		private bool _removedFiringTimer; // 0x184
		public float _Volume; // 0x188
	
		// Constructors
		public NightSwordWeapon() {} // 0x00000001870A14C0-0x00000001870A1670
	
		// Methods
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x00000001870A1670-0x00000001870A17B0
		public void SetAsRetaliatoryOnly() {} // 0x00000001870A17B0-0x00000001870A17F0
		public override void ResetFiringTimer() {} // 0x00000001870A17F0-0x00000001870A1820
		public override float PPower() => default; // 0x00000001870A1820-0x00000001870A1870
		public override bool LevelUp() => default; // 0x0000000184C0C910-0x0000000184C0C930
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977E0C */) {} // 0x00000001870A1870-0x00000001870A1E70
		public List<EnemyController> Closest(CharacterController source, PhysicsGroup targets) => default; // 0x00000001870A1E70-0x00000001870A21B0
		public override void Cleanup() {} // 0x00000001870A21B0-0x00000001870A22D0
		private void ExplodeOnPlayerDamage(GameplaySignals.CharacterReceivedDamageSignal signal) {} // 0x00000001870A22D0-0x00000001870A2400
		private void ExplodeOnPlayerShield(GameplaySignals.CharacterLostShieldSignal signal) {} // 0x00000001870A2400-0x00000001870A2530
		private void ExplodeOnPlayer() {} // 0x00000001870A2530-0x00000001870A2A10
		public override Projectile SpawnExplosionAt(float2 pos, int enemiesHit = 0 /* Metadata: 0x01977E0D */, int damage = 1 /* Metadata: 0x01977E0E */, float area = 1f /* Metadata: 0x01977E0F */) => default; // 0x00000001870A2A10-0x00000001870A2E20
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x00000001870A2E20-0x00000001870A31D0
		protected override bool OnBulletOverlapsEnemyRetaliation(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x00000001870A31D0-0x00000001870A36A0
		public override void CheckArcanas() {} // 0x00000001870A36A0-0x00000001870A3760
	}
}
