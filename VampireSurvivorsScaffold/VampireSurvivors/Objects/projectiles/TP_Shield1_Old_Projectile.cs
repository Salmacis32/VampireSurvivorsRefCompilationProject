/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
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
	public class TP_Shield1_Old_Projectile : Projectile // TypeDefIndex: 15652
	{
		// Fields
		private MultiTargetTween _scaleTween; // 0xD0
		private MultiTargetTween _alphaTween; // 0xD8
		private Vector3 _offsetLeft; // 0xE0
		private Vector3 _offsetRight; // 0xEC
		private Vector3 _offsetPos; // 0xF8
		private bool _storedFlip; // 0x104
		private int _hitCounter; // 0x108
		private float _moveSpeedPerc; // 0x10C
		private PhaserSprite _greyscaleSprite; // 0x110
		private bool _despawning; // 0x118
		private VampireSurvivors.Framework.TimerSystem.Timer _despawnTimer; // 0x120
	
		// Constructors
		public TP_Shield1_Old_Projectile() {} // 0x0000000186D0D2F0-0x0000000186D0D350
	
		// Methods
		protected override void Awake() {} // 0x0000000186D0C850-0x0000000186D0CA70
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D0CA70-0x0000000186D0CE10
		private void LateUpdate() {} // 0x0000000186D0CE10-0x0000000186D0D0B0
		public override void InternalUpdate() {} // 0x0000000186D0D0B0-0x0000000186D0D1B0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186D0D1B0-0x0000000186D0D230
		protected override void OnHasHitAnotherPlayerObject(IDamageable other) {} // 0x0000000186D0D1B0-0x0000000186D0D230
		public override void Despawn() {} // 0x0000000186D0D230-0x0000000186D0D2F0
	}
}
