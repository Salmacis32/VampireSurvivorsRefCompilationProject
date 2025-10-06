/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Signals;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class CarnageWeapon : Weapon // TypeDefIndex: 16149
	{
		// Fields
		private int _exploIndex; // 0x158
		private bool _canExplode; // 0x15C
		private Tween _explodeTimer; // 0x160
		private bool _generatedPools; // 0x168
		private BulletPool _onGetHitExplosionPool; // 0x170
		private BulletPool _tvExplosionPool; // 0x178
	
		// Properties
		public BulletPool TVExplosionPool { get => default; } // 0x0000000182917A20-0x0000000182917A30 
	
		// Constructors
		public CarnageWeapon() {} // 0x0000000186F2B810-0x0000000186F2B870
	
		// Methods
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F2A4C0-0x0000000186F2A5F0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977B88 */) {} // 0x0000000186F2A5F0-0x0000000186F2A920
		public override void CheckArcanas() {} // 0x0000000186F2A920-0x0000000186F2AA90
		public override int ActiveProjectileCount() => default; // 0x0000000186F2AA90-0x0000000186F2AB10
		public override void Cleanup() {} // 0x0000000186F2AB10-0x0000000186F2AC50
		protected override void OnStart() {} // 0x0000000186F2AC50-0x0000000186F2B1D0
		private void ExplodeOnPlayerDamage(GameplaySignals.CharacterReceivedDamageSignal signal) {} // 0x0000000186F2B1D0-0x0000000186F2B300
		private void ExplodeOnPlayerShield(GameplaySignals.CharacterLostShieldSignal signal) {} // 0x0000000186F2B300-0x0000000186F2B430
		private void ExplodeOnPlayer() {} // 0x0000000186F2B430-0x0000000186F2B810
	}
}
