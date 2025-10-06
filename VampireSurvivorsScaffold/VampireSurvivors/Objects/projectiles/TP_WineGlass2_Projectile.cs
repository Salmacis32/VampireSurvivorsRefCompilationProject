/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_WineGlass2_Projectile : Projectile // TypeDefIndex: 15728
	{
		// Fields
		private PhaserSprite _animatedSprite; // 0xD0
		private TP_WineGlass2_Weapon _trueWeapon; // 0xD8
		private SpriteAnimation spriteAnim; // 0xE0
		private TweenerCore<Vector2, Vector2, VectorOptions> throwTween; // 0xE8
		private MultiTargetTween _angleTween; // 0xF0
	
		// Constructors
		public TP_WineGlass2_Projectile() {} // 0x0000000186D56AE0-0x0000000186D56B30
	
		// Methods
		protected override void Awake() {} // 0x0000000186D559F0-0x0000000186D55AF0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D55AF0-0x0000000186D56870
		private void OnBreak() {} // 0x0000000186D56870-0x0000000186D56A90
		public override void Despawn() {} // 0x0000000186D56A90-0x0000000186D56AE0
		public override void InternalUpdate() {} // 0x0000000180B15170-0x0000000180B15180
	}
}
