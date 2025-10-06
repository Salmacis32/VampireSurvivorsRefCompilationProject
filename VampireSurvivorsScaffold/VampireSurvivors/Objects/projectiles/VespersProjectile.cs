/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class VespersProjectile : Projectile // TypeDefIndex: 15985
	{
		// Fields
		[SerializeField]
		private SpriteAnimation _animation; // 0xD0
		private ParticleSystem _pfx; // 0xD8
		protected MaterialPropertyBlock _propBlock; // 0xE0
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0xE8
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xF0
		private MultiTargetTween _scaleTween; // 0xF8
		private float[] _requiemRandomOffsets; // 0x100
		private int _requiemRandomIndex; // 0x108
		private float _deltaTime; // 0x10C
		private const float Percentage = 0.0625f; // Metadata: 0x019779C2
		private const float Radius = 0.5f; // Metadata: 0x019779C6
		private const float SpeedModifier = 35f; // Metadata: 0x019779CA
	
		// Constructors
		public VespersProjectile() {} // 0x0000000186E96B00-0x0000000186E96BD0
	
		// Methods
		protected override void Awake() {} // 0x0000000186E95270-0x0000000186E95420
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E95420-0x0000000186E95D20
		public override void InternalUpdate() {} // 0x0000000186E95D20-0x0000000186E96070
		public override void Despawn() {} // 0x0000000186E96070-0x0000000186E96330
		protected virtual void Expire() {} // 0x0000000186E96330-0x0000000186E96600
		private void GenerateParticleSystem() {} // 0x0000000186E96600-0x0000000186E96B00
	}
}
