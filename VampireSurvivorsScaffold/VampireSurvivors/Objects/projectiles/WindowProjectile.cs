/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class WindowProjectile : Projectile // TypeDefIndex: 15991
	{
		// Fields
		private ParticleEmitterManager _particlesManager; // 0xD0
		private ParticleSystem _pfxEmitter; // 0xD8
		private ParticleSystem _pfxEmitter2; // 0xE0
		private GravityWell _well; // 0xE8
		private uint[] _onEmitCustomTint; // 0xF0
		private SpriteRenderer _windowVfx; // 0xF8
		private SpriteAnimation _windowVfxAnimation; // 0x100
		private SpriteRenderer _exploSprite; // 0x108
		private Tween _scaleTween; // 0x110
		private MultiTargetTween _scaleTween2; // 0x118
		private MultiTargetTween _exploTween; // 0x120
		private Transform _cachedRendererTransform; // 0x128
	
		// Constructors
		public WindowProjectile() {} // 0x0000000186E9BFC0-0x0000000186E9C0B0
	
		// Methods
		protected override void Awake() {} // 0x0000000186E99370-0x0000000186E9B060
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E9B060-0x0000000186E9BFC0
	}
}
