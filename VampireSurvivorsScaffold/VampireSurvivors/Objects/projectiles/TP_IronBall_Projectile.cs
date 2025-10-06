/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_IronBall_Projectile : Projectile // TypeDefIndex: 15600
	{
		// Fields
		protected const float Radius = 12f; // Metadata: 0x0197775E
		protected const float Grav = 6.25f; // Metadata: 0x01977762
		protected Vector2 _velocity; // 0xD0
		protected float _startingAngle; // 0xD8
		protected float _saveVelX; // 0xDC
		protected float _saveVelY; // 0xE0
		protected bool _hasHitScreenBottom; // 0xE4
		protected Tween _angleTween; // 0xE8
		protected MultiTargetTween _scaleTween; // 0xF0
	
		// Properties
		public override float ProjectileSpeed { get => default; } // 0x0000000186CD44E0-0x0000000186CD45F0 
	
		// Constructors
		public TP_IronBall_Projectile() {} // 0x0000000186CD4460-0x0000000186CD44B0
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CD45F0-0x0000000186CD4E20
		public override void InternalUpdate() {} // 0x0000000186CD4E20-0x0000000186CD4FB0
		public virtual void OnHittingScreenBottom() {} // 0x0000000186CD4FB0-0x0000000186CD5040
		public override void OnHasHitWallPhaser(PhaserTile tile) {} // 0x0000000186CD5040-0x0000000186CD50F0
		public override void Despawn() {} // 0x0000000186C353D0-0x0000000186C35420
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186CD50F0-0x0000000186CD5100
		protected override void OnHasHitAnotherPlayerObject(IDamageable other) {} // 0x0000000186CD5100-0x0000000186CD5110
		private void OnHasHitAnObjectLogic(IDamageable other, bool triggerHit) {} // 0x0000000186CD5110-0x0000000186CD5280
		protected void ScreenShake() {} // 0x0000000186CD5280-0x0000000186CD57A0
		protected void PlayHitSFX() {} // 0x0000000186CD57A0-0x0000000186CD5870
	}
}
