/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pickups;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class GattiWeapon : Weapon // TypeDefIndex: 16692
	{
		// Fields
		[FormerlySerializedAs("_explosionPrefab")]
		[SerializeField]
		private Projectile _ExplosionPrefab; // 0x158
		[FormerlySerializedAs("_gattiScratchPrefab")]
		[SerializeField]
		private Projectile _GattiScratchPrefab; // 0x160
		[FormerlySerializedAs("_gattiScufflePrefab")]
		[SerializeField]
		private Projectile _GattiScufflePrefab; // 0x168
		public List<string> _CatBaseFrames; // 0x170
		private List<float> _randoms; // 0x178
		private int _randomIndex; // 0x180
		private BulletPool _explosionPool; // 0x188
		public BulletPool _scratchPool; // 0x190
		private BulletPool _scufflePool; // 0x198
		private int _plusMinusIndex; // 0x1A0
		protected List<float> _plusMinus; // 0x1A8
		private SfxType[] _sfxArray; // 0x1B0
		private int _sfxIndex; // 0x1B8
		private float _full; // 0x1BC
		private int _chickens; // 0x1C0
		private WeaponType _counterWeaponType; // 0x1C4
		private Weapon _counterWeapon; // 0x1C8
	
		// Constructors
		public GattiWeapon() {} // 0x000000018707FB10-0x000000018707FD70
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x000000018707BD50-0x000000018707C2A0
		public float GetRandom() => default; // 0x000000018707C2A0-0x000000018707C340
		public float GetPlusMinus() => default; // 0x000000018707C340-0x000000018707C3E0
		public SfxType GetSfx() => default; // 0x000000018707C3E0-0x000000018707C430
		protected override void OnStart() {} // 0x000000018707C430-0x000000018707D270
		private void ChickenUpgradesOnLevelUp() {} // 0x000000018707D270-0x000000018707D330
		private void ApplyChickenUpgrade(int chickens) {} // 0x000000018707D330-0x000000018707D3C0
		public override bool LevelUp() => default; // 0x000000018707D3C0-0x000000018707D5B0
		public override void CheckArcanas() {} // 0x000000018707D5B0-0x000000018707D910
		public override bool ApplyLimitBreak(WeightedLimitBreak weightedLimitBreak) => default; // 0x000000018707D910-0x000000018707DA30
		protected override void MakeLevelOne() {} // 0x000000018707DA30-0x000000018707DA60
		public override void Cleanup() {} // 0x000000018707DA60-0x000000018707DAC0
		public virtual void ChangeBmRate(int value) {} // 0x000000018707DAC0-0x000000018707DC30
		private bool OnCatOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x000000018707DC30-0x000000018707E0C0
		private bool OnCatOverlapsPlayer(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x000000018707E0C0-0x000000018707E510
		private bool OnBulletOverlapsBullet(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x000000018707E510-0x000000018707EA40
		private bool OnBulletOverlapsPickup(CallbackContext context, ArcadeColliderType left, ArcadeColliderType right) => default; // 0x000000018707EA40-0x000000018707F3E0
		private void DespawnPickup(Pickup pickup) {} // 0x000000018707F3E0-0x000000018707F510
		private void OnNftPicked(Vector2 position) {} // 0x000000018707F510-0x000000018707F670
		private void OnRoastPicked() {} // 0x000000018707F670-0x000000018707F810
		private bool OnBulletOverlapsEnemyNoKB(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x000000018707F810-0x000000018707FB10
	}
}
