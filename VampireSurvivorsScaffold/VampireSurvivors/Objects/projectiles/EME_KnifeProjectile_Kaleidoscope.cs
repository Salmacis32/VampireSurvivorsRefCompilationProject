/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_KnifeProjectile_Kaleidoscope : EME_KnifeProjectile // TypeDefIndex: 15791
	{
		// Fields
		private float _saveVelX; // 0x120
		private float _saveVelY; // 0x124
	
		// Properties
		public override bool DoExplosions { get => default; } // 0x0000000181958370-0x0000000181958380 
		public override float DurationMultiplier { get => default; } // 0x0000000186DB9C10-0x0000000186DB9C20 
	
		// Constructors
		public EME_KnifeProjectile_Kaleidoscope() {} // 0x0000000186DBA130-0x0000000186DBA140
	
		// Methods
		protected override void Awake() {} // 0x0000000186DB9C20-0x0000000186DB9D50
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DB9D50-0x0000000186DB9E50
		private void Bounce(Body b, bool up, bool down, bool left, bool right) {} // 0x0000000186DB9E50-0x0000000186DB9EC0
		public override void InternalUpdate() {} // 0x0000000186DB9EC0-0x0000000186DB9FE0
		public override void OnHasHitWallPhaser(PhaserTile tile) {} // 0x0000000186DB9FE0-0x0000000186DBA0D0
		public override Color[][] GetTints() => default; // 0x00000001819716C0-0x00000001819716D0
		public override void FireSpecialBullets() {} // 0x0000000186DBA0D0-0x0000000186DBA130
	}
}
