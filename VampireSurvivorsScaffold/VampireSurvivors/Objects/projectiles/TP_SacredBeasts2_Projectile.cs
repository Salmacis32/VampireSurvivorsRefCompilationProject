/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_SacredBeasts2_Projectile : Projectile // TypeDefIndex: 15647
	{
		// Fields
		private MultiTargetTween _scaleTween; // 0xD0
		private float _bodyRadius; // 0xD8
		private VampireSurvivors.Framework.TimerSystem.Timer _hitBoxTimer; // 0xE0
		private VampireSurvivors.Framework.TimerSystem.Timer _durationTimer; // 0xE8
		private PhaserSprite _displaySprite1; // 0xF0
		private PhaserSprite _displaySprite2; // 0xF8
		private PhaserSprite _displaySprite3; // 0x100
		private PhaserSprite _displaySprite4; // 0x108
		private PhaserSprite _displaySprite5; // 0x110
		private MultiTargetTween _alphaTween1; // 0x118
		private MultiTargetTween _alphaTween2; // 0x120
		private MultiTargetTween _alphaTween3; // 0x128
		private MultiTargetTween _alphaTween4; // 0x130
		private MultiTargetTween _alphaTween5; // 0x138
		private TP_SacredBeasts1_Weapon _trueWeapon; // 0x140
		private VampireSurvivors.Framework.TimerSystem.Timer _selfDelayTimer; // 0x148
		private bool _canShoot; // 0x150
	
		// Constructors
		public TP_SacredBeasts2_Projectile() {} // 0x0000000186D09A90-0x0000000186D09AF0
	
		// Methods
		protected override void Awake() {} // 0x0000000186D077B0-0x0000000186D07EC0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D07EC0-0x0000000186D08750
		private void StartAlphaTweens() {} // 0x0000000186D08750-0x0000000186D08F00
		public void StartDespawn() {} // 0x0000000186D08F00-0x0000000186D09190
		public override void InternalUpdate() {} // 0x0000000186D09190-0x0000000186D091A0
		private void UpdatePosition() {} // 0x0000000186D091A0-0x0000000186D09590
		public override void Despawn() {} // 0x0000000186D09590-0x0000000186D09660
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186D09660-0x0000000186D09A90
	}
}
