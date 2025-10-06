/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Elec1_Projectile : Projectile // TypeDefIndex: 15560
	{
		// Fields
		[SerializeField]
		private TrailRenderer _Trail; // 0xD0
		private float _radius; // 0xD8
		private PhaserSprite _animatedSprite; // 0xE0
		private Tween _radiusTween; // 0xE8
		private TweenerCore<Vector3, Vector3, VectorOptions> moveTween; // 0xF0
		private Vector3 targetPosition; // 0xF8
	
		// Constructors
		public TP_Elec1_Projectile() {} // 0x0000000186CA0650-0x0000000186CA06B0
	
		// Methods
		protected override void Awake() {} // 0x0000000186C9F560-0x0000000186C9FBA0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C9FBA0-0x0000000186CA0150
		private void Strike() {} // 0x0000000186CA0150-0x0000000186CA0460
		public void SetTargetPosition(Vector3 target) {} // 0x0000000186CA0460-0x0000000186CA0540
		public override void Despawn() {} // 0x0000000186CA0540-0x0000000186CA0650
	}
}
