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
	public class TP_SacredBeasts1_Projectile : Projectile // TypeDefIndex: 15646
	{
		// Fields
		private float _bodyRadius; // 0xD0
		private PhaserSprite _displaySprite1; // 0xD8
		private PhaserSprite _displaySprite2; // 0xE0
		private MultiTargetTween _alphaTween1; // 0xE8
		private MultiTargetTween _alphaTween2; // 0xF0
		private VampireSurvivors.Framework.TimerSystem.Timer _hitBoxTimer; // 0xF8
		private VampireSurvivors.Framework.TimerSystem.Timer _durationTimer; // 0x100
		private TP_SacredBeasts1_Weapon _trueWeapon; // 0x108
		private VampireSurvivors.Framework.TimerSystem.Timer _selfDelayTimer; // 0x110
		private bool _canShoot; // 0x118
	
		// Constructors
		public TP_SacredBeasts1_Projectile() {} // 0x0000000186D076C0-0x0000000186D07720
	
		// Methods
		protected override void Awake() {} // 0x0000000186D05F90-0x0000000186D06340
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D06340-0x0000000186D06C00
		public void StartDespawn() {} // 0x0000000186D06C00-0x0000000186D06EA0
		public override void InternalUpdate() {} // 0x0000000186D06EA0-0x0000000186D06EB0
		private void UpdatePosition() {} // 0x0000000186D06EB0-0x0000000186D07200
		public override void Despawn() {} // 0x0000000186D07200-0x0000000186D07290
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186D07290-0x0000000186D076C0
	}
}
