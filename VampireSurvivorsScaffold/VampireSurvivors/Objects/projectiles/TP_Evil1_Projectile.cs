/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
	public class TP_Evil1_Projectile : Projectile // TypeDefIndex: 15567
	{
		// Fields
		private float _radius; // 0xD0
		private PhaserSprite _displaySprite; // 0xD8
		private PhaserSprite _displaySprite2; // 0xE0
		private Tween _radiusTween; // 0xE8
		private List<string> frames; // 0xF0
		private MultiTargetTween _alphaTween; // 0xF8
		private MultiTargetTween _alphaTween2; // 0x100
		private Vector2 _sineOffset; // 0x108
		private float _sineTime; // 0x110
		private float _sineRadius; // 0x114
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x118
	
		// Constructors
		public TP_Evil1_Projectile() {} // 0x0000000186CAA270-0x0000000186CAA6D0
	
		// Methods
		protected override void Awake() {} // 0x0000000186CA9390-0x0000000186CA9700
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CA9700-0x0000000186CAA080
		private void LateUpdate() {} // 0x0000000186CAA080-0x0000000186CAA180
		public void SetDirection(float dir) {} // 0x0000000186CAA180-0x0000000186CAA200
		private void StartDespawn() {} // 0x0000000186BB8730-0x0000000186BB8750
		public override void Despawn() {} // 0x0000000186CAA200-0x0000000186CAA270
	}
}
