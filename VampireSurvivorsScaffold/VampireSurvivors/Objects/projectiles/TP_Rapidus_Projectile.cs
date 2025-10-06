/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	[DefaultExecutionOrder(861)]
	public class TP_Rapidus_Projectile : Projectile // TypeDefIndex: 15636
	{
		// Fields
		protected VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xD0
		protected MultiTargetTween _tween2; // 0xD8
		protected bool isDespawning; // 0xE0
		protected float currentBarrierScale; // 0xE4
		protected const float Radius = 16f; // Metadata: 0x01977793
		public SpriteAnimation _spriteAnimation; // 0xE8
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0xF0
	
		// Constructors
		public TP_Rapidus_Projectile() {} // 0x0000000186CFC3F0-0x0000000186CFC440
	
		// Methods
		protected override void Awake() {} // 0x0000000186CFC530-0x0000000186CFC680
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CFC680-0x0000000186CFCEE0
		public virtual void OnRecycle() {} // 0x0000000186CFCEE0-0x0000000186CFD180
		public virtual void OnDespawn() {} // 0x0000000186CFD180-0x0000000186CFD430
		protected override void OnUpdate() {} // 0x0000000186CFD430-0x0000000186CFD870
		public override void Despawn() {} // 0x0000000186CFC4E0-0x0000000186CFC530
	}
}
