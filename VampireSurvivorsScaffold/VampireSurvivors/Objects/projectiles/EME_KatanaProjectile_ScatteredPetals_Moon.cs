/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.VFX.Shatter;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_KatanaProjectile_ScatteredPetals_Moon : Projectile // TypeDefIndex: 15787
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _MoonVFX; // 0xD0
		[SerializeField]
		private ParticleSystem ShatterFX; // 0xD8
		[SerializeField]
		private GameObject TearGO; // 0xE0
		private const float GlobalScale = 1f; // Metadata: 0x01977860
		private const float MoonVFXScale = 0.75f; // Metadata: 0x01977864
		private const float Radius = 100f; // Metadata: 0x01977868
		private ShatterVFX _shatterVfx; // 0xE8
		private MultiTargetTween[] _tweens; // 0xF0
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xF8
		private MultiTargetTween _moveTween; // 0x100
		private MultiTargetTween _fadeTween; // 0x108
		private MultiTargetTween _scaleTween; // 0x110
		private EME_Katana2Weapon _trueWeapon; // 0x118
	
		// Events
		public event Action OnDespawn;
	
		// Constructors
		public EME_KatanaProjectile_ScatteredPetals_Moon() {} // 0x0000000186D909B0-0x0000000186D90A80
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D8EFE0-0x0000000186D8F3C0
		private void Launch() {} // 0x0000000186D8F3C0-0x0000000186D8F810
		private void Explode() {} // 0x0000000186D8F810-0x0000000186D8F920
		private void InitShatterVfx() {} // 0x0000000186D8F920-0x0000000186D8FB60
		private void PlayShatterVfx() {} // 0x0000000186D8FB60-0x0000000186D906F0
		private void KillTweens() {} // 0x0000000186D906F0-0x0000000186D90750
		private static void KillTween(MultiTargetTween[] tweens) {} // 0x0000000186D90750-0x0000000186D907B0
		public override void Despawn() {} // 0x0000000186D907B0-0x0000000186D909B0
	}
}
