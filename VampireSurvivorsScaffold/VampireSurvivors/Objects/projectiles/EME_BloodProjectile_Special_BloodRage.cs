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
	public class EME_BloodProjectile_Special_BloodRage : Projectile // TypeDefIndex: 15751
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
		protected string FrameName { get => default; } // 0x0000000186D70F50-0x0000000186D70F90 
		protected float ExpireTime { get => default; } // 0x0000000186D70F90-0x0000000186D70FA0 
	
		// Constructors
		public EME_BloodProjectile_Special_BloodRage() {} // 0x0000000186D72930-0x0000000186D72B90
	
		// Methods
		protected override void Awake() {} // 0x0000000186D70FA0-0x0000000186D71250
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D6F5F0-0x0000000186D6F690
		protected void MakeEmitter() {} // 0x0000000186D71250-0x0000000186D71D80
		private void LateUpdate() {} // 0x0000000186D71D80-0x0000000186D71DA0
		public void Activate() {} // 0x0000000186D71DA0-0x0000000186D72630
		public override void Despawn() {} // 0x0000000186D6EAC0-0x0000000186D6EB40
		private void FadeOut() {} // 0x0000000186D72630-0x0000000186D72930
	}
}
