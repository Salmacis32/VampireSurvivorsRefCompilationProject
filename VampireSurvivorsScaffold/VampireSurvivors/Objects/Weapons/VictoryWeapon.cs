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
	public class VictoryWeapon : Weapon // TypeDefIndex: 16799
	{
		// Fields
		public int _FireCounter; // 0x158
		public int[] _FireAngles; // 0x160
		public int[] _FireX; // 0x168
		private bool _canExplode; // 0x170
		public bool _CanFinish; // 0x171
		private VampireSurvivors.Framework.TimerSystem.Timer _expodeTimer; // 0x178
	
		// Constructors
		public VictoryWeapon() {} // 0x00000001870C8A60-0x00000001870C8C00
	
		// Methods
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x00000001870C7340-0x00000001870C7480
		public override float PPower() => default; // 0x00000001870A1820-0x00000001870A1870
		public override bool LevelUp() => default; // 0x00000001870C7480-0x00000001870C74C0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977E5B */) {} // 0x00000001870C74C0-0x00000001870C7AC0
		public List<EnemyController> Closest(CharacterController source, PhysicsGroup targets) => default; // 0x00000001870C7AC0-0x00000001870C7E00
		public override void Cleanup() {} // 0x00000001870C7E00-0x00000001870C7F10
		private void ExplodeOnPlayerDamage(GameplaySignals.CharacterReceivedDamageSignal signal) {} // 0x00000001870C7F10-0x00000001870C8040
		private void ExplodeOnPlayerShield(GameplaySignals.CharacterLostShieldSignal signal) {} // 0x00000001870C8040-0x00000001870C8170
		public void ExplodeOnPlayer() {} // 0x00000001870C8170-0x00000001870C8650
		public override Projectile SpawnExplosionAt(float2 pos, int enemiesHit = 0 /* Metadata: 0x01977E5C */, int damage = 1 /* Metadata: 0x01977E5D */, float area = 1f /* Metadata: 0x01977E5E */) => default; // 0x00000001870C8650-0x00000001870C8A60
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F33A30-0x0000000186F33A80
		public override void CheckArcanas() {} // 0x0000000186FDD1D0-0x0000000186FDD290
	}
}
