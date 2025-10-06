/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Ice1_Projectile : Projectile // TypeDefIndex: 15592
	{
		// Fields
		private float _radius; // 0xD0
		private PhaserSprite _animatedSprite; // 0xD8
		private Tween _radiusTween; // 0xE0
		private PhaserSprite _staticSprite; // 0xE8
		private MultiTargetTween _alphaTween; // 0xF0
	
		// Constructors
		public TP_Ice1_Projectile() {} // 0x0000000186CCAA90-0x0000000186CCAAF0
	
		// Methods
		protected override void Awake() {} // 0x0000000186CC96B0-0x0000000186CC9C80
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CC9C80-0x0000000186CCA250
		private void CopyPosition() {} // 0x0000000186CCA250-0x0000000186CCA2B0
		private void Attack(Vector2 offset) {} // 0x0000000186CCA2B0-0x0000000186CCA690
		private void StartDespawn() {} // 0x0000000186CCA690-0x0000000186CCA980
		public override void Despawn() {} // 0x0000000186CCA980-0x0000000186CCAA00
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186CCAA00-0x0000000186CCAA90
	}
}
