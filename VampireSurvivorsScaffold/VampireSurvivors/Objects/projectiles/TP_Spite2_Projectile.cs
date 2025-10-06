/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Spite2_Projectile : Projectile // TypeDefIndex: 15680
	{
		// Fields
		private float _bodyRadius; // 0xD0
		private MultiTargetTween _scaleTween; // 0xD8
		private MultiTargetTween _fadeInTrailTween; // 0xE0
		private List<TP_Spite1_Projectile> _damageBoxes; // 0xE8
		private PhaserSprite _animatedSprite; // 0xF0
		private PhaserSprite _animatedSprite2; // 0xF8
		private PhaserSprite _displaySprite; // 0x100
		private float despawnCountdown; // 0x108
		private bool isDespawning; // 0x10C
		private List<float> angles; // 0x110
		private MultiTargetTween _scale1Tween; // 0x118
		private MultiTargetTween _scale2Tween; // 0x120
		private MultiTargetTween _scale3Tween; // 0x128
		private float despawnTimer; // 0x130
		private Vector2 direction; // 0x134
	
		// Constructors
		public TP_Spite2_Projectile() {} // 0x0000000186D29A20-0x0000000186D29D50
	
		// Methods
		protected override void Awake() {} // 0x0000000186D279D0-0x0000000186D28100
		public void SetDamageBoxes(List<TP_Spite1_Projectile> boxes) {} // 0x0000000186D28100-0x0000000186D282F0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D282F0-0x0000000186D28780
		private void StartPulse() {} // 0x0000000186D28780-0x0000000186D28C20
		private void Pulse() {} // 0x0000000186D28C20-0x0000000186D293F0
		private void StartDespawn() {} // 0x0000000186D293F0-0x0000000186D296A0
		protected override void OnUpdate() {} // 0x0000000186D296A0-0x0000000186D29720
		public override void Despawn() {} // 0x0000000186D29720-0x0000000186D29A20
	}
}
