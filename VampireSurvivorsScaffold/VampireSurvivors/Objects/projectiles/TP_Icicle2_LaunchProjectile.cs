/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Icicle2_LaunchProjectile : Projectile // TypeDefIndex: 15594
	{
		// Fields
		private const float Radius = 16f; // Metadata: 0x01977732
		private PhaserSprite _icicleSprite; // 0xD0
	
		// Constructors
		public TP_Icicle2_LaunchProjectile() {} // 0x0000000186CCD5E0-0x0000000186CCD630
	
		// Methods
		protected override void Awake() {} // 0x0000000186CCCDD0-0x0000000186CCD250
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CCD250-0x0000000186CCD480
		public void SetSprite(Sprite sprite) {} // 0x0000000186CCD480-0x0000000186CCD4D0
		private void PlaySfx() {} // 0x0000000186CCD4D0-0x0000000186CCD5E0
	}
}
