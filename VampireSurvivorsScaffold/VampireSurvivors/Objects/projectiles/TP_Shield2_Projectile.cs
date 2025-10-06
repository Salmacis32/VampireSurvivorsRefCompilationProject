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
	public class TP_Shield2_Projectile : Projectile // TypeDefIndex: 15655
	{
		// Fields
		private float _bodyRadius; // 0xD0
		private PhaserSprite _displaySprite1; // 0xD8
		private PhaserSprite _displaySprite2; // 0xE0
		private MultiTargetTween _alphaTween1; // 0xE8
		private MultiTargetTween _alphaTween2; // 0xF0
		private VampireSurvivors.Framework.TimerSystem.Timer _hitBoxTimer; // 0xF8
		private VampireSurvivors.Framework.TimerSystem.Timer _durationTimer; // 0x100
		private TP_Shield2_Weapon _trueWeapon; // 0x108
		private VampireSurvivors.Framework.TimerSystem.Timer _selfDelayTimer; // 0x110
		private bool _canShoot; // 0x118
		private PhaserSprite _displaySprite3; // 0x120
		private MultiTargetTween _alphaTween3; // 0x128
	
		// Constructors
		public TP_Shield2_Projectile() {} // 0x0000000186D12600-0x0000000186D12660
	
		// Methods
		protected override void Awake() {} // 0x0000000186D10590-0x0000000186D10CA0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D10CA0-0x0000000186D118F0
		public void StartDespawn() {} // 0x0000000186D118F0-0x0000000186D11BE0
		public override void InternalUpdate() {} // 0x0000000186D11BE0-0x0000000186D11C40
		private void UpdatePosition() {} // 0x0000000186D11C40-0x0000000186D11F90
		public override void Despawn() {} // 0x0000000186D11F90-0x0000000186D12040
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186D12040-0x0000000186D12600
	}
}
