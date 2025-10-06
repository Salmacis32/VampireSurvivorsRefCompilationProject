/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_WineGlass1_Projectile : Projectile // TypeDefIndex: 15724
	{
		// Fields
		private PhaserSprite _animatedSprite; // 0xD0
		private TP_WineGlass1_Weapon _trueWeapon; // 0xD8
		private SpriteAnimation spriteAnim; // 0xE0
		private TweenerCore<Vector2, Vector2, VectorOptions> throwTween; // 0xE8
		private List<SfxType> Glass_Light; // 0xF0
		private List<SfxType> Glass_Medium; // 0xF8
		private List<SfxType> Glass_Heavy; // 0x100
		private MultiTargetTween _angleTween; // 0x108
	
		// Constructors
		public TP_WineGlass1_Projectile() {} // 0x0000000186D538C0-0x0000000186D54340
	
		// Methods
		protected override void Awake() {} // 0x0000000186D52720-0x0000000186D52820
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D52820-0x0000000186D535E0
		private void OnBreak() {} // 0x0000000186D535E0-0x0000000186D53870
		public override void Despawn() {} // 0x0000000186D53870-0x0000000186D538C0
		public override void InternalUpdate() {} // 0x0000000180B15170-0x0000000180B15180
	}
}
