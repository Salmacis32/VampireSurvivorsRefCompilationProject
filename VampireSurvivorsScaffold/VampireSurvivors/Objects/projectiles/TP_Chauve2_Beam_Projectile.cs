/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Chauve2_Beam_Projectile : Projectile // TypeDefIndex: 15511
	{
		// Fields
		private SpriteRenderer _muzzleFlash; // 0xD0
		private SpriteRenderer _muzzleFlash2; // 0xD8
		private SpriteRenderer _line9Slice; // 0xE0
		private VampireSurvivors.Framework.TimerSystem.Timer _destructionTimer; // 0xE8
		private float _firingCountdown; // 0xF0
		private float2 _startPosition; // 0xF4
		private float _collisionTween; // 0xFC
		private float2 _lastOwnerPosition; // 0x100
		private float _MaxAlpha; // 0x108
		private float _AlphaDiff; // 0x10C
		private float2 _playerTipOffset; // 0x110
		private TP_Chauve2_Weapon _trueWeapon; // 0x118
		private float _area; // 0x120
		private const float Radius = 12f; // Metadata: 0x019776A3
	
		// Properties
		public override float ProjectileSpeed { get => default; } // 0x0000000186C70CB0-0x0000000186C70D20 
	
		// Constructors
		public TP_Chauve2_Beam_Projectile() {} // 0x0000000186C728D0-0x0000000186C72940
	
		// Methods
		protected override void Awake() {} // 0x0000000186C70D20-0x0000000186C70DC0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C70DC0-0x0000000186C70EE0
		public void ManualInitProjectile(float2 playerTipOffset, float2 angleVector) {} // 0x0000000186C70EE0-0x0000000186C71DF0
		public override void InternalUpdate() {} // 0x0000000186C71DF0-0x0000000186C72490
		public override void Despawn() {} // 0x0000000186C72490-0x0000000186C727B0
		private void ActuallyRemove() {} // 0x0000000186C727B0-0x0000000186C728D0
	}
}
