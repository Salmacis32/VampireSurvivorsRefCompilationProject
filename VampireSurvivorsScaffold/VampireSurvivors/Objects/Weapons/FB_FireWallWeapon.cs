/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class FB_FireWallWeapon : Weapon // TypeDefIndex: 16234
	{
		// Fields
		private List<FlameData> flameData; // 0x158
	
		// Constructors
		public FB_FireWallWeapon() {} // 0x0000000186F72970-0x0000000186F72A60
	
		// Methods
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BE3 */) {} // 0x0000000186F711D0-0x0000000186F71380
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F70BB0-0x0000000186F70BE0
		public override void CheckArcanas() {} // 0x0000000186F71380-0x0000000186F71480
		private FlameData nextFlameData() => default; // 0x0000000186F71480-0x0000000186F718D0
		public void addFlameSprite(float2 pos) {} // 0x0000000186F718D0-0x0000000186F71EE0
		protected override bool OnBulletOverlapsDestructible(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F71EE0-0x0000000186F727E0
		public override void Cleanup() {} // 0x0000000186F727E0-0x0000000186F72970
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B21570-0x0000000180B21580
	}
}
