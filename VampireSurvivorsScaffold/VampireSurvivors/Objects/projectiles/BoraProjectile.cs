/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class BoraProjectile : Projectile // TypeDefIndex: 15401
	{
		// Fields
		private ParticleEmitterManager _pfxEmitterManager; // 0xD0
		private ParticleSystem _pfxEmitter1; // 0xD8
		private ParticleSystem _pfxEmitter2; // 0xE0
		private MultiTargetTween _angleTween; // 0xE8
		private MultiTargetTween _positionTween; // 0xF0
		[SerializeField]
		private PhaserSprite _GroundFx; // 0xF8
		private ParticleEmitterManager _pfxEmitterExplosionManager; // 0x100
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x108
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x110
		private VampireSurvivors.Framework.TimerSystem.Timer _despawnTimer; // 0x118
		private float _radius; // 0x120
		private float _exploRadius; // 0x124
		private bool _isBroken; // 0x128
		private float _groundFxAlpha; // 0x12C
		private Vector2 _currentDirection; // 0x130
		private Circle _explosionCircle; // 0x138
		private MultiTargetTween _fadeOutTween; // 0x140
		private MultiTargetTween _scaleGroundTween; // 0x148
		private MultiTargetTween _growTween; // 0x150
		private VampireSurvivors.Framework.TimerSystem.Timer _chooseTimer; // 0x158
	
		// Constructors
		public BoraProjectile() {} // 0x0000000186BC2B50-0x0000000186BC2BD0
	
		// Methods
		protected override void Awake() {} // 0x0000000186BBF080-0x0000000186BC0A50
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BC0A50-0x0000000186BC1750
		public void GoTowardsNearestEnemyToOwner() {} // 0x0000000186BC1750-0x0000000186BC1960
		public override void InternalUpdate() {} // 0x0000000186BC1960-0x0000000186BC1CB0
		public override void Despawn() {} // 0x0000000186BC1CB0-0x0000000186BC1D70
		private void Break() {} // 0x0000000186BC1D70-0x0000000186BC2820
		private void StartDespawn() {} // 0x0000000186BC2820-0x0000000186BC2AF0
		private void KillTweens() {} // 0x0000000186BC2AF0-0x0000000186BC2B50
	}
}
