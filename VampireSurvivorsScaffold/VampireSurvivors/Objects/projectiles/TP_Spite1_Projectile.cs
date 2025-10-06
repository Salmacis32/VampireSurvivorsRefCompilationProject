/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Spite1_Projectile : Projectile // TypeDefIndex: 15678
	{
		// Fields
		[SerializeField]
		private TrailRenderer _LightTrail; // 0xD0
		private float _bodyRadius; // 0xD8
		private MultiTargetTween _scaleTween; // 0xE0
		private MultiTargetTween _fadeInTrailTween; // 0xE8
		private bool _isLight; // 0xF0
		private float _waveAngle; // 0xF4
		private float _waveIncrement; // 0xF8
		private Sprite _cachedLightSprite; // 0x100
		private Sprite _cachedDarkSprite; // 0x108
		private float _pathModifier; // 0x110
		private bool _isUpwards; // 0x114
	
		// Constructors
		public TP_Spite1_Projectile() {} // 0x0000000186D26440-0x0000000186D264B0
	
		// Methods
		protected override void Awake() {} // 0x0000000186D253D0-0x0000000186D257C0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D257C0-0x0000000186D25EE0
		private void StartDespawn() {} // 0x0000000186D25EE0-0x0000000186D26170
		public override void InternalUpdate() {} // 0x0000000186D26170-0x0000000186D262E0
		public override void Despawn() {} // 0x0000000186D262E0-0x0000000186D26440
	}
}
