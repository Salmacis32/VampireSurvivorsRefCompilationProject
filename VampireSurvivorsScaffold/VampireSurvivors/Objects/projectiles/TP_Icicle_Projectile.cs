/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Icicle_Projectile : Projectile // TypeDefIndex: 15597
	{
		// Fields
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0xD0
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xD8
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer2; // 0xE0
		private MultiTargetTween _scaleTween; // 0xE8
		private MultiTargetTween _alphaTween; // 0xF0
		private float _deltaTime; // 0xF8
		private float2 posOffset; // 0xFC
		private PhaserSprite _crystalSprite; // 0x108
		private PhaserSprite _icicleSprite; // 0x110
		private PhaserSprite _animatedSprite; // 0x118
		private const float Percentage = 0.0625f; // Metadata: 0x01977752
		private const float Radius = 0.5f; // Metadata: 0x01977756
		private const float SpeedModifier = 35f; // Metadata: 0x0197775A
		private List<string> _frameNames; // 0x120
		private float _angle1; // 0x128
		private float _angle2; // 0x12C
		private float _angle3; // 0x130
		private bool isAiming; // 0x134
		private bool isExploding; // 0x135
		private TP_Icicle_Weapon trueWeapon; // 0x138
		private float2 targetPosition; // 0x140
	
		// Constructors
		public TP_Icicle_Projectile() {} // 0x0000000186CD3280-0x0000000186CD34C0
	
		// Methods
		protected override void Awake() {} // 0x0000000186CD1A20-0x0000000186CD2010
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CD2010-0x0000000186CD2B90
		private void AimAtTarget() {} // 0x0000000186CD2B90-0x0000000186CD2C10
		public override void InternalUpdate() {} // 0x0000000186CD2C10-0x0000000186CD2DB0
		public override void Despawn() {} // 0x0000000186CD2DB0-0x0000000186CD2E30
		public void Shoot() {} // 0x0000000186CD2E30-0x0000000186CD3080
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186CD3080-0x0000000186CD3280
	}
}
