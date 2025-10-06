/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class FireballProjectile : Projectile // TypeDefIndex: 15872
	{
		// Fields
		private ParticleSystem _pfxEmitter; // 0xD0
		private Tween _scaleTween; // 0xD8
	
		// Constructors
		public FireballProjectile() {} // 0x0000000186E064C0-0x0000000186E06510
	
		// Methods
		protected override void Awake() {} // 0x0000000186E04E10-0x0000000186E04E30
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E04E30-0x0000000186E051A0
		public override void SetTarget(Transform target) {} // 0x0000000186E051A0-0x0000000186E05B10
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186E05B10-0x0000000186E05B20
		protected override void OnHasHitAnotherPlayerObject(IDamageable other) {} // 0x0000000186E05B20-0x0000000186E05BD0
		private void OnHasHitAnObjectLogic(IDamageable other, bool triggerHit) {} // 0x0000000186E05BD0-0x0000000186E05D70
		public override void OnHasHitWallPhaser(PhaserTile tile) {} // 0x0000000186E05D70-0x0000000186E05F50
		public override void Despawn() {} // 0x0000000186E05F50-0x0000000186E05FE0
		private void GenerateParticleSystem() {} // 0x0000000186E05FE0-0x0000000186E064C0
	}
}
