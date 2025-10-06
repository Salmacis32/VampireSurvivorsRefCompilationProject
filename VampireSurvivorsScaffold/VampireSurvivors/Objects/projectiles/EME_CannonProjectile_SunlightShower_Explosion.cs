/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
	public class EME_CannonProjectile_SunlightShower_Explosion : Projectile // TypeDefIndex: 15763
	{
		// Fields
		[SerializeField]
		private ParticleSystem _ExplosionBlueVFX; // 0xD0
		[SerializeField]
		private ParticleSystem _ExplosionOrangeVFX; // 0xD8
		private const float Radius = 36f; // Metadata: 0x019777E2
		private const float VFXScale = 1f; // Metadata: 0x019777E6
		private const float VFXDurationMS = 700f; // Metadata: 0x019777EA
		private const float TimeBetweenExplosionsMS = 200f; // Metadata: 0x019777EE
		private const float BodyDuration = 600f; // Metadata: 0x019777F2
		private List<ParticleSystem> _vfxList; // 0xE0
		private VampireSurvivors.Framework.TimerSystem.Timer _vfxTimer; // 0xE8
		private VampireSurvivors.Framework.TimerSystem.Timer _bodyTimer; // 0xF0
		private MultiTargetTween _screenShakeTween; // 0xF8
		private bool _hasExploded; // 0x100
	
		// Constructors
		public EME_CannonProjectile_SunlightShower_Explosion() {} // 0x0000000186D7DC50-0x0000000186D7DCA0
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D7C920-0x0000000186D7CC60
		private void LateUpdate() {} // 0x0000000186C16150-0x0000000186C16170
		private void PlayVFX(ParticleSystem vfx) {} // 0x0000000186D7CC60-0x0000000186D7CE40
		private void DoFirstVFX() {} // 0x0000000186D7CE40-0x0000000186D7D110
		private void DoSecondVFX() {} // 0x0000000186D7D110-0x0000000186D7D270
		private void PlaySfx() {} // 0x0000000186D7D270-0x0000000186D7D3B0
		public override void Despawn() {} // 0x0000000186D7D3B0-0x0000000186D7D590
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186D7D590-0x0000000186D7D6A0
		private void DoScreenShake() {} // 0x0000000186D7D6A0-0x0000000186D7DC50
	}
}
