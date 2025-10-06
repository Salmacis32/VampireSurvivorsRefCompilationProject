/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_AlucardShield_Projectile : Projectile // TypeDefIndex: 15495
	{
		// Fields
		private float _bodyRadius; // 0xD0
		private PhaserSprite _displaySprite1; // 0xD8
		private MultiTargetTween _alphaTween1; // 0xE0
		private MultiTargetTween _alphaTween2; // 0xE8
		private VampireSurvivors.Framework.TimerSystem.Timer _hitBoxTimer; // 0xF0
		private VampireSurvivors.Framework.TimerSystem.Timer _durationTimer; // 0xF8
		private TP_AlucardShield_Weapon _trueWeapon; // 0x100
		private VampireSurvivors.Framework.TimerSystem.Timer _selfDelayTimer; // 0x108
	
		// Constructors
		public TP_AlucardShield_Projectile() {} // 0x0000000186C38210-0x0000000186C38270
	
		// Methods
		protected override void Awake() {} // 0x0000000186C37120-0x0000000186C373A0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C373A0-0x0000000186C37BB0
		public void StartDespawn() {} // 0x0000000186C37BB0-0x0000000186C37E50
		public override void InternalUpdate() {} // 0x0000000186C37E50-0x0000000186C37E60
		private void UpdatePosition() {} // 0x0000000186C37E60-0x0000000186C38180
		public override void Despawn() {} // 0x0000000186C38180-0x0000000186C38210
	}
}
