/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics.Blitters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class SongProjectile : Projectile // TypeDefIndex: 15969
	{
		// Fields
		private Blitter _blitter; // 0xD0
		private Blitter _blitterBg; // 0xD8
		private bool _blittersMade; // 0xE0
		private MultiTargetTween _fadeOutTween; // 0xE8
		private VampireSurvivors.Framework.TimerSystem.Timer _fadeOutTimer; // 0xF0
		private MultiTargetTween _scaleTween; // 0xF8
		private bool _isBroken; // 0x100
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x108
		private const float BobAlpha = 0.5f; // Metadata: 0x019779B5
		private const float ScaleX = 32f; // Metadata: 0x019779B9
		private List<Sprite> _spriteList; // 0x110
		private static int _fps; // 0x00
		private static double _frameTime; // 0x08
		private double _frameTimeMS; // 0x118
		private double _elapsed; // 0x120
	
		// Constructors
		public SongProjectile() {} // 0x0000000186E77000-0x0000000186E770A0
		static SongProjectile() {} // 0x0000000186E770A0-0x0000000186E77110
	
		// Methods
		protected override void Awake() {} // 0x0000000186E74C60-0x0000000186E74D10
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E74D10-0x0000000186E757B0
		public override void InternalUpdate() {} // 0x0000000186E757B0-0x0000000186E75E60
		public override void Despawn() {} // 0x0000000186E75E60-0x0000000186E75F20
		private void Shoot() {} // 0x0000000186E75F20-0x0000000186E762C0
		private void UpdateBlitter(Blitter blitter, float factor = 0.01f /* Metadata: 0x019779B1 */) {} // 0x0000000186E762C0-0x0000000186E76710
		private void BlitterBounce(Blitter blitter, float left, float right, float top, float bottom) {} // 0x0000000186E76710-0x0000000186E769D0
		private void MakeBlitters() {} // 0x0000000186E769D0-0x0000000186E76D80
		private void AddBobs(Blitter blitter, int amount) {} // 0x0000000186E76D80-0x0000000186E77000
	}
}
