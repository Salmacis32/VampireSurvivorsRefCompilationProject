/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EX_Ammo2Projectile_Gunastrophe : Projectile // TypeDefIndex: 15860
	{
		// Fields
		private VampireSurvivors.Framework.TimerSystem.Timer _fadeOutTimer; // 0xD0
		private VampireSurvivors.Framework.TimerSystem.Timer _despawnTimer; // 0xD8
		private Bounds _cameraBounds; // 0xE0
		private Tween _damageOnlyTimer; // 0xF8
		private MultiTargetTween _scaleTween; // 0x100
		private const int _fps = 60; // Metadata: 0x019778FC
		private const double _frameTime = 0.016666666666666666; // Metadata: 0x019778FD
		private const double _frameTimeMS = 16.666666666666668; // Metadata: 0x01977905
		private double _elapsed; // 0x108
		private bool _aftershockDamageMovement; // 0x110
		private Ex_Ammo2Weapon _ammo2Weapon; // 0x118
	
		// Constructors
		public EX_Ammo2Projectile_Gunastrophe() {} // 0x0000000186DF6860-0x0000000186DF68B0
	
		// Methods
		protected override void Awake() {} // 0x0000000186DF5520-0x0000000186DF5630
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DF5630-0x0000000186DF5F90
		private void HandleAftershockDamage() {} // 0x0000000186DF5F90-0x0000000186DF6000
		public override void InternalUpdate() {} // 0x0000000186DF6000-0x0000000186DF66C0
		public override void Despawn() {} // 0x0000000186DF66C0-0x0000000186DF6700
		private void Shoot() {} // 0x0000000186DF6700-0x0000000186DF6860
	}
}
