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
	public class EME_BloodProjectile_Special : Projectile // TypeDefIndex: 15750
	{
		// Fields
		[SerializeField]
		private List<Color> _tints; // 0xD0
		protected List<VampireSurvivors.Framework.Particles.BlendMode> _blendModes; // 0xD8
		protected MultiTargetTween _alphaTween; // 0xE0
		protected MultiTargetTween _scaleTween; // 0xE8
		protected ParticleSystem _damageVfx; // 0xF0
		protected ParticleEmitterManager _particlesManager; // 0xF8
		protected GravityWell _well; // 0x100
		protected VampireSurvivors.Framework.TimerSystem.Timer bloodTimer; // 0x108
		protected VampireSurvivors.Framework.TimerSystem.Timer expireTimer; // 0x110
		protected PhaserSprite _displaySprite; // 0x118
		protected EnemyController _myTarget; // 0x120
		protected bool _targetFound; // 0x128
		protected bool isFirstUpdate; // 0x129
	
		// Properties
		protected virtual string FrameName { get => default; } // 0x0000000186D6F2F0-0x0000000186D6F330 
		protected virtual float ExpireTime { get => default; } // 0x0000000186D6F330-0x0000000186D6F340 
	
		// Constructors
		public EME_BloodProjectile_Special() {} // 0x0000000186D70CF0-0x0000000186D70F50
	
		// Methods
		protected override void Awake() {} // 0x0000000186D6F340-0x0000000186D6F5F0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D6F5F0-0x0000000186D6F690
		protected virtual void MakeEmitter() {} // 0x0000000186D6F690-0x0000000186D70190
		private void LateUpdate() {} // 0x0000000186D70190-0x0000000186D701B0
		public void Activate() {} // 0x0000000186D701B0-0x0000000186D709F0
		public override void Despawn() {} // 0x0000000186D6EAC0-0x0000000186D6EB40
		private void FadeOut() {} // 0x0000000186D709F0-0x0000000186D70CF0
	}
}
