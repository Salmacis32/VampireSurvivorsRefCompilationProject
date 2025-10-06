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
	public class MillionaireProjectile : Projectile // TypeDefIndex: 15423
	{
		// Fields
		private ParticleEmitterManager _pfxEmitterManager; // 0xD0
		private ParticleSystem _pfxEmitter1; // 0xD8
		private ParticleSystem _pfxEmitter2; // 0xE0
		private MultiTargetTween _angleTween; // 0xE8
		private MultiTargetTween _positionTween; // 0xF0
		private PhaserSprite _groundFx; // 0xF8
		private ParticleEmitterManager _pfxEmitterExplosionManager; // 0x100
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x108
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x110
		private float _radius; // 0x118
		private float _exploRadius; // 0x11C
		private bool _isBroken; // 0x120
		private Vector2 _currentDirection; // 0x124
		private Circle _explosionCircle; // 0x130
		private Vector2 _target; // 0x138
	
		// Constructors
		public MillionaireProjectile() {} // 0x0000000186BE8B30-0x0000000186BE8BE0
	
		// Methods
		protected override void Awake() {} // 0x0000000186BE5CF0-0x0000000186BE77F0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BE77F0-0x0000000186BE8170
		public void SetDisplayDirection(bool left) {} // 0x0000000186BE8170-0x0000000186BE84F0
		private void Break() {} // 0x0000000186BE84F0-0x0000000186BE8A50
		public override void InternalUpdate() {} // 0x0000000186BE8A50-0x0000000186BE8AC0
		public override void Despawn() {} // 0x0000000186BE8AC0-0x0000000186BE8B30
	}
}
