/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class PartyProjectile : Projectile // TypeDefIndex: 15427
	{
		// Fields
		[SerializeField]
		private TrailRenderer _trail; // 0xD0
		[SerializeField]
		private SpriteAnimation _SpriteAnimation; // 0xD8
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xE0
		private List<Transform> _positions; // 0xE8
		private uint _color; // 0xF0
		private float _saveVelX; // 0xF4
		private float _saveVelY; // 0xF8
		private List<float> _velMultipliersX; // 0x100
		private List<float> _velMultipliersY; // 0x108
		private List<float> _partyAngles; // 0x110
		private PartyWeapon _trueWeapon; // 0x118
		private MultiTargetTween _gravityTween; // 0x120
		private Vector2 _leftVelocity; // 0x128
		private Vector2 _rightVelocity; // 0x130
		private float _bounceValue; // 0x138
		private MultiTargetTween _angleTween; // 0x140
		private List<int> _randomStartingFrame; // 0x148
		private int _randomStartingIndex; // 0x150
		private int _maxStartingFrame; // 0x154
		private bool _canClearObjectsHit; // 0x158
		private float _clearObjectTime; // 0x15C
		[NonSerialized]
		public float EnemiesHit; // 0x160
		[NonSerialized]
		public List<Vector2> BouncePositions; // 0x168
		[NonSerialized]
		public float SelfGravity; // 0x170
	
		// Constructors
		public PartyProjectile() {} // 0x0000000186BEF860-0x0000000186BEFB40
	
		// Methods
		protected override void Awake() {} // 0x0000000186BECE40-0x0000000186BED710
		public int GetRandomFrame() => default; // 0x0000000186BED710-0x0000000186BED7A0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BED7A0-0x0000000186BEE1D0
		public void ClearObjectsHit() {} // 0x0000000186BEE1D0-0x0000000186BEE240
		public void SetType(int type) {} // 0x0000000186BEE240-0x0000000186BEE6E0
		public void PickType() {} // 0x0000000186BEE6E0-0x0000000186BEE810
		public override void OnHasHitWallPhaser(PhaserTile tile) {} // 0x0000000186BEE810-0x0000000186BEE8D0
		public override void SetTarget(Transform target) {} // 0x0000000186BEE8D0-0x0000000186BEECD0
		private void Bounce(Body b, bool up, bool down, bool left, bool right) {} // 0x0000000186BEECD0-0x0000000186BEECE0
		private void SetupTrails() {} // 0x0000000186BEECE0-0x0000000186BEF0D0
		private void FadeOutAndDispose() {} // 0x0000000186BEF0D0-0x0000000186BEF460
		public override void Despawn() {} // 0x0000000186BEF460-0x0000000186BEF4A0
		public override void InternalUpdate() {} // 0x0000000186BEF4A0-0x0000000186BEF650
		private void ClearPositions() {} // 0x0000000186BEF650-0x0000000186BEF6C0
		protected override void OnHasHitAnObject(IDamageable target) {} // 0x0000000186BEF6C0-0x0000000186BEF6D0
		protected override void OnHasHitAnotherPlayerObject(IDamageable other) {} // 0x0000000186BEF6D0-0x0000000186BEF6E0
		private void OnHasHitAnObjectLogic(IDamageable target, bool triggerHit) {} // 0x0000000186BEF6E0-0x0000000186BEF860
	}
}
