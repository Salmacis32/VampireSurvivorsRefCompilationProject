/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_CannonProjectile_BombardingFire_Explosion : Projectile // TypeDefIndex: 15755
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _GroundVFX; // 0xD0
		[SerializeField]
		private ParticleSystem _ExplosionFX; // 0xD8
		private const float Radius = 48f; // Metadata: 0x019777C6
		private const float VFXScale = 0.8f; // Metadata: 0x019777CA
		private Tween _tween; // 0xE0
		private MultiTargetTween _screenShakeTween; // 0xE8
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xF0
		private bool _hasExploded; // 0xF8
	
		// Constructors
		public EME_CannonProjectile_BombardingFire_Explosion() {} // 0x0000000186D78970-0x0000000186D789C0
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D77300-0x0000000186D77D20
		private void LateUpdate() {} // 0x0000000186C16150-0x0000000186C16170
		private void FadeOut() {} // 0x0000000186D77D20-0x0000000186D77F30
		private void StartDespawn() {} // 0x0000000186D77F30-0x0000000186D78040
		public override void Despawn() {} // 0x0000000186D78040-0x0000000186D78170
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186D78170-0x0000000186D78280
		private void PlaySfx() {} // 0x0000000186D78280-0x0000000186D783C0
		private void DoScreenShake() {} // 0x0000000186D783C0-0x0000000186D78970
	}
}
