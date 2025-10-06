/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using QFSW.MOP2;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class SireWeapon : Weapon // TypeDefIndex: 16776
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _WhiteDot; // 0x158
		[SerializeField]
		private SpriteRenderer _GroundSeal; // 0x160
		[SerializeField]
		private GameObject _ExplosionVFXPrefab; // 0x168
		public float _R; // 0x170
		public float _G; // 0x174
		public float _B; // 0x178
		public float _A; // 0x17C
		private ObjectPool _explosionPool; // 0x180
		private MultiTargetTween _rgbTween; // 0x188
		private MultiTargetTween _alphaTween; // 0x190
		private bool _canFlash; // 0x198
		private Projectile _activeProjectile; // 0x1A0
	
		// Properties
		public ObjectPool ExplosionPool { get => default; } // 0x00000001826DB9D0-0x00000001826DB9E0 
		public SpriteRenderer WhiteDot { get => default; } // 0x0000000184755AB0-0x0000000184755AC0 
		protected override bool UseOnlineTimer { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
	
		// Constructors
		public SireWeapon() {} // 0x00000001870BB2E0-0x00000001870BB350
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x00000001870B8DA0-0x00000001870B90A0
		public override float PInterval() => default; // 0x00000001870B90A0-0x00000001870B9100
		public override void InternalUpdate() {} // 0x00000001870B9100-0x00000001870B92C0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977E3A */) {} // 0x00000001870B92C0-0x00000001870B9440
		public void FireSire(bool skipTriggers) {} // 0x00000001870B9440-0x00000001870B9750
		public void FlashScreen(Projectile projectile) {} // 0x00000001870B9750-0x00000001870BA020
		public void SpinSeal(float durationMillis, float scale, float alpha, Projectile projectile) {} // 0x00000001870BA020-0x00000001870BA4C0
		public void HideSeal(Projectile projectile) {} // 0x00000001870BA4C0-0x00000001870BA870
		protected override void MakeLevelOne() {} // 0x00000001870BA870-0x00000001870BA920
		private void InitGroundSeal() {} // 0x00000001870BA920-0x00000001870BAA50
		private void ShowSeal() {} // 0x00000001870BAA50-0x00000001870BAE20
		private void MakeWhiteDot() {} // 0x00000001870BAE20-0x00000001870BB120
		private void GeneratePool() {} // 0x00000001870BB120-0x00000001870BB2E0
	}
}
