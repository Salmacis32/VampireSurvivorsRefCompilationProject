/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Slash2Projectile : Projectile // TypeDefIndex: 15663
	{
		// Fields
		[SerializeField]
		private TrailRenderer _verbotenTrail; // 0xD0
		[SerializeField]
		protected SpriteTrail _Trail; // 0xD8
		private float startingAngle; // 0xE0
		private float saveAngle; // 0xE4
		private float radiusX; // 0xE8
		private float radiusY; // 0xEC
		private TweenerCore<float, float, FloatOptions> _radiusTween; // 0xF0
		private TweenerCore<float, float, FloatOptions> _radiusTween2; // 0xF8
		private TweenerCore<float, float, FloatOptions> _angleTween; // 0x100
		private VampireSurvivors.Framework.TimerSystem.Timer _despawnTimer; // 0x108
		private Vector2 direction; // 0x110
		private Sprite _verbotenTrailSprite; // 0x118
		private static readonly int _FlipX; // 0x00
		private static readonly int _FlipY; // 0x04
		private float2 _startingOffset; // 0x120
		private float finalAngle; // 0x128
		private float currentAngle; // 0x12C
		private float trailAlpha; // 0x130
		private TweenerCore<float, float, FloatOptions> _trailAlphaTween; // 0x138
		private bool _isDespawning; // 0x140
		private MultiTargetTween _despawnTween; // 0x148
	
		// Constructors
		public TP_Slash2Projectile() {} // 0x0000000186D1BD80-0x0000000186D1BDE0
		static TP_Slash2Projectile() {} // 0x0000000186D1BDE0-0x0000000186D1BE70
	
		// Methods
		protected override void Awake() {} // 0x0000000186D1A160-0x0000000186D1A280
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D1A280-0x0000000186D1AEF0
		public void GoBack() {} // 0x0000000186D1AEF0-0x0000000186D1B620
		private void StartDespawn() {} // 0x0000000186D1B620-0x0000000186D1B8C0
		public override void Despawn() {} // 0x0000000186D1B8C0-0x0000000186D1BA40
		public override void InternalUpdate() {} // 0x0000000186D1BA40-0x0000000186D1BB10
		private void SetupVerbotenTrail() {} // 0x0000000186D1BB10-0x0000000186D1BD80
	}
}
