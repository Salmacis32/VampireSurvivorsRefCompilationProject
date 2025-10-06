/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_Confodere1_Weapon : Weapon // TypeDefIndex: 16297
	{
		// Fields
		private float _range; // 0x158
		private int _sourceIndex; // 0x15C
		private float _maxSources; // 0x160
		private List<Transform> _sources; // 0x168
		[SerializeField]
		protected SpriteRenderer _TargetZone; // 0x170
		[SerializeField]
		protected Transform _cachedTargetTransform; // 0x178
		protected Color _targetZoneCol; // 0x180
		protected float _targetZoneStroke; // 0x190
		private static readonly int AlphaId; // 0x00
		private static readonly int ColorId; // 0x04
		private static readonly int ThicknessId; // 0x08
		[NonSerialized]
		public int _FireCounter; // 0x194
		[NonSerialized]
		public int[] _FireAngles; // 0x198
		private float _defaultRange; // 0x1A0
		private BulletPool _destructibleProjectilePool; // 0x1A8
		[SerializeField]
		private Projectile _destructibleProjectilePrefab; // 0x1B0
		private BulletPool _bigProjectilePool; // 0x1B8
		[SerializeField]
		private Projectile _bigProjectilePrefab; // 0x1C0
		private BulletPool _specialProjectilePool; // 0x1C8
		[SerializeField]
		private Projectile _specialProjectilePrefab; // 0x1D0
		protected int _activations; // 0x1D8
		protected bool _hasLight; // 0x1DC
		protected bool _hasDark; // 0x1DD
		private ParticleEmitterManager _pfxManager; // 0x1E0
		private ParticleSystem _emitter1; // 0x1E8
		private ParticleSystem _emitter2; // 0x1F0
		protected List<WeaponType> lightGlyphs; // 0x1F8
		protected List<WeaponType> darkGlyphs; // 0x200
		private VampireSurvivors.Framework.TimerSystem.Timer glyphCheckTimer; // 0x208
	
		// Properties
		protected virtual bool bigProjectileEnabled { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		protected virtual bool specialProjectileEnabled { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
	
		// Constructors
		public TP_Confodere1_Weapon() {} // 0x0000000186F962A0-0x0000000186F96C60
		static TP_Confodere1_Weapon() {} // 0x0000000186F96C60-0x0000000186F96D20
	
		// Methods
		protected override void Awake() {} // 0x0000000186F92310-0x0000000186F92320
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F92320-0x0000000186F931C0
		protected void CheckGlyphs() {} // 0x0000000186F931C0-0x0000000186F93300
		public override void InternalUpdate() {} // 0x0000000186F93300-0x0000000186F934A0
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
		public void SetSources(List<Transform> array) {} // 0x0000000186F934A0-0x0000000186F93550
		public override float PPower() => default; // 0x0000000186F93550-0x0000000186F93600
		public float GetRange() => default; // 0x0000000186F93600-0x0000000186F93640
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977C31 */) {} // 0x0000000186F93640-0x0000000186F94380
		public override void SetVisible(bool visible) {} // 0x0000000186F94380-0x0000000186F944A0
		private Transform GetSource() => default; // 0x0000000186F944A0-0x0000000186F94550
		public override void Cleanup() {} // 0x0000000186F94550-0x0000000186F945C0
		protected virtual bool OnBigBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F945C0-0x0000000186F94840
		public override void CheckArcanas() {} // 0x0000000186F8E930-0x0000000186F8E9F0
		public void CheckLightGlyphs() {} // 0x0000000186F94840-0x0000000186F949E0
		public void CheckDarkGlyphs() {} // 0x0000000186F949E0-0x0000000186F94B80
		private void MakeEmitters() {} // 0x0000000186F94B80-0x0000000186F962A0
	}
}
