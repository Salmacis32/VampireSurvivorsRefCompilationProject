/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Lapiste2_Projectile : Projectile // TypeDefIndex: 15609
	{
		// Fields
		[SerializeField]
		private Transform _BodyTarget; // 0xD0
		private TP_Lapiste2_Weapon _trueWeapon; // 0xD8
		private TP_Lapiste2_InvisibleProjectile _invisibleProjectile; // 0xE0
		private float _initialRotation; // 0xE8
		private PhaserSprite _fistSprite; // 0xF0
		private ParticleEmitterManager _pfxEmitter; // 0xF8
		private ParticleSystem _projEmitter; // 0x100
		private MultiTargetTween _scaleTween; // 0x108
		private VampireSurvivors.Framework.TimerSystem.Timer _launchTimer; // 0x110
	
		// Properties
		private SpriteTextureData FistSprite1 { get => default; } // 0x0000000186CDCD70-0x0000000186CDCEE0 
		private SpriteTextureData FistSprite2 { get => default; } // 0x0000000186CDCEE0-0x0000000186CDD050 
		private float[] FireAngles { get => default; } // 0x0000000186CDD050-0x0000000186CDD0C0 
	
		// Constructors
		public TP_Lapiste2_Projectile() {} // 0x0000000186CDF8B0-0x0000000186CDF900
	
		// Methods
		protected override void Awake() {} // 0x0000000186CDD0C0-0x0000000186CDD5E0
		private void GeneratePfx() {} // 0x0000000186CDD5E0-0x0000000186CDE460
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CDE460-0x0000000186CDEB40
		private void CreateInvisibleBody() {} // 0x0000000186CDEB40-0x0000000186CDEE30
		private void ScaleIn() {} // 0x0000000186CDEE30-0x0000000186CDF110
		private void PlaySfx() {} // 0x0000000186CDF110-0x0000000186CDF1F0
		public override void InternalUpdate() {} // 0x0000000186CDF1F0-0x0000000186CDF200
		private void UpdatePfx() {} // 0x0000000186CDF200-0x0000000186CDF3F0
		public override void Despawn() {} // 0x0000000186CDF3F0-0x0000000186CDF570
		public override void SetTarget(Transform target) {} // 0x0000000186CDF570-0x0000000186CDF7A0
		private void LaunchProjectile() {} // 0x0000000186CDF7A0-0x0000000186CDF8B0
	}
}
