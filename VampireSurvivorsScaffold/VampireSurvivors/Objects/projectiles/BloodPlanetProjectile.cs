/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.NumberTypes;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class BloodPlanetProjectile : Projectile // TypeDefIndex: 15390
	{
		// Fields
		[SerializeField]
		private SpriteAnimation _SpriteAnimation; // 0xD0
		public EggFloat _Radius; // 0xD8
		private readonly List<float> _angles; // 0xE0
		private readonly List<string> _animNames; // 0xE8
		private float2 _ground; // 0xF0
		private float _myRotationAngle; // 0xF8
		private float _angleUnit; // 0xFC
		private float _angleRotUnit; // 0x100
		public float _RadiusMulY; // 0x104
		private float _radiusMulX; // 0x108
		private float _amount; // 0x10C
		private BloodAstronomiaWeapon _trueWeapon; // 0x110
		private MultiTargetTween _scaleTween; // 0x118
		private MultiTargetTween _alphaTween; // 0x120
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x128
		private readonly List<float> _durations; // 0x130
		private readonly List<float> _bodyRadii; // 0x138
		private VampireSurvivors.Framework.TimerSystem.Timer _activationTimer; // 0x140
	
		// Constructors
		public BloodPlanetProjectile() {} // 0x0000000186BB4090-0x0000000186BB4970
	
		// Methods
		protected override void Awake() {} // 0x0000000186BB27D0-0x0000000186BB2AA0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BB2AA0-0x0000000186BB2BA0
		public void OverrideWeaponData(Weapon weapon) {} // 0x0000000186BB2BA0-0x0000000186BB3860
		public override void InternalUpdate() {} // 0x0000000186BB3860-0x0000000186BB3B90
		public override void Despawn() {} // 0x0000000186BB3B90-0x0000000186BB3C10
		public override bool CanExplode() => default; // 0x0000000181958370-0x0000000181958380
		public override void Explode(Vector2? pos = default) {} // 0x0000000186BB3C10-0x0000000186BB3D90
		private void FadeOut() {} // 0x0000000186BB3D90-0x0000000186BB4090
	}
}
