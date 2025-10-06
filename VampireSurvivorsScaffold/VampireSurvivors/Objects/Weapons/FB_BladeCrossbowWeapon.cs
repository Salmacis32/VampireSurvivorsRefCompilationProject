/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class FB_BladeCrossbowWeapon : FB_QuantisedAngleWeapon // TypeDefIndex: 16225
	{
		// Properties
		public override float SecondsToRotateAim360 { get => default; } // 0x00000001826256C0-0x00000001826256D0 
	
		// Constructors
		public FB_BladeCrossbowWeapon() {} // 0x0000000186F6E850-0x0000000186F6E8A0
	
		// Methods
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B21570-0x0000000180B21580
		public override Projectile FireOneProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) => default; // 0x0000000186F6E0B0-0x0000000186F6E530
		public EnemyController findEnemyInPlayerDirection(Vector2 pos, float angle, float acceptableAngle = 3.4028235E+38f /* Metadata: 0x01977BDA */) => default; // 0x0000000186F6E530-0x0000000186F6E790
		public override void SetVisible(bool visible) {} // 0x0000000186F6E790-0x0000000186F6E850
	}
}
