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
using VampireSurvivors.Objects.Pickups;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_PowerOfLire_Projectile : Projectile // TypeDefIndex: 15634
	{
		// Fields
		private MultiTargetTween _tween1; // 0xD0
		private PhaserSprite _animatedSprite; // 0xD8
		private List<PhaserSprite> _sparkSprites; // 0xE0
		private int sparkCounter; // 0xE8
		private int frameIndex; // 0xEC
		private float frameTime; // 0xF0
		private bool _isActivated; // 0xF4
		private MultiTargetTween _tween2; // 0xF8
		private bool _canUpdate; // 0x100
		private List<string> coinBagFrames; // 0x108
		private List<int> _tints; // 0x110
		private int tintCounter; // 0x118
		private bool isFiring; // 0x11C
	
		// Constructors
		public TP_PowerOfLire_Projectile() {} // 0x0000000186CF9650-0x0000000186CFA300
	
		// Methods
		protected override void Awake() {} // 0x0000000186CF72E0-0x0000000186CF7910
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CF7910-0x0000000186CF7BB0
		public void FirePowerOfLire() {} // 0x0000000186CF7BB0-0x0000000186CF8200
		private void FireSpark() {} // 0x0000000186CF8200-0x0000000186CF87B0
		private void Finish() {} // 0x0000000186CF87B0-0x0000000186CF8830
		public override void InternalUpdate() {} // 0x0000000186CF8830-0x0000000186CF8930
		public override void Despawn() {} // 0x0000000186C60D40-0x0000000186C60D50
		public void MakeCoin(Vector2 pos, float value) {} // 0x0000000186CF8930-0x0000000186CF8A90
		protected void TransformEnemies(bool erase = false /* Metadata: 0x01977792 */) {} // 0x0000000186CF8A90-0x0000000186CF8D40
		protected void TransformItems() {} // 0x0000000186CF8D40-0x0000000186CF9650
	}
}
