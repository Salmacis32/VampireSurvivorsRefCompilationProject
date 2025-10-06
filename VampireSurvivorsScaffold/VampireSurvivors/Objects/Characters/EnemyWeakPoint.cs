/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pickups;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class EnemyWeakPoint : IDamageable // TypeDefIndex: 17195
	{
		// Fields
		private EnemyController _parentEnemy; // 0x10
		public ArcadeSprite _damageZone; // 0x18
		public bool _isApplyingDamage; // 0x20
		private Collider _damageZoneCollider; // 0x28
	
		// Constructors
		public EnemyWeakPoint() {} // Dummy constructor
		public EnemyWeakPoint(EnemyController parentEnemy) {} // 0x00000001871D9090-0x00000001871D94C0
	
		// Methods
		private bool OnBulletOverlapsDamageZone(CallbackContext context, ArcadeColliderType damageZone, ArcadeColliderType bullet) => default; // 0x00000001871D94C0-0x00000001871D9630
		public void Destroy() {} // 0x00000001871D9630-0x00000001871D9870
		public float CurrentHealth() => default; // 0x00000001871D9870-0x00000001871D9890
		public void Despawn() {} // 0x00000001871D9890-0x00000001871D98C0
		public void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x01978193 */, float damageKb = 1f /* Metadata: 0x01978194 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x01978198 */, bool hasKb = true /* Metadata: 0x01978199 */) {} // 0x00000001871D98C0-0x00000001871D9900
		public GameObject GetGameObject() => default; // 0x00000001871D9900-0x00000001871D9920
		public void GiveReward(Action<Pickup> onRewardGiven = null) {} // 0x00000001871D9920-0x00000001871D9940
		public bool IsUnitDead() => default; // 0x00000001871D9940-0x00000001871D9960
		public float MaxHp() => default; // 0x00000001871D9960-0x00000001871D9980
		public void OnGetDamaged(HitVfxType hitVfxType, bool hasKb = true /* Metadata: 0x0197819A */) {} // 0x00000001871D9980-0x00000001871D99B0
	}
}
