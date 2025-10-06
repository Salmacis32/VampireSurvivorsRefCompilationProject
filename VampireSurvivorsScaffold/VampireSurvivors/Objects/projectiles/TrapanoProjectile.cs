/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TrapanoProjectile : Projectile // TypeDefIndex: 15978
	{
		// Fields
		[FormerlySerializedAs("_trail")]
		[SerializeField]
		private TrailRenderer _Trail; // 0xD0
		[NonSerialized]
		public bool _isYeeted; // 0xD8
		[NonSerialized]
		public float _durataMillis; // 0xDC
		private MultiTargetTween _angleTween; // 0xE0
		private Vector2 _aimVec; // 0xE8
		private MultiTargetTween _tween1; // 0xF0
		private SpriteRenderer _groundFx; // 0xF8
		private PhaserSprite _spikeSprite; // 0x100
		private Vector2 _previousVector; // 0x108
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x110
		private bool _isFading; // 0x118
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x120
		private float _timeStopped; // 0x128
		private const int Radius = 8; // Metadata: 0x019779C1
	
		// Constructors
		public TrapanoProjectile() {} // 0x0000000186E8BAB0-0x0000000186E8BB00
	
		// Methods
		protected override void Awake() {} // 0x0000000186E89710-0x0000000186E89CC0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E89CC0-0x0000000186E8AB50
		public override void InternalUpdate() {} // 0x0000000186E8AB50-0x0000000186E8AFE0
		public override void Despawn() {} // 0x0000000186E8AFE0-0x0000000186E8B0E0
		private void FadeOut() {} // 0x0000000186E8B0E0-0x0000000186E8B480
		private void Yeet() {} // 0x0000000186E8B480-0x0000000186E8BAB0
	}
}
