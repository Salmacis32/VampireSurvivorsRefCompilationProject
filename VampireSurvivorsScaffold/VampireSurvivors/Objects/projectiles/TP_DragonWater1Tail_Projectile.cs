/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_DragonWater1Tail_Projectile : Projectile // TypeDefIndex: 15556
	{
		// Fields
		private float _radius; // 0xD0
		private TP_DragonWater1Head_Projectile _headProjectile; // 0xD8
		private int _frameCounter; // 0xE0
		private bool _lateInit; // 0xE4
		private PhaserSprite _animatedSprite; // 0xE8
		private const int AnimFPS = 30; // Metadata: 0x019776D7
		private Tween _radiusTween; // 0xF0
		private MultiTargetTween _scaleTween; // 0xF8
		private MultiTargetTween _alphaTween; // 0x100
	
		// Constructors
		public TP_DragonWater1Tail_Projectile() {} // 0x0000000186C9C3F0-0x0000000186C9C450
	
		// Methods
		protected override void Awake() {} // 0x0000000186C9B460-0x0000000186C9B780
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C9B780-0x0000000186C9BC40
		public override void InternalUpdate() {} // 0x0000000186C9BC40-0x0000000186C9C020
		public void StartDespawn() {} // 0x0000000186C9C020-0x0000000186C9C2C0
		public override void Despawn() {} // 0x0000000186C9C2C0-0x0000000186C9C330
		public void SetHead(TP_DragonWater1Head_Projectile head) {} // 0x00000001826AC0D0-0x00000001826ACAE0
		public void SetDepth(int depth) {} // 0x0000000186C9C330-0x0000000186C9C360
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186C9C360-0x0000000186C9C3F0
	}
}
