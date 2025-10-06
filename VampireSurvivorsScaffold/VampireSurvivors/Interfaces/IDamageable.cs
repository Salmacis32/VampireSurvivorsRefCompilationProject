/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Pickups;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Interfaces
{
	public interface IDamageable // TypeDefIndex: 14517
	{
		// Methods
		void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x01977144 */, float damageKb = 1f /* Metadata: 0x01977145 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x01977149 */, bool hasKb = true /* Metadata: 0x0197714A */);
		void OnGetDamaged(HitVfxType hitVfxType, bool hasKb = true /* Metadata: 0x0197714B */);
		bool IsUnitDead();
		float MaxHp();
		float CurrentHealth();
		GameObject GetGameObject();
		void Despawn();
		void GiveReward(Action<Pickup> onRewardGiven = null);
	}
}
