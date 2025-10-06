/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Lapiste2_BigFistProjectile : Projectile // TypeDefIndex: 15607
	{
		// Fields
		private const float Radius = 36f; // Metadata: 0x0197777A
		private PhaserSprite _fistSprite; // 0xD0
		private PhaserSprite _slamSprite; // 0xD8
		private bool _isOnScreen; // 0xE0
		private MultiTargetTween _alphaTween; // 0xE8
		private MultiTargetTween _screenShakeTween; // 0xF0
		private VampireSurvivors.Framework.TimerSystem.Timer _timer; // 0xF8
	
		// Constructors
		public TP_Lapiste2_BigFistProjectile() {} // 0x0000000186CDC560-0x0000000186CDC5B0
	
		// Methods
		protected override void Awake() {} // 0x0000000186CDAB50-0x0000000186CDB440
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CDB440-0x0000000186CDB560
		private void SetBody() {} // 0x0000000186CDB560-0x0000000186CDB620
		private void MoveFistToCentre() {} // 0x0000000186CDB620-0x0000000186CDB7E0
		private void DoFistBump() {} // 0x0000000186CDB7E0-0x0000000186CDB960
		protected void DoScreenShake() {} // 0x0000000186CDB960-0x0000000186CDBEF0
		public override void InternalUpdate() {} // 0x0000000186CDBEF0-0x0000000186CDC060
		private void CheckForSfx() {} // 0x0000000186CDBEF0-0x0000000186CDC060
		private void PlaySfx() {} // 0x0000000186CDC060-0x0000000186CDC130
		private void FadeOut() {} // 0x0000000186CDC130-0x0000000186CDC3E0
		public override void Despawn() {} // 0x0000000186CDC3E0-0x0000000186CDC440
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186CDC440-0x0000000186CDC560
	}
}
