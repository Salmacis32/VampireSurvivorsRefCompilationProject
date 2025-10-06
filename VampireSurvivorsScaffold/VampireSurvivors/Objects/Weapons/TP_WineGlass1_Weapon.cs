/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_WineGlass1_Weapon : Weapon // TypeDefIndex: 16528
	{
		// Fields
		private BulletPool _invisibleProjectilePool; // 0x158
		private BulletPool _explosionProjectilePool; // 0x160
		[SerializeField]
		private Projectile _invisibleProjectilePrefab; // 0x168
		[SerializeField]
		private Projectile _explosionProjectilePrefab; // 0x170
	
		// Constructors
		public TP_WineGlass1_Weapon() {} // 0x00000001870016D0-0x0000000187001720
	
		// Methods
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B21570-0x0000000180B21580
		protected override void OnStart() {} // 0x0000000187001060-0x0000000187001590
		public void FireProjectiles(Vector2 position) {} // 0x0000000187001590-0x0000000187001640
		public void FireExplosion(Vector2 position) {} // 0x0000000187001640-0x0000000187001680
		public override void Cleanup() {} // 0x0000000187001680-0x00000001870016D0
	}
}
