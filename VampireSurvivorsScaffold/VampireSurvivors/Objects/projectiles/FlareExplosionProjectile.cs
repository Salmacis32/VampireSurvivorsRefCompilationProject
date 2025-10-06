/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class FlareExplosionProjectile : Projectile // TypeDefIndex: 15874
	{
		// Fields
		private MultiTargetTween _fadeoutTween; // 0xD0
		private MultiTargetTween _scaleTween; // 0xD8
		private PhaserSprite _starSprite; // 0xE0
		private PhaserSprite _sideSprite; // 0xE8
		private PhaserSprite _flatSprite; // 0xF0
		private bool _isLight; // 0xF8
		private string[] _sideNames; // 0x100
		private string[] _starNames; // 0x108
		private string[] _flatNames; // 0x110
		private MultiTargetTween _flatTween; // 0x118
		private MultiTargetTween _sideTween; // 0x120
		private MultiTargetTween _starTween; // 0x128
		private PhaserSprite _exploSprite; // 0x130
		private MultiTargetTween _exploTween; // 0x138
		private WeaponType[] _darkWeapons; // 0x140
		private ParticleEmitterManager _particlesManager; // 0x148
		private ParticleSystem _PfxEmitter; // 0x150
		private bool _particlesGenerated; // 0x158
		public float _BodyScale; // 0x15C
	
		// Constructors
		public FlareExplosionProjectile() {} // 0x0000000186E0BC90-0x0000000186E0C170
	
		// Methods
		protected override void Awake() {} // 0x0000000186E08E30-0x0000000186E097D0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E097D0-0x0000000186E0A8E0
		private void Explode() {} // 0x0000000186E0A8E0-0x0000000186E0B8A0
		private void FadeOut() {} // 0x0000000186E0B8A0-0x0000000186E0BC60
		public override void Despawn() {} // 0x0000000186E0BC60-0x0000000186E0BC90
	}
}
