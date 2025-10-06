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
	public class TP_Savrog2Union_Spinning_Projectile : Projectile // TypeDefIndex: 15975
	{
		// Fields
		private MultiTargetTween _tween1; // 0xD0
		protected PhaserSprite _spikeSprite; // 0xD8
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0xE0
		private bool _isFading; // 0xE8
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xF0
		private float _radius; // 0xF8
		private TP_Savrog2Union_Weapon _trueWeapon; // 0x100
		private float _deltaTime; // 0x108
		private bool _isInverted; // 0x10C
	
		// Constructors
		public TP_Savrog2Union_Spinning_Projectile() {} // 0x0000000186E84EE0-0x0000000186E84F40
	
		// Methods
		protected override void Awake() {} // 0x0000000186E83BF0-0x0000000186E84060
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E84060-0x0000000186E84830
		public void SetInversion(bool isInverted = false /* Metadata: 0x019779BF */) {} // 0x0000000181945D80-0x0000000181945D90
		public override void InternalUpdate() {} // 0x0000000186E84830-0x0000000186E84B40
		public override void Despawn() {} // 0x0000000186D0A7B0-0x0000000186D0A850
		protected void FadeOut() {} // 0x0000000186E84B40-0x0000000186E84E50
		protected void DoHeartOfFireExplosion() {} // 0x0000000186E84E50-0x0000000186E84EE0
	}
}
