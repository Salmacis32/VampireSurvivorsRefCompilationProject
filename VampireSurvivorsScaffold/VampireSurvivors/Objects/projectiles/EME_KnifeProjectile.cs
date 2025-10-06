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
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_KnifeProjectile : Projectile // TypeDefIndex: 15790
	{
		// Fields
		[SerializeField]
		private SpriteTrail _Trail; // 0xD0
		private SpriteAnimation _spriteAnimation; // 0xD8
		protected Color[][] _tints; // 0xE0
		protected Color[][] _tints2; // 0xE8
		protected Color[][] _tints3; // 0xF0
		private bool _hasAlreadyBeenRecycled; // 0xF8
		private MultiTargetTween _despawnTween; // 0x100
		private MultiTargetTween _alphaTween; // 0x108
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x110
		protected EME_Knife1Weapon _trueWeapon; // 0x118
	
		// Properties
		public virtual bool DoExplosions { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		public virtual float DurationMultiplier { get => default; } // 0x0000000185C0CCB0-0x0000000185C0CCC0 
		public override float ProjectileSpeed { get => default; } // 0x0000000186D93E10-0x0000000186D93ED0 
	
		// Constructors
		public EME_KnifeProjectile() {} // 0x0000000186D95160-0x0000000186D958C0
	
		// Methods
		protected override void Awake() {} // 0x0000000186D93ED0-0x0000000186D93F80
		public virtual Color[][] GetTints() => default; // 0x000000018282D820-0x000000018282D830
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D93F80-0x0000000186D94D40
		public virtual void FireSpecialBullets() {} // 0x0000000180B15170-0x0000000180B15180
		private void StopMoving() {} // 0x0000000186D94D40-0x0000000186D94E70
		public override void Despawn() {} // 0x0000000186D94E70-0x0000000186D94F80
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186D94F80-0x0000000186D95110
		protected override void OnUpdate() {} // 0x0000000186D95110-0x0000000186D95160
	}
}
