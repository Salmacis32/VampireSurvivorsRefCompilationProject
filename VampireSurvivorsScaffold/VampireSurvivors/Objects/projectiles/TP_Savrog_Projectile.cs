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
	public class TP_Savrog_Projectile : Projectile // TypeDefIndex: 15648
	{
		// Fields
		private MultiTargetTween _tween1; // 0xD0
		protected PhaserSprite _spikeSprite; // 0xD8
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0xE0
		private bool _isFading; // 0xE8
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xF0
		private float _radius; // 0xF8
	
		// Constructors
		public TP_Savrog_Projectile() {} // 0x0000000186D0AB80-0x0000000186D0ABE0
	
		// Methods
		protected override void Awake() {} // 0x0000000186D09B70-0x0000000186D09FE0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D09FE0-0x0000000186D0A7B0
		public override void InternalUpdate() {} // 0x0000000180B15170-0x0000000180B15180
		public override void Despawn() {} // 0x0000000186D0A7B0-0x0000000186D0A850
		protected void FadeOut() {} // 0x0000000186D0A850-0x0000000186D0AA90
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186D0AA90-0x0000000186D0AB80
	}
}
