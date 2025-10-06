/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class Tongue2Projectile : TongueProjectile // TypeDefIndex: 15995
	{
		// Properties
		public bool AssassinationTongue { get; set; } // 0x00000001865DBE60-0x00000001865DBE70 0x00000001867531A0-0x00000001867531B0
	
		// Constructors
		public Tongue2Projectile() {} // 0x0000000186EA0270-0x0000000186EA0280
	
		// Methods
		protected override void InitTrailSprite() {} // 0x0000000186E9FE60-0x0000000186E9FF40
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E9FF40-0x0000000186E9FF70
		protected override Vector3[] GetCurve(float2 startPoint, float2 currentPoint) => default; // 0x0000000186E9FF70-0x0000000186EA0150
		protected override void OnHasHitAnotherPlayerObject(IDamageable other) {} // 0x0000000186EA0150-0x0000000186EA0270
	}
}
