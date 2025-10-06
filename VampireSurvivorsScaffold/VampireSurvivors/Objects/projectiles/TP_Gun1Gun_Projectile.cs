/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Gun1Gun_Projectile : Projectile // TypeDefIndex: 15579
	{
		// Fields
		private float _flipNum; // 0xD0
		private float _rotationInc; // 0xD4
		private float _rotationMultiplier; // 0xD8
		private MultiTargetTween _scaleTween; // 0xE0
		protected VampireSurvivors.Framework.TimerSystem.Timer _despawnTimer; // 0xE8
		protected float _floorY; // 0xF0
	
		// Constructors
		public TP_Gun1Gun_Projectile() {} // 0x0000000186CBDDC0-0x0000000186CBDE20
	
		// Methods
		protected override void Awake() {} // 0x0000000186CBD3A0-0x0000000186CBD440
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CBD440-0x0000000186CBD8D0
		private void LateUpdate() {} // 0x0000000180B15170-0x0000000180B15180
		public override void InternalUpdate() {} // 0x0000000186CBD8D0-0x0000000186CBDB30
		private void StartDespawn() {} // 0x0000000186CBDB30-0x0000000186CBDDC0
		public override void Despawn() {} // 0x0000000186C7AF00-0x0000000186C7AF40
	}
}
