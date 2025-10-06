/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class MillionaireWeapon : Weapon, IMillionaire // TypeDefIndex: 16167
	{
		// Fields
		private PhaserSprite _rays1; // 0x158
		private PhaserSprite _rays2; // 0x160
		private float _coinsQueue; // 0x168
		private float _coinsTime; // 0x16C
		private const float CoinsDelay = 0.1f; // Metadata: 0x01977BA6
		private MultiTargetTween _rays1Tween; // 0x170
		private MultiTargetTween _rays2Tween; // 0x178
		private VampireSurvivors.Framework.TimerSystem.Timer _rangedAnimEvent; // 0x180
		private Action<float> _onCoinPickupCallback; // 0x188
	
		// Constructors
		public MillionaireWeapon() {} // 0x0000000186F3B1F0-0x0000000186F3B240
	
		// Methods
		public override float PPower() => default; // 0x0000000186F333E0-0x0000000186F33480
		protected override void OnStart() {} // 0x0000000186F39170-0x0000000186F39190
		public void PlayNextRangedAnim() {} // 0x0000000186F39190-0x0000000186F392D0
		protected override void FakeConstruct() {} // 0x0000000186F392D0-0x0000000186F39970
		public void OnCoinPickup(float value = 1f /* Metadata: 0x01977BA0 */) {} // 0x0000000186F39970-0x0000000186F39990
		public override void Cleanup() {} // 0x0000000186F39990-0x0000000186F39AE0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BA4 */) {} // 0x0000000186F39AE0-0x0000000186F39BF0
		public void Millionaire(float x, float y, float angle, int times = 4 /* Metadata: 0x01977BA5 */) {} // 0x0000000186F39BF0-0x0000000186F3A0A0
		private void RaysVFX(bool left, int repeats) {} // 0x0000000186F3A0A0-0x0000000186F3A8A0
		public override void InternalUpdate() {} // 0x0000000186F3A8A0-0x0000000186F3AA50
		public override void CheckArcanas() {} // 0x0000000186F3AA50-0x0000000186F3AD50
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F33A30-0x0000000186F33A80
		public void FireVolley(Vector2 pos, int _amount, Transform target = null) {} // 0x0000000186F3AD50-0x0000000186F3B1F0
	}
}
