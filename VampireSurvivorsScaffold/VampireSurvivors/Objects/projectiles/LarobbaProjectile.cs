/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class LarobbaProjectile : Projectile // TypeDefIndex: 15911
	{
		// Fields
		private MultiTargetTween _angleTween; // 0xD0
		private MultiTargetTween _movementTween; // 0xD8
		private MultiTargetTween _scaleTween; // 0xE0
		private float _startingAngle; // 0xE8
		private LarobbaWeapon _trueWeapon; // 0xF0
		private VampireSurvivors.Framework.TimerSystem.Timer _bounceTimer; // 0xF8
		private float _defaultVelocityY; // 0x100
		public float _moveAngle; // 0x104
		private float _grav; // 0x108
		private float2 _initialVelocity; // 0x10C
	
		// Constructors
		public LarobbaProjectile() {} // 0x0000000186E3C460-0x0000000186E3C4C0
	
		// Methods
		protected override void Awake() {} // 0x0000000186E3AD80-0x0000000186E3B1F0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E3B1F0-0x0000000186E3BF10
		public override void Despawn() {} // 0x0000000186CB94E0-0x0000000186CB9520
		protected override void OnHasHitAnObject(IDamageable target) {} // 0x0000000186E3BF10-0x0000000186E3C1E0
		public override void InternalUpdate() {} // 0x0000000186E3C1E0-0x0000000186E3C460
	}
}
