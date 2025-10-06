/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Heads_Projectile : Projectile // TypeDefIndex: 15584
	{
		// Fields
		private float _radius; // 0xD0
		private PhaserSprite _animatedSprite; // 0xD8
		private Tween _radiusTween; // 0xE0
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xE8
		private VampireSurvivors.Framework.TimerSystem.Timer _hitBoxTimer; // 0xF0
		private MultiTargetTween _scaleTween; // 0xF8
		private bool _isDespawning; // 0x100
		private float hDirection; // 0x104
		private bool canTurnAround; // 0x108
		private VampireSurvivors.Framework.TimerSystem.Timer turnAroundTimer; // 0x110
		private Transform _cachedCameraTransform; // 0x118
		private float angleTime; // 0x120
		private Vector3 _center; // 0x124
	
		// Constructors
		public TP_Heads_Projectile() {} // 0x0000000186CC2720-0x0000000186CC2780
	
		// Methods
		protected override void Awake() {} // 0x0000000186CC1240-0x0000000186CC1600
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CC1600-0x0000000186CC1D50
		private void StartDespawn() {} // 0x0000000186CC1D50-0x0000000186CC1FF0
		public override void Despawn() {} // 0x0000000186CC1FF0-0x0000000186CC2090
		private void TurnAround() {} // 0x0000000186CC2090-0x0000000186CC21B0
		private void LateUpdate() {} // 0x0000000186CC21B0-0x0000000186CC2720
	}
}
