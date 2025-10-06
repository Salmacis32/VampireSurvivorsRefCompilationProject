/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_StarFlail2_Blade_Projectile : Projectile // TypeDefIndex: 15686
	{
		// Fields
		private MultiTargetTween _posTween; // 0xD0
		private SpriteAnimation _anim; // 0xD8
		private MultiTargetTween _despawnTween; // 0xE0
		private MultiTargetTween _scaleTween; // 0xE8
		private ParticleEmitterManager _pfxManager; // 0xF0
		private ParticleSystem _pfx; // 0xF8
		private float _angle; // 0x100
		private const float RotationSpeed = 500f; // Metadata: 0x019777AC
	
		// Constructors
		public TP_StarFlail2_Blade_Projectile() {} // 0x0000000186D30650-0x0000000186D306A0
	
		// Methods
		protected override void Awake() {} // 0x0000000186D2EE60-0x0000000186D2EF10
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D2EF10-0x0000000186D2F4C0
		public void ManualIntProjectile(float flyAngle, bool isFlipped) {} // 0x0000000186D2F4C0-0x0000000186D2F8A0
		public override void InternalUpdate() {} // 0x0000000186D2F8A0-0x0000000186D2F980
		private void UpdateRotation() {} // 0x0000000186D2F8A0-0x0000000186D2F980
		public void Shoot() {} // 0x0000000186D2F980-0x0000000186D2F9E0
		public void FadeOut() {} // 0x0000000186D2F9E0-0x0000000186D2FCB0
		public override void Despawn() {} // 0x0000000186D2FCB0-0x0000000186D2FD20
		private void GenerateParticleSystem() {} // 0x0000000186D2FD20-0x0000000186D30650
	}
}
