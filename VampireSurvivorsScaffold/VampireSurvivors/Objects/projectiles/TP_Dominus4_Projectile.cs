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
	public class TP_Dominus4_Projectile : Projectile // TypeDefIndex: 15550
	{
		// Fields
		private float _displaySpritePxSize; // 0xD0
		private float _innerRadius; // 0xD4
		private MultiTargetTween _tween1; // 0xD8
		private MultiTargetTween _tween2; // 0xE0
		private MultiTargetTween _tween3; // 0xE8
		private PhaserSprite _displaySprite; // 0xF0
		private int frameIndex; // 0xF8
		private float frameTime; // 0xFC
		private bool _isActivated; // 0x100
		private bool _canUpdate; // 0x101
		private PhaserSprite _draculaAnimSprite; // 0x108
		private List<PhaserSprite> explosionSprites; // 0x110
		private PhaserSprite _redCircleSprite; // 0x118
		private MultiTargetTween _circleTween; // 0x120
		private List<PhaserSprite> raySprites; // 0x128
		private float _maxRadius; // 0x130
		private MultiTargetTween _circleTween2; // 0x138
		private MultiTargetTween _tween4; // 0x140
		private TP_Dominus4_Weapon _trueWeapon; // 0x148
		private bool _canFire; // 0x150
	
		// Constructors
		public TP_Dominus4_Projectile() {} // 0x0000000186C97300-0x0000000186C97370
	
		// Methods
		protected override void Awake() {} // 0x0000000186C93660-0x0000000186C94710
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C94710-0x0000000186C94A80
		public override void InternalUpdate() {} // 0x0000000186C94A80-0x0000000186C94CD0
		private void ShowDracula() {} // 0x0000000186C94CD0-0x0000000186C95250
		private void FadeOutDracula() {} // 0x0000000186C95250-0x0000000186C95470
		private void DisplayBlackScreen() {} // 0x0000000186C95470-0x0000000186C95960
		private void DisplayRedCircle() {} // 0x0000000186C95960-0x0000000186C95E20
		private void DisplayRays() {} // 0x0000000186C95E20-0x0000000186C961C0
		private void DisplayExplosions() {} // 0x0000000186C961C0-0x0000000186C96F40
		private void HideBlackScreen() {} // 0x0000000186C96F40-0x0000000186C97270
		public override void Despawn() {} // 0x0000000186C97270-0x0000000186C97300
	}
}
