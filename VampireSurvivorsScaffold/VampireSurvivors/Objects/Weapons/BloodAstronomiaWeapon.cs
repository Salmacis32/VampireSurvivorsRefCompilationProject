/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using QFSW.MOP2;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class BloodAstronomiaWeapon : Weapon // TypeDefIndex: 16139
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _LineTop; // 0x158
		[SerializeField]
		private SpriteRenderer _LineBottom; // 0x160
		[SerializeField]
		private Transform DirectionalDamageCointainer; // 0x168
		[SerializeField]
		private SpriteRenderer _Image; // 0x170
		private MultiTargetTween _imageTween; // 0x178
		private MultiTargetTween _imageTween2; // 0x180
		private BulletPool _garlicPool; // 0x188
		private BulletPool _songPool; // 0x190
		private BulletPool _pentagramPool; // 0x198
		private BulletPool _laurelPool; // 0x1A0
		private BulletPool _lancetPool; // 0x1A8
		private ObjectPool _moonExplosionPool; // 0x1B0
		private BulletPool _streamPool; // 0x1B8
		private BulletPool _rapidusPool; // 0x1C0
		private bool _hasRapidus; // 0x1C8
		private ParticleEmitterManager _pfxManager; // 0x1D0
		private ParticleSystem _pfx; // 0x1D8
		private const float ImagePixelSize = 16f; // Metadata: 0x01977B7D
	
		// Properties
		public Weapon Garlic { get; set; } // 0x0000000185D98490-0x0000000185D984A0 0x00000001867471B0-0x0000000186747210
		public Weapon Song { get; set; } // 0x0000000185D984A0-0x0000000185D984B0 0x0000000186747210-0x0000000186747270
		public Weapon Pentagram { get; set; } // 0x0000000186747270-0x0000000186747280 0x0000000186747280-0x00000001867472E0
		public Weapon Laurel { get; set; } // 0x0000000182767040-0x0000000182767050 0x0000000182767050-0x00000001827670B0
		public Weapon Lancet { get; set; } // 0x00000001858341D0-0x00000001858341E0 0x0000000186753320-0x0000000186753380
		public Weapon Stream { get; set; } // 0x00000001854006C0-0x00000001854006D0 0x00000001812D6360-0x00000001812D63C0
		public Weapon Rapidus { get; set; } // 0x0000000185FA1D70-0x0000000185FA1D80 0x0000000186753380-0x00000001867533E0
	
		// Constructors
		public BloodAstronomiaWeapon() {} // 0x0000000186F23750-0x0000000186F237A0
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F1E9D0-0x0000000186F1F8E0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977B6C */) {} // 0x0000000186F1F8E0-0x0000000186F1F990
		public override void InternalUpdate() {} // 0x0000000186F1F990-0x0000000186F1FCE0
		public void SpawnBloodExplosionVfxAt(float2 pos, float damage = 1f /* Metadata: 0x01977B6D */, float radius = 1f /* Metadata: 0x01977B71 */) {} // 0x0000000186F1FCE0-0x0000000186F1FD20
		public void SpawnBloodExplosionVfxAt(float xPos, float yPos, float damage = 1f /* Metadata: 0x01977B75 */, float radius = 1f /* Metadata: 0x01977B79 */) {} // 0x0000000186F1FD20-0x0000000186F1FF10
		public override void SetVisible(bool visible) {} // 0x0000000186F1FF10-0x0000000186F1FF90
		public override float PPower() => default; // 0x0000000186F1FF90-0x0000000186F1FFE0
		public override float PAmount() => default; // 0x0000000185C0CCB0-0x0000000185C0CCC0
		public override float PArea() => default; // 0x0000000186F1FFE0-0x0000000186F20060
		public void FireGarlic() {} // 0x0000000186F20060-0x0000000186F20400
		public void FireSong() {} // 0x0000000186F20400-0x0000000186F20650
		public void FirePentagram() {} // 0x0000000186F20650-0x0000000186F20700
		public void FireLaurel() {} // 0x0000000186F20700-0x0000000186F20890
		public void FireLancet() {} // 0x0000000186F20890-0x0000000186F20A20
		public void FireStream() {} // 0x0000000186F20A20-0x0000000186F20D80
		public void FireTPRapidus() {} // 0x0000000186F20D80-0x0000000186F217F0
		public override void Cleanup() {} // 0x0000000186F217F0-0x0000000186F219F0
		protected override void OnStart() {} // 0x0000000186F219F0-0x0000000186F226C0
		protected virtual bool OnGarlicOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F226C0-0x0000000186F22870
		protected virtual bool OnSongOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F22870-0x0000000186F22B60
		protected virtual bool OnPentagramOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F22B60-0x0000000186F22F70
		protected virtual bool OnLaurelOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F22F70-0x0000000186F232B0
		protected virtual bool OnLancetOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F232B0-0x0000000186F23460
		protected virtual bool OnTPRapidusOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F23460-0x0000000186F23750
	}
}
