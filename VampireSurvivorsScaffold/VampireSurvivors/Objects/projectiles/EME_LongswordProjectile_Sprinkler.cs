/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_LongswordProjectile_Sprinkler : Projectile // TypeDefIndex: 15800
	{
		// Fields
		[SerializeField]
		private ParticleSystem _particlesVFX; // 0xD0
		protected float Radius; // 0xD8
		private PhaserSprite _animatedSprite; // 0xE0
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0xE8
		private MultiTargetTween _fadeOutTween; // 0xF0
		private Projectile _parentProjectile; // 0xF8
		private int[] _tints; // 0x100
		private VampireSurvivors.Framework.Particles.BlendMode[] _blends; // 0x108
	
		// Constructors
		public EME_LongswordProjectile_Sprinkler() {} // 0x0000000186DC0DD0-0x0000000186DC0F70
	
		// Methods
		protected override void Awake() {} // 0x0000000186DBFA80-0x0000000186DBFF60
		public void setParentProjectile(Projectile parent) {} // 0x0000000180B3E800-0x0000000180B3E860
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DBFF60-0x0000000186DC0610
		public override void InternalUpdate() {} // 0x0000000186DC0610-0x0000000186DC0620
		private void UpdatePositionAndScale() {} // 0x0000000186DC0620-0x0000000186DC0D20
		public override void Despawn() {} // 0x0000000186DC0D20-0x0000000186DC0DD0
	}
}
