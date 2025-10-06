/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class SilverWindProjectile : Projectile // TypeDefIndex: 15958
	{
		// Fields
		[SerializeField]
		private TrailRenderer _trail; // 0xD0
		[SerializeField]
		private SpriteAnimation _anims; // 0xD8
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xE0
		[NonSerialized]
		private uint[] _colors; // 0xE8
		[NonSerialized]
		private uint[] _tints; // 0xF0
		[NonSerialized]
		private List<string> _particles; // 0xF8
		private float _fnTime; // 0x100
		private bool _isInStartingPosition; // 0x104
		private ParticleEmitterManager _pfxManager; // 0x108
		private bool _canUpdateTrail; // 0x110
		private MultiTargetTween _fadeInTween; // 0x118
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x120
		private ParticleSystem _pfxEmitter; // 0x128
	
		// Properties
		protected virtual uint[] Colors { get => default; } // 0x0000000182766DD0-0x0000000182766DE0 
		protected virtual uint[] Tints { get => default; } // 0x00000001819716C0-0x00000001819716D0 
		protected virtual List<string> Particles { get => default; } // 0x0000000181945E90-0x0000000181945EA0 
	
		// Constructors
		public SilverWindProjectile() {} // 0x0000000186E6D6B0-0x0000000186E6D9E0
	
		// Methods
		protected override void Awake() {} // 0x0000000186E6B6A0-0x0000000186E6BDE0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E6BDE0-0x0000000186E6CAD0
		public override void SetTarget(Transform target) {} // 0x0000000186E6CAD0-0x0000000186E6CD20
		private void FadeOut() {} // 0x0000000186E6CD20-0x0000000186E6D010
		public override void Despawn() {} // 0x0000000186E6D010-0x0000000186E6D040
		public override void InternalUpdate() {} // 0x0000000186E6D040-0x0000000186E6D6B0
	}
}
