/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Signals;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class BattiliaWeapon : Weapon // TypeDefIndex: 16136
	{
		// Fields
		private bool canRetaliate; // 0x158
		private VampireSurvivors.Framework.TimerSystem.Timer _retaliationTimer; // 0x160
		private float _retaliationDelay; // 0x168
		private bool soundToPlay; // 0x16C
		protected Circle _damageZone; // 0x170
		protected List<float> firingAngles; // 0x178
		public float batAlpha; // 0x180
		public float shadowAlpha; // 0x184
		public float physScale; // 0x188
		public float maxPhysScale; // 0x18C
		private BulletPool _retaliationPool; // 0x190
	
		// Constructors
		public BattiliaWeapon() {} // 0x0000000186F1CF40-0x0000000186F1CFC0
	
		// Methods
		protected virtual BulletPool GetBulletPool() => default; // 0x0000000186F1CFC0-0x0000000186F1D050
		public override void CheckArcanas() {} // 0x0000000186F1D050-0x0000000186F1D110
		protected override void OnStart() {} // 0x0000000186F1D110-0x0000000186F1D3D0
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F1D3D0-0x0000000186F1D760
		private bool OnBulletOverlapsBullet(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F1D760-0x0000000186F1D9E0
		private void OnPlayerHit(GameplaySignals.CharacterReceivedDamageSignal signal) {} // 0x0000000186F1D9E0-0x0000000186F1DB10
		private void OnPlayerShieldHit(GameplaySignals.CharacterLostShieldSignal signal) {} // 0x0000000186F1DB10-0x0000000186F1DC40
		public void FireRetaliation() {} // 0x0000000186F1DC40-0x0000000186F1DE70
		public void TriggerOnlineRetaliation() {} // 0x0000000186F1DE70-0x0000000186F1DE80
		public override void Cleanup() {} // 0x0000000186F1DE80-0x0000000186F1DF90
		public float2 PickPosition() => default; // 0x0000000186F1DF90-0x0000000186F1E1B0
		private void CheckMaxScale() {} // 0x0000000186F1E1B0-0x0000000186F1E290
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977B69 */) {} // 0x0000000186F1E290-0x0000000186F1E2A0
		private void FireInternal(bool isRetaliatory = false /* Metadata: 0x01977B6A */, bool skipTriggers = false /* Metadata: 0x01977B6B */) {} // 0x0000000186F1E2A0-0x0000000186F1E930
	}
}
