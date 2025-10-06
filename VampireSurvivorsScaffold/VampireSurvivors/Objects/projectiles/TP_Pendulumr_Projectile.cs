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
	public class TP_Pendulumr_Projectile : Projectile // TypeDefIndex: 15625
	{
		// Fields
		private float _radius; // 0xD0
		private PhaserSprite _pendulumSprite; // 0xD8
		private PhaserSprite _shaftSprite; // 0xE0
		private PhaserSprite _stretchSprite; // 0xE8
		private Tween _radiusTween; // 0xF0
		private MultiTargetTween _scaleTween; // 0xF8
		private bool _isDespawning; // 0x100
		private MultiTargetTween _angleTween; // 0x108
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x110
		private VampireSurvivors.Framework.TimerSystem.Timer _hitBoxTimer; // 0x118
		private Vector3 penOrigin; // 0x120
		private float _elapsedTime; // 0x12C
		private float _currentLength; // 0x130
		private int _swingDirection; // 0x134
		private float _previousAngle; // 0x138
	
		// Constructors
		public TP_Pendulumr_Projectile() {} // 0x0000000186CF0B20-0x0000000186CF0B80
	
		// Methods
		protected override void Awake() {} // 0x0000000186CEE9F0-0x0000000186CEEFB0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CEEFB0-0x0000000186CF0070
		private void StartDespawn() {} // 0x0000000186CF0070-0x0000000186CF0310
		public override void Despawn() {} // 0x0000000186CF0310-0x0000000186CF0390
		private void LateUpdate() {} // 0x0000000186CF0390-0x0000000186CF07F0
		public Vector2 GetPositionAtTime(float time) => default; // 0x0000000186CF07F0-0x0000000186CF09B0
		private void CheckForDirectionChange(float angle) {} // 0x0000000186CF09B0-0x0000000186CF0A30
		private void PlaySfx() {} // 0x0000000186CF0A30-0x0000000186CF0B20
	}
}
