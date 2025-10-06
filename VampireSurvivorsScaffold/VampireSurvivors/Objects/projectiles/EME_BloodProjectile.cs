/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_BloodProjectile : Projectile // TypeDefIndex: 15746
	{
		// Fields
		[SerializeField]
		private List<Color> _tints; // 0xD0
		private List<VampireSurvivors.Framework.Particles.BlendMode> _blendModes; // 0xD8
		private MultiTargetTween _alphaTween; // 0xE0
		private MultiTargetTween _scaleTween; // 0xE8
		private ParticleSystem _damageVfx; // 0xF0
		private ParticleEmitterManager _particlesManager; // 0xF8
		private GravityWell _well; // 0x100
		private VampireSurvivors.Framework.TimerSystem.Timer bloodTimer; // 0x108
		private VampireSurvivors.Framework.TimerSystem.Timer expireTimer; // 0x110
		private PhaserSprite _displaySprite; // 0x118
		private EnemyController _myTarget; // 0x120
		private bool _targetFound; // 0x128
		private Vector2 targetPosition; // 0x12C
	
		// Constructors
		public EME_BloodProjectile() {} // 0x0000000186D6EE40-0x0000000186D6F0A0
	
		// Methods
		protected override void Awake() {} // 0x0000000186D6D030-0x0000000186D6DD80
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D6DD80-0x0000000186D6DE40
		private void LateUpdate() {} // 0x0000000186D6DE40-0x0000000186D6E290
		public void Activate() {} // 0x0000000186D6E290-0x0000000186D6EA00
		public virtual void OnTargetHit() {} // 0x0000000186D6EA00-0x0000000186D6EAC0
		public override void Despawn() {} // 0x0000000186D6EAC0-0x0000000186D6EB40
		private void FadeOut() {} // 0x0000000186D6EB40-0x0000000186D6EE40
	}
}
