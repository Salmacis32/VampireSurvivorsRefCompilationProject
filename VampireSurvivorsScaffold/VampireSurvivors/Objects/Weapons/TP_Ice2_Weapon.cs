/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_Ice2_Weapon : Weapon // TypeDefIndex: 16405
	{
		// Fields
		private BulletPool _invisibleProjectilePool; // 0x158
		[SerializeField]
		private Projectile _invisibleProjectilePrefab; // 0x160
		private bool _initialisedParticles; // 0x168
		private PhaserSprite _cursor; // 0x170
		private bool _hasGemini; // 0x178
		private VampireSurvivors.Framework.TimerSystem.Timer rainStopTimer; // 0x180
		private TP_Ice1_Weapon _ice1Weapon; // 0x188
	
		// Properties
		public virtual float PlayerFacing { get => default; } // 0x0000000185C0CCB0-0x0000000185C0CCC0 
		public virtual bool IsPrimaryWeapon { get => default; } // 0x0000000181958370-0x0000000181958380 
	
		// Constructors
		public TP_Ice2_Weapon() {} // 0x0000000186FD1080-0x0000000186FD10D0
	
		// Methods
		protected override void Awake() {} // 0x0000000186FCF730-0x0000000186FCFB90
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FCFB90-0x0000000186FD0020
		public override void InternalUpdate() {} // 0x0000000186FD0020-0x0000000186FD0480
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977C99 */) {} // 0x0000000186FD0480-0x0000000186FD05A0
		public void FireProjectiles(Vector2 pos) {} // 0x0000000186FD05A0-0x0000000186FD0B70
		public override void CheckArcanas() {} // 0x0000000186FD0B70-0x0000000186FD0CE0
		private void DisplayCursorVFX(int _times, float _duration) {} // 0x0000000186FD0CE0-0x0000000186FD0F50
		public override void SetVisible(bool visible) {} // 0x0000000186FD0F50-0x0000000186FD1080
	}
}
