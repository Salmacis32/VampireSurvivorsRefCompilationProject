/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Energy1_Projectile : Projectile // TypeDefIndex: 15564
	{
		// Fields
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xD0
		private float _saveVelX; // 0xD8
		private float _saveVelY; // 0xDC
		private float _spriteSize; // 0xE0
		private float _bodyRadius; // 0xE4
		protected float[] _firingAngles; // 0xE8
		private MultiTargetTween _scaleTween; // 0xF0
	
		// Constructors
		public TP_Energy1_Projectile() {} // 0x0000000186CA4A30-0x0000000186CA4B40
	
		// Methods
		protected override void Awake() {} // 0x0000000186CA3B00-0x0000000186CA3C90
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CA3C90-0x0000000186CA4350
		public override void InternalUpdate() {} // 0x0000000186CA4350-0x0000000186CA4490
		private void Bounce(Body b, bool up, bool down, bool left, bool right) {} // 0x0000000186CA4490-0x0000000186CA4500
		private void PlayBounceSFX() {} // 0x0000000186CA4500-0x0000000186CA4620
		private void FadeOutAndDispose() {} // 0x0000000186CA4620-0x0000000186CA4900
		public override void OnHasHitWallPhaser(PhaserTile tile) {} // 0x0000000186CA4900-0x0000000186CA49F0
		public override void Despawn() {} // 0x0000000186CA49F0-0x0000000186CA4A30
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000180B15170-0x0000000180B15180
	}
}
