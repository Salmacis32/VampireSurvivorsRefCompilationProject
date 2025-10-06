/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class BubbleWeapon : Weapon // TypeDefIndex: 16146
	{
		// Constructors
		public BubbleWeapon() {} // 0x0000000186F2A3D0-0x0000000186F2A420
	
		// Methods
		protected override void OnStart() {} // 0x0000000186F29A60-0x0000000186F29B30
		public override Projectile FireOneProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) => default; // 0x0000000186F29B30-0x0000000186F29DE0
		protected override void OnUpdate() {} // 0x0000000186F29DE0-0x0000000186F29F20
		private void OverlapCirc(float x, float y, float radius) {} // 0x0000000186F29F20-0x0000000186F2A1E0
		private bool CircleToCircle(Circle circleA, BaseBody circleB) => default; // 0x0000000186F2A1E0-0x0000000186F2A260
		private float DistanceBetween(float x1, float y1, float x2, float y2) => default; // 0x0000000186F2A260-0x0000000186F2A290
		public override void ParadoxFire() {} // 0x0000000186F2A290-0x0000000186F2A3D0
	}
}
