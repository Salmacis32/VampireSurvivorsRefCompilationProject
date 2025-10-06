/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_CannonProjectile_BombardingFire_Missile : Projectile // TypeDefIndex: 15756
	{
		// Fields
		[SerializeField]
		private ParticleSystem _MissileVFX; // 0xD0
		[SerializeField]
		private TrailRenderer _Trail; // 0xD8
		private const float VFXScale = 0.8f; // Metadata: 0x019777CE
		private const float FallDurationMS = 500f; // Metadata: 0x019777D2
		private Tween _positionTween; // 0xE0
		private VampireSurvivors.Framework.TimerSystem.Timer _despawnTimer; // 0xE8
		private VampireSurvivors.Framework.TimerSystem.Timer _sfxTimer; // 0xF0
	
		// Constructors
		public EME_CannonProjectile_BombardingFire_Missile() {} // 0x0000000186D79DB0-0x0000000186D79E00
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D78C30-0x0000000186D78F80
		public void MoveToTarget(float2 targetPos) {} // 0x0000000186D78F80-0x0000000186D79370
		private void Explode() {} // 0x0000000186D79370-0x0000000186D79680
		private void PlaySfx() {} // 0x0000000186D79680-0x0000000186D79760
		public override void Despawn() {} // 0x0000000186D79760-0x0000000186D79890
		private void SetupTrail() {} // 0x0000000186D79890-0x0000000186D79DB0
	}
}
