/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pickups;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_SpiritTornado_Weapon : Weapon // TypeDefIndex: 16490
	{
		// Fields
		private BulletPool _invisibleProjectilePool; // 0x158
		[SerializeField]
		private Projectile _invisibleProjectilePrefab; // 0x160
		private BulletPool _spiritGemProjectilePool; // 0x168
		[SerializeField]
		private Projectile _spiritGemProjectilePrefab; // 0x170
		private BulletPool _gemExplosionProjectilePool; // 0x178
		[SerializeField]
		private Projectile _gemExplosionProjectilePrefab; // 0x180
		private bool canPickupItems; // 0x188
		private VampireSurvivors.Framework.TimerSystem.Timer pickupsResetTimer; // 0x190
		private List<Pickup> itemsPickedUp; // 0x198
		private bool _isManualFire; // 0x1A0
	
		// Constructors
		public TP_SpiritTornado_Weapon() {} // 0x0000000186FF3310-0x0000000186FF3400
	
		// Methods
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000181BA4B30-0x0000000181BA4B40
		public void SetManualFire() {} // 0x0000000186FF1F80-0x0000000186FF1FA0
		protected override void OnStart() {} // 0x0000000186FF1FA0-0x0000000186FF2940
		public override void InternalUpdate() {} // 0x0000000186FF2940-0x0000000186FF29D0
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977CE1 */) {} // 0x0000000186FF29D0-0x0000000186FF2A50
		private bool OnBulletOverlapsPickup(CallbackContext context, ArcadeColliderType left, ArcadeColliderType right) => default; // 0x0000000186FF2A50-0x0000000186FF2ED0
		public void SpawnGemExplosion() {} // 0x0000000186FF2ED0-0x0000000186FF2F50
		protected bool OnGemOverlapsPlayer(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186FF2F50-0x0000000186FF32A0
		public override void Cleanup() {} // 0x0000000186FF32A0-0x0000000186FF3310
	}
}
