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
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class Song2Projectile : Projectile // TypeDefIndex: 15968
	{
		// Fields
		private Blitter _blitter; // 0xD0
		private Blitter _blitterBg; // 0xD8
		private bool _blittersMade; // 0xE0
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0xE8
		private VampireSurvivors.Framework.TimerSystem.Timer _fadeOutTimer; // 0xF0
		private MultiTargetTween _fadeOutTween; // 0xF8
		private MultiTargetTween _scaleTween; // 0x100
		private bool _isBroken; // 0x108
		private const float BobAlpha = 0.5f; // Metadata: 0x019779A9
		private const float ScaleX = 32f; // Metadata: 0x019779AD
		private List<Sprite> _spriteList; // 0x110
		private static int _fps; // 0x00
		private static double _frameTime; // 0x08
		private double _frameTimeMS; // 0x118
		private double _elapsed; // 0x120
	
		// Constructors
		public Song2Projectile() {} // 0x0000000186E74B00-0x0000000186E74BA0
		static Song2Projectile() {} // 0x0000000186E74BA0-0x0000000186E74C10
	
		// Methods
		protected override void Awake() {} // 0x0000000186E72580-0x0000000186E72630
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E72630-0x0000000186E72ED0
		public override void InternalUpdate() {} // 0x0000000186E72ED0-0x0000000186E73580
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186E73580-0x0000000186E73720
		public override void Despawn() {} // 0x0000000186E73720-0x0000000186E737E0
		private void Shoot() {} // 0x0000000186E737E0-0x0000000186E73EF0
		private void UpdateBlitter(Blitter blitter, float factor = 0.01f /* Metadata: 0x019779A5 */) {} // 0x0000000186E73EF0-0x0000000186E74210
		private void BlitterBounce(Blitter blitter, float left, float right, float top, float bottom) {} // 0x0000000186E74210-0x0000000186E744D0
		private void MakeBlitters() {} // 0x0000000186E744D0-0x0000000186E74880
		private void AddBobs(Blitter blitter, int amount) {} // 0x0000000186E74880-0x0000000186E74B00
	}
}
