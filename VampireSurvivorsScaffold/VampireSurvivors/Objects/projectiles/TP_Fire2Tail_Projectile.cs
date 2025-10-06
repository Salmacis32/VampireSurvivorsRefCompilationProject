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
	public class TP_Fire2Tail_Projectile : Projectile // TypeDefIndex: 15570
	{
		// Fields
		private float _radius; // 0xD0
		private TP_Fire2_Projectile _headProjectile; // 0xD8
		private int _frameCounter; // 0xE0
		private bool _lateInit; // 0xE4
		private PhaserSprite _animatedSprite; // 0xE8
		private const int AnimFPS = 30; // Metadata: 0x019776F3
		private Tween _radiusTween; // 0xF0
		private MultiTargetTween _scaleTween; // 0xF8
		private MultiTargetTween _alphaTween; // 0x100
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x108
	
		// Constructors
		public TP_Fire2Tail_Projectile() {} // 0x0000000186CAEE10-0x0000000186CAEE70
	
		// Methods
		protected override void Awake() {} // 0x0000000186CADD00-0x0000000186CAE020
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CAE020-0x0000000186CAE4E0
		public override void InternalUpdate() {} // 0x0000000186CAE4E0-0x0000000186CAEA00
		public void StartDespawn() {} // 0x0000000186CAEA00-0x0000000186CAECA0
		public override void Despawn() {} // 0x0000000186CAECA0-0x0000000186CAED20
		public void SetHead(TP_Fire2_Projectile head) {} // 0x00000001826AC0D0-0x00000001826ACAE0
		public void SetDepth(int depth) {} // 0x0000000186C9C330-0x0000000186C9C360
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186CAED20-0x0000000186CAEE10
	}
}
