/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class FB_SonicBloomProjectile : Projectile // TypeDefIndex: 15488
	{
		// Fields
		private MultiTargetTween _scaleTween; // 0xD0
		private MultiTargetTween _fadeTween; // 0xD8
		private SpriteAnimation _anim; // 0xE0
		private bool _isFadingOut; // 0xE8
	
		// Constructors
		public FB_SonicBloomProjectile() {} // 0x0000000186C314E0-0x0000000186C31530
	
		// Methods
		protected override void Awake() {} // 0x0000000186C306E0-0x0000000186C308E0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C308E0-0x0000000186C31040
		private void FadeOut() {} // 0x0000000186C31040-0x0000000186C312E0
		public override void Despawn() {} // 0x0000000186C312E0-0x0000000186C31410
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186C31410-0x0000000186C314E0
	}
}
