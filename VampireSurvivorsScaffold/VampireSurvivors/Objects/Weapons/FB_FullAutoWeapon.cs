/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class FB_FullAutoWeapon : FB_QuantisedAngleWeapon // TypeDefIndex: 16235
	{
		// Fields
		protected SpriteRenderer _muzzleFlash; // 0x160
		protected bool _muzzleFlashLastRotated; // 0x168
		protected int _frameCount; // 0x16C
		protected float _sinPhase; // 0x170
		protected bool _randomizeSpeed; // 0x174
	
		// Properties
		public override float SecondsToRotateAim360 { get => default; } // 0x0000000186F72DF0-0x0000000186F72E00 
		public override float QuantisationStep { get => default; } // 0x0000000185C0CCB0-0x0000000185C0CCC0 
	
		// Constructors
		public FB_FullAutoWeapon() {} // 0x0000000186F6E850-0x0000000186F6E8A0
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F72E00-0x0000000186F73070
		public override void CheckArcanas() {} // 0x0000000186F73070-0x0000000186F73210
		public override void InternalUpdate() {} // 0x0000000186F73210-0x0000000186F73350
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BE4 */) {} // 0x0000000186F73350-0x0000000186F737A0
		public override float PInterval() => default; // 0x0000000186F737A0-0x0000000186F73820
		public override Projectile FireOneProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) => default; // 0x0000000186F73820-0x0000000186F73AE0
		public override void Cleanup() {} // 0x0000000186F73AE0-0x0000000186F73B50
		public override void SetVisible(bool visible) {} // 0x0000000186F73B50-0x0000000186F73BD0
		public override bool LevelUp() => default; // 0x0000000186F73BD0-0x0000000186F73C10
	}
}
