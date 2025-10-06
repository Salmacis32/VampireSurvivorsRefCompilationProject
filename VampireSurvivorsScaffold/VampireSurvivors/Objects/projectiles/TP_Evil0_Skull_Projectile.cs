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
	public class TP_Evil0_Skull_Projectile : Projectile // TypeDefIndex: 15566
	{
		// Fields
		private float _radius; // 0xD0
		private Tween _radiusTween; // 0xD8
		private PhaserSprite _animatedSprite; // 0xE0
		private PhaserSprite _jawSprite; // 0xE8
		private PhaserSprite _animatedSprite2; // 0xF0
		private PhaserSprite _jawSprite2; // 0xF8
		private MultiTargetTween _scaleTween; // 0x100
		private MultiTargetTween _alphaTween; // 0x108
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x110
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x118
		private bool _isDespawning; // 0x120
		private TP_Evil1_Weapon _trueWeapon; // 0x128
		private float _direction; // 0x130
		private Vector3 _cursorOffset; // 0x134
	
		// Properties
		private float ScaledAlpha { get => default; } // 0x0000000186CA6E00-0x0000000186CA6E70 
	
		// Constructors
		public TP_Evil0_Skull_Projectile() {} // 0x0000000186CA91C0-0x0000000186CA9220
	
		// Methods
		protected override void Awake() {} // 0x0000000186CA6E70-0x0000000186CA7750
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CA7750-0x0000000186CA8660
		private void FireRunes() {} // 0x0000000186CA8660-0x0000000186CA88F0
		private void StartDespawn() {} // 0x0000000186CA88F0-0x0000000186CA8F10
		private void SyncSprites() {} // 0x0000000186CA8F10-0x0000000186CA8FB0
		public override void Despawn() {} // 0x0000000186CA8FB0-0x0000000186CA9030
		private void DisplayCursorVFX(int _times, float _duration) {} // 0x0000000186CA9030-0x0000000186CA91C0
	}
}
