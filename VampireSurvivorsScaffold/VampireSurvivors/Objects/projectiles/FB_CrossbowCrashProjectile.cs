/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class FB_CrossbowCrashProjectile : Projectile // TypeDefIndex: 15464
	{
		// Fields
		private FB_CrossbowCrashWeapon _crossbowCrash; // 0xD0
		private MultiTargetTween _fadeOutTween; // 0xD8
		private Tween _damageOnlyTimer; // 0xE0
		private VampireSurvivors.Framework.TimerSystem.Timer _fadeOutTimer; // 0xE8
		private MultiTargetTween _scaleTween; // 0xF0
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0xF8
	
		// Constructors
		public FB_CrossbowCrashProjectile() {} // 0x0000000186C1B390-0x0000000186C1B3E0
	
		// Methods
		protected override void Awake() {} // 0x0000000186C1A740-0x0000000186C1A7F0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C1A7F0-0x0000000186C1B040
		private void LateUpdate() {} // 0x0000000186C1B040-0x0000000186C1B1C0
		public override void Despawn() {} // 0x0000000186C1B1C0-0x0000000186C1B240
		private void Shoot() {} // 0x0000000186C1B240-0x0000000186C1B390
	}
}
