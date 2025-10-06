/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_DarkRift2_SkullProjectile : Projectile // TypeDefIndex: 15532
	{
		// Fields
		[SerializeField]
		private TrailRenderer _Trail; // 0xD0
		private const float Radius = 32f; // Metadata: 0x019776BC
		private const float Percentage = 0.125f; // Metadata: 0x019776C0
		private const float SpeedModifier = 35f; // Metadata: 0x019776C4
		private float _deltaTime; // 0xD8
		private float _outwardSpeed; // 0xDC
		private TP_DarkRift2_Weapon _trueWeapon; // 0xE0
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xE8
		private VampireSurvivors.Framework.TimerSystem.Timer _trailTimer; // 0xF0
	
		// Constructors
		public TP_DarkRift2_SkullProjectile() {} // 0x0000000186C81690-0x0000000186C816E0
	
		// Methods
		protected override void Awake() {} // 0x0000000186C80800-0x0000000186C80CC0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C80CC0-0x0000000186C81040
		public void InitTrail() {} // 0x0000000186C81040-0x0000000186C81120
		public void InitMovement() {} // 0x0000000186C81120-0x0000000186C81160
		public override void InternalUpdate() {} // 0x0000000186C81160-0x0000000186C81220
		private void UpdateMovement() {} // 0x0000000186C81220-0x0000000186C814E0
		private void UpdateTrail() {} // 0x0000000186C814E0-0x0000000186C81590
		public override void Despawn() {} // 0x0000000186C81590-0x0000000186C81690
	}
}
