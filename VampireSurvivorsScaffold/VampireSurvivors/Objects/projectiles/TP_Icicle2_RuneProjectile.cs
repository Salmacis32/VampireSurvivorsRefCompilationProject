/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Icicle2_RuneProjectile : Projectile // TypeDefIndex: 15596
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _RuneSprite; // 0xD0
		[SerializeField]
		private SpriteAnimation _RuneAnimation; // 0xD8
		private const float BodyRadius = 14f; // Metadata: 0x01977746
		private const float Radius = 0.15f; // Metadata: 0x0197774A
		private const float PfxFrequency = 100f; // Metadata: 0x0197774E
		private readonly uint[] _pfxTints; // 0xE0
		private TP_Icicle2_Weapon _trueWeapon; // 0xE8
		private ParticleSystem _pfx; // 0xF0
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0xF8
		private VampireSurvivors.Framework.TimerSystem.Timer _pfxTintTimer; // 0x100
		private Tween _scaleTween; // 0x108
		private Tween _posTween; // 0x110
	
		// Constructors
		public TP_Icicle2_RuneProjectile() {} // 0x0000000186CD18B0-0x0000000186CD19A0
	
		// Methods
		protected override void Awake() {} // 0x0000000186CCFFF0-0x0000000186CD0240
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CD0240-0x0000000186CD05D0
		private void ScaleIn() {} // 0x0000000186CD05D0-0x0000000186CD07E0
		private void StartTimers() {} // 0x0000000186CD07E0-0x0000000186CD0A20
		private void PlaySfx() {} // 0x0000000186CD0A20-0x0000000186CD0B50
		private void RandomisePfxTint() {} // 0x0000000186CD0B50-0x0000000186CD0DE0
		public override void InternalUpdate() {} // 0x0000000186CD0DE0-0x0000000186CD0EF0
		private void LateUpdate() {} // 0x0000000186CD0EF0-0x0000000186CD0F80
		private void UpdatePfxScale() {} // 0x0000000186CD0DE0-0x0000000186CD0EF0
		private void UpdateRotation() {} // 0x0000000186CD0EF0-0x0000000186CD0F80
		public void MoveToNewPosition() {} // 0x0000000186CD0F80-0x0000000186CD11C0
		public override void Despawn() {} // 0x0000000186CD11C0-0x0000000186CD1250
		private void GenerateParticleSystem() {} // 0x0000000186CD1250-0x0000000186CD1840
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186CD1840-0x0000000186CD18B0
	}
}
