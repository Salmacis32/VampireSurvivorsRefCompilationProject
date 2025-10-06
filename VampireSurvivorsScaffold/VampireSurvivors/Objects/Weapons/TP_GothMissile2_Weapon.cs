/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_GothMissile2_Weapon : Weapon // TypeDefIndex: 16371
	{
		// Fields
		[SerializeField]
		private Projectile _SongProjectilePrefab; // 0x158
		private const float FireDelayMillis = 700f; // Metadata: 0x01977C76
		private const float SniperAlpha = 0.8f; // Metadata: 0x01977C7A
		private const float SongDamageMultiplier = 2.5f; // Metadata: 0x01977C7E
		private BulletPool _songProjectilePool; // 0x160
		private PhaserSprite _sniperSprite1; // 0x168
		private PhaserSprite _sniperSprite2; // 0x170
		private PhaserSprite _sniperSprite1A; // 0x178
		private PhaserSprite _sniperSprite1B; // 0x180
		private PhaserSprite _sniperSprite2A; // 0x188
		private PhaserSprite _sniperSprite2B; // 0x190
		private PhaserSprite _sniperSprite1_BG; // 0x198
		private PhaserSprite _sniperSprite2_BG; // 0x1A0
		private PhaserSprite _sniperSprite1A_BG; // 0x1A8
		private PhaserSprite _sniperSprite1B_BG; // 0x1B0
		private PhaserSprite _sniperSprite2A_BG; // 0x1B8
		private PhaserSprite _sniperSprite2B_BG; // 0x1C0
		private MultiTargetTween _sniperTween1; // 0x1C8
		private MultiTargetTween _sniperTween2; // 0x1D0
		private MultiTargetTween _critSniperTween; // 0x1D8
		private VampireSurvivors.Framework.TimerSystem.Timer _critSniperTimer; // 0x1E0
		private VampireSurvivors.Framework.TimerSystem.Timer _songFiringTimer; // 0x1E8
	
		// Constructors
		public TP_GothMissile2_Weapon() {} // 0x0000000186FBD8B0-0x0000000186FBD900
	
		// Methods
		public override float PInterval() => default; // 0x0000000186FB9F70-0x0000000186FB9F90
		protected override void OnStart() {} // 0x0000000186FB9F90-0x0000000186FBA730
		public override void CheckArcanas() {} // 0x0000000186FBA730-0x0000000186FBA820
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977C6F */) {} // 0x0000000186FBA820-0x0000000186FBAE40
		private void FireMissiles(int index, bool isCrit) {} // 0x0000000186FBAE40-0x0000000186FBB7F0
		private PhaserSprite CreateSniperSprite(ref PhaserSprite spriteBG, bool mainSniper = false /* Metadata: 0x01977C70 */, bool flipped = false /* Metadata: 0x01977C71 */, float2? extraOffset = default) => default; // 0x0000000186FBB7F0-0x0000000186FBC250
		private void ShowCritSnipers(bool show) {} // 0x0000000186FBC250-0x0000000186FBCA50
		private void PlayCritSfx(float detune = 0f /* Metadata: 0x01977C72 */) {} // 0x0000000186FBCA50-0x0000000186FBCB70
		private void DoSniperTweens() {} // 0x0000000186FBCB70-0x0000000186FBD0B0
		public override void SetVisible(bool visible) {} // 0x0000000186FBD0B0-0x0000000186FBD210
		public override void Cleanup() {} // 0x0000000186FBD210-0x0000000186FBD740
		private bool OnBulletOverlapsEnemy_Song(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186FBD740-0x0000000186FBD8B0
	}
}
