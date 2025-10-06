/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Pocket1_Projectile : Projectile // TypeDefIndex: 15629
	{
		// Fields
		[SerializeField]
		private TrailRenderer _Trail; // 0xD0
		private const float Radius = 8f; // Metadata: 0x0197778A
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xD8
		private Tween _scaleTween; // 0xE0
	
		// Constructors
		public TP_Pocket1_Projectile() {} // 0x0000000186CF46B0-0x0000000186CF4700
	
		// Methods
		protected override void Awake() {} // 0x0000000186CF3560-0x0000000186CF39C0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CF39C0-0x0000000186CF3C30
		private void InitAiming() {} // 0x0000000186CF3C30-0x0000000186CF3CB0
		private void StartTimers() {} // 0x0000000186CF3CB0-0x0000000186CF3DC0
		private void SetupTrail() {} // 0x0000000186CF3DC0-0x0000000186CF42E0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186CF42E0-0x0000000186CF4370
		protected override void OnHasHitAnotherPlayerObject(IDamageable other) {} // 0x0000000186CF4370-0x0000000186CF43C0
		protected void OnHasHitAnObjectLogic(IDamageable other, bool triggerHit) {} // 0x0000000186CF43C0-0x0000000186CF4460
		private void StartDespawn() {} // 0x0000000186CF4460-0x0000000186CF4660
		public override void Despawn() {} // 0x0000000186CF4660-0x0000000186CF46B0
	}
}
