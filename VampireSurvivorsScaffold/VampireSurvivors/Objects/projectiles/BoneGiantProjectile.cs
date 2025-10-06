/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class BoneGiantProjectile : Projectile // TypeDefIndex: 15397
	{
		// Fields
		private MultiTargetTween _angleTween; // 0xD0
		private MultiTargetTween _scaleTween; // 0xD8
		private float _saveVelX; // 0xE0
		private float _saveVelY; // 0xE4
		private VampireSurvivors.Framework.TimerSystem.Timer _bounceTimer; // 0xE8
		private bool _canBounce; // 0xF0
		private bool _isAttached; // 0xF1
		private bool _isSpinning; // 0xF2
		[NonSerialized]
		public PhaserSprite _displaySprite; // 0xF8
		[NonSerialized]
		public Vector2 _anchorPosition; // 0x100
		private MultiTargetTween _attachTween; // 0x108
	
		// Constructors
		public BoneGiantProjectile() {} // 0x0000000186BBA9B0-0x0000000186BBAA00
	
		// Methods
		protected override void Awake() {} // 0x0000000186BB8750-0x0000000186BB8880
		protected override void OnDestroy() {} // 0x0000000186BB8880-0x0000000186BB8920
		private void CreateDisplaySprite() {} // 0x0000000186BB8920-0x0000000186BB8E80
		public void Attach() {} // 0x0000000186BB8E80-0x0000000186BB91F0
		public void OnAttached() {} // 0x0000000186BB91F0-0x0000000186BB9460
		public void Detach(float angle) {} // 0x0000000186BB9460-0x0000000186BB97D0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BB97D0-0x0000000186BB9D70
		protected void Bounce(Body bdy, bool up, bool down, bool left, bool right) {} // 0x0000000186BB9D70-0x0000000186BB9DD0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186BB9DD0-0x0000000186BB9F90
		public override void OnHasHitWallPhaser(PhaserTile tile) {} // 0x0000000186BB9F90-0x0000000186BBA080
		public override void InternalUpdate() {} // 0x0000000186BBA080-0x0000000186BBA190
		public override void Despawn() {} // 0x0000000186BBA190-0x0000000186BBA2B0
		public void AdjustBodyOffset() {} // 0x0000000186BBA2B0-0x0000000186BBA4B0
		public void Spinnn(float angle, float duration, int times) {} // 0x0000000186BBA4B0-0x0000000186BBA940
		public void SetProjectileVisible(bool visible) {} // 0x0000000186BBA940-0x0000000186BBA9B0
	}
}
