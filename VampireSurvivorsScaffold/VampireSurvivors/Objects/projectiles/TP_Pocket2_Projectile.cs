/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Pocket2_Projectile : Projectile // TypeDefIndex: 15631
	{
		// Fields
		[SerializeField]
		private Transform _BodyTarget1; // 0xD0
		[SerializeField]
		private Transform _BodyTarget2; // 0xD8
		private TP_Pocket2_Weapon _trueWeapon; // 0xE0
		private TP_Pocket2_InvisibleProjectile _invisibleProjectile1; // 0xE8
		private TP_Pocket2_InvisibleProjectile _invisibleProjectile2; // 0xF0
		private PhaserSprite _swordSprite; // 0xF8
		private ParticleEmitterManager _pfxManager; // 0x100
		private ParticleSystem _pfx; // 0x108
		private MultiTargetTween _rotateTween; // 0x110
		private MultiTargetTween _fadeTween; // 0x118
		private VampireSurvivors.Framework.TimerSystem.Timer _timer; // 0x120
		private bool _isDespawning; // 0x128
	
		// Constructors
		public TP_Pocket2_Projectile() {} // 0x0000000186CF7250-0x0000000186CF72A0
	
		// Methods
		protected override void Awake() {} // 0x0000000186CF4A90-0x0000000186CF5080
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CF5080-0x0000000186CF53C0
		private void PlaySfx() {} // 0x0000000186CF53C0-0x0000000186CF5560
		public override void InternalUpdate() {} // 0x0000000186CF5560-0x0000000186CF5570
		private void UpdatePfx() {} // 0x0000000186CF5570-0x0000000186CF57D0
		public void SetFlip(bool flipped) {} // 0x0000000186CF57D0-0x0000000186CF5990
		private void SetPositonAndRotation(bool flipped) {} // 0x0000000186CF5990-0x0000000186CF5CF0
		private void FadeIn() {} // 0x0000000186CF5CF0-0x0000000186CF6040
		private void CreateInvisibleBody(ref TP_Pocket2_InvisibleProjectile invisibleBody, ref Transform attachPoint) {} // 0x0000000186CF6040-0x0000000186CF6350
		private void EnableInvisibleBody(ref TP_Pocket2_InvisibleProjectile invisibleBody, bool enable) {} // 0x0000000186CF6350-0x0000000186CF6450
		private void GenerateParticleSystem() {} // 0x0000000186CF6450-0x0000000186CF6C80
		private void FadeOut() {} // 0x0000000186CF6C80-0x0000000186CF6F60
		private void WaitForPfx() {} // 0x0000000186CF6F60-0x0000000186CF7060
		public override void Despawn() {} // 0x0000000186CF7060-0x0000000186CF7250
	}
}
