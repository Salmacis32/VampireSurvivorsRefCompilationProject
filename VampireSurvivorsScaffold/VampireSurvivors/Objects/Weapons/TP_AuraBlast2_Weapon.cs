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
	public class TP_AuraBlast2_Weapon : Weapon // TypeDefIndex: 16277
	{
		// Fields
		[SerializeField]
		private Projectile _HellfireProjectilePrefab; // 0x158
		private const float HellfireDamageMultiplier = 3f; // Metadata: 0x01977BF8
		private BulletPool _hellfireProjectilePool; // 0x160
	
		// Properties
		public BulletPool HellfireProjectilePool { get => default; } // 0x00000001827668E0-0x00000001827668F0 
	
		// Constructors
		public TP_AuraBlast2_Weapon() {} // 0x0000000186F88AF0-0x0000000186F88B40
	
		// Methods
		protected override void OnStart() {} // 0x0000000186F88190-0x0000000186F88480
		protected override void MakeLevelOne() {} // 0x0000000186F88480-0x0000000186F88530
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BF7 */) {} // 0x0000000186F88530-0x0000000186F88670
		public override void CheckArcanas() {} // 0x0000000186F88670-0x0000000186F888C0
		private bool OnBulletOverlapsEnemy_Hellfire(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F888C0-0x0000000186F88A30
		public override void SetVisible(bool visible) {} // 0x0000000186F88A30-0x0000000186F88AF0
	}
}
