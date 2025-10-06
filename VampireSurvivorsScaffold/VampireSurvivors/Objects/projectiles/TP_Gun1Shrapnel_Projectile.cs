/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Gun1Shrapnel_Projectile : Projectile // TypeDefIndex: 15580
	{
		// Fields
		[SerializeField]
		protected TrailRenderer _trail; // 0xD0
		protected VampireSurvivors.Framework.TimerSystem.Timer _despawnTimer; // 0xD8
		[NonSerialized]
		public float2 Offset; // 0xE0
	
		// Constructors
		public TP_Gun1Shrapnel_Projectile() {} // 0x0000000186CBE7A0-0x0000000186CBE7F0
	
		// Methods
		protected override void Awake() {} // 0x0000000186CBDE20-0x0000000186CBE050
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CBE050-0x0000000186CBE580
		public void EnableTrail(bool enable) {} // 0x0000000186CBE580-0x0000000186CBE600
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186CBE600-0x0000000186CBE690
		public override void Despawn() {} // 0x0000000186CBE690-0x0000000186CBE7A0
	}
}
