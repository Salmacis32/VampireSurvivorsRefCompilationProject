/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_RPG2_Projectile : Projectile // TypeDefIndex: 15642
	{
		// Fields
		private MultiTargetTween _speedTween; // 0xD0
		private TP_RPG1_Weapon _rpgWeapon; // 0xD8
		[NonSerialized]
		public float SpeedMulti; // 0xE0
		private VampireSurvivors.Framework.TimerSystem.Timer _durationTimer; // 0xE8
		private Vector2 startingVelocity; // 0xF0
	
		// Constructors
		public TP_RPG2_Projectile() {} // 0x0000000186D030C0-0x0000000186D03110
	
		// Methods
		protected override void Awake() {} // 0x0000000186D025C0-0x0000000186D02660
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D02660-0x0000000186D02C90
		public override void InternalUpdate() {} // 0x0000000186D02C90-0x0000000186D02CE0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186D02CE0-0x0000000186D02ED0
		protected void Explode() {} // 0x0000000186D02ED0-0x0000000186D03080
		public override void Despawn() {} // 0x0000000186D03080-0x0000000186D030C0
	}
}
