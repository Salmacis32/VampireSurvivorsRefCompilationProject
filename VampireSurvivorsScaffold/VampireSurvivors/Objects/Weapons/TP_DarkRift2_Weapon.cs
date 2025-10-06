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
	public class TP_DarkRift2_Weapon : Weapon // TypeDefIndex: 16307
	{
		// Fields
		[SerializeField]
		private Projectile _SkullProjectilePrefab; // 0x158
		private BulletPool _skullProjectilePool; // 0x160
		private const float SkullDamageMultiplier = 0.4f; // Metadata: 0x01977C3F
	
		// Properties
		public int NumSkulls { get => default; } // 0x0000000181BA4B30-0x0000000181BA4B40 
	
		// Constructors
		public TP_DarkRift2_Weapon() {} // 0x0000000186F9D600-0x0000000186F9D650
	
		// Methods
		protected override void OnStart() {} // 0x0000000186F9CC70-0x0000000186F9CF60
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977C3E */) {} // 0x0000000186F9CF60-0x0000000186F9D020
		private void SpawnSkulls() {} // 0x0000000186F9D020-0x0000000186F9D260
		public override void CheckArcanas() {} // 0x0000000186F9D260-0x0000000186F9D490
		private bool OnBulletOverlapsEnemy_Skull(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F9D490-0x0000000186F9D600
	}
}
