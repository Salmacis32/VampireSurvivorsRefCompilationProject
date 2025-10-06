/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Icicle2_Projectile : Projectile // TypeDefIndex: 15595
	{
		// Fields
		private const float BodyRadius = 24f; // Metadata: 0x01977736
		private const float Percentage = 0.0625f; // Metadata: 0x0197773A
		private const float Radius = 0.5f; // Metadata: 0x0197773E
		private const float SpeedModifier = 35f; // Metadata: 0x01977742
		private float _deltaTime; // 0xD0
		private readonly List<SpriteTextureData> _icicleSprites; // 0xD8
		private TP_Icicle2_Weapon _trueWeapon; // 0xE0
		private PhaserSprite _crystalSprite; // 0xE8
		private PhaserSprite _icicleSprite; // 0xF0
		private readonly float[] _requiemRandomOffsets; // 0xF8
		private int _requiemRandomIndex; // 0x100
		private float _crystalAngle1; // 0x104
		private float _crystalAngle2; // 0x108
		private float _crystalAngle3; // 0x10C
		private float _crystalRotSpeedMod; // 0x110
		private Tween _scaleTween; // 0x118
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x120
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x128
	
		// Constructors
		public TP_Icicle2_Projectile() {} // 0x0000000186CCFB40-0x0000000186CCFFA0
	
		// Methods
		protected override void Awake() {} // 0x0000000186CCD630-0x0000000186CCDF30
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CCDF30-0x0000000186CCE290
		private void InitSprites() {} // 0x0000000186CCE290-0x0000000186CCE470
		private void ScaleIn() {} // 0x0000000186CCE470-0x0000000186CCE620
		private void StartTimers() {} // 0x0000000186CCE620-0x0000000186CCE890
		public override void InternalUpdate() {} // 0x0000000186CCE890-0x0000000186CCEA60
		private void UpdatePosition() {} // 0x0000000186CCEA60-0x0000000186CCECF0
		private void UpdateRotation() {} // 0x0000000186CCECF0-0x0000000186CCEFF0
		private void UpdateScale() {} // 0x0000000186CCEFF0-0x0000000186CCF0E0
		private void UpdateCrystal() {} // 0x0000000186CCF0E0-0x0000000186CCF1C0
		private void Expire() {} // 0x0000000186CCF1C0-0x0000000186CCF400
		private void LaunchIcicle() {} // 0x0000000186CCF400-0x0000000186CCF6B0
		public override void Despawn() {} // 0x0000000186CCF6B0-0x0000000186CCF710
		private void ExplodeOnExpire() {} // 0x0000000186CCF710-0x0000000186CCFAD0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186CCFAD0-0x0000000186CCFB40
	}
}
