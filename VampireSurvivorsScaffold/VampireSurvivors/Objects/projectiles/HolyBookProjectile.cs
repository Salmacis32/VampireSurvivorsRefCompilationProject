/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class HolyBookProjectile : Projectile // TypeDefIndex: 15897
	{
		// Fields
		private ParticleSystem _pfx; // 0xD0
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0xD8
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xE0
		private Tween _scaleTween; // 0xE8
		private Tween _radiusTweenX; // 0xF0
		private float[] _requiemRandomOffsets; // 0xF8
		private int _requiemRandomIndex; // 0x100
		private float _deltaTime; // 0x104
		private const float Percentage = 0.0625f; // Metadata: 0x01977936
		private const float Radius = 0.5f; // Metadata: 0x0197793A
		private const float SpeedModifier = 35f; // Metadata: 0x0197793E
	
		// Constructors
		public HolyBookProjectile() {} // 0x0000000186E304C0-0x0000000186E30590
	
		// Methods
		protected override void Awake() {} // 0x0000000186E2EFA0-0x0000000186E2F070
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E2F070-0x0000000186E2F740
		public override void InternalUpdate() {} // 0x0000000186E2F740-0x0000000186E2FA90
		public override void Despawn() {} // 0x0000000186E2FA90-0x0000000186E2FD80
		private void Expire() {} // 0x0000000186E2FD80-0x0000000186E2FFC0
		private void GenerateParticleSystem() {} // 0x0000000186E2FFC0-0x0000000186E304C0
	}
}
