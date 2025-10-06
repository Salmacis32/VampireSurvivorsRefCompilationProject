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
	public class GemCannonWeapon : Weapon // TypeDefIndex: 16693
	{
		// Fields
		[SerializeField]
		private Projectile _ExplosionProjectilePrefab; // 0x158
		private BulletPool _explosionPool; // 0x170
	
		// Properties
		public float GemValue { get; set; } // 0x00000001829176A0-0x00000001829176B0 0x0000000186758AD0-0x0000000186758AE0
		public string GemFrame { get; set; } // 0x00000001829176E0-0x00000001829176F0 0x0000000185F8DFD0-0x0000000185F8E030
	
		// Constructors
		public GemCannonWeapon() {} // 0x0000000187080690-0x0000000187080750
	
		// Methods
		protected override void OnStart() {} // 0x000000018707FD70-0x0000000187080050
		public override float PAmount() => default; // 0x0000000185C0CCB0-0x0000000185C0CCC0
		public override float PPower() => default; // 0x00000001829176A0-0x00000001829176B0
		public override void ResetFiringTimer() {} // 0x0000000186F292B0-0x0000000186F292D0
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000187080050-0x00000001870802E0
		private bool OnExplosionOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x00000001870802E0-0x00000001870804A0
		private bool OnExplosionOverlapsDestructible(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x00000001870804A0-0x00000001870805F0
		private void TriggerExplosion(Vector2 pos) {} // 0x00000001870805F0-0x0000000187080640
		public override void Cleanup() {} // 0x0000000187080640-0x0000000187080690
	}
}
