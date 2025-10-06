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
	public class TP_GrandCross2_Projectile : Projectile // TypeDefIndex: 15577
	{
		// Fields
		[SerializeField]
		private MeshRenderer _CrossMesh; // 0xD0
		[SerializeField]
		private SpriteRenderer _TrailSprite; // 0xD8
		[SerializeField]
		private SpriteTrail _Trail; // 0xE0
		[SerializeField]
		private SpriteTrail _GoldenTrail; // 0xE8
		private const float Radius = 24f; // Metadata: 0x01977715
		private const float MaxAcceleration = 2f; // Metadata: 0x01977719
		private TP_GrandCross2_Weapon _trueWeapon; // 0xF0
		private Vector2 _velocity; // 0xF8
		private float _acceleration; // 0x100
		private bool _isGoingBackwards; // 0x104
		private bool _hasOverlappedBeam; // 0x105
		private bool _canDespawn; // 0x106
		private bool _isDespawning; // 0x107
		private Tween _angleTween; // 0x108
		private Tween _accelTween; // 0x110
		private Tween _backwardsTween; // 0x118
		private VampireSurvivors.Framework.TimerSystem.Timer _cullingTimer; // 0x120
	
		// Constructors
		public TP_GrandCross2_Projectile() {} // 0x0000000186CBBDB0-0x0000000186CBBE50
	
		// Methods
		protected override void Awake() {} // 0x0000000186CB9570-0x0000000186CB97C0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CB97C0-0x0000000186CB9B50
		private void InitPosition() {} // 0x0000000186CB9B50-0x0000000186CB9E00
		private void InitVelocity() {} // 0x0000000186CB9E00-0x0000000186CB9E50
		private void InitDepth() {} // 0x0000000186CB9E50-0x0000000186CB9F10
		private void InitTrails() {} // 0x0000000186CB9F10-0x0000000186CBA260
		private void InitBouncing() {} // 0x0000000186CBA260-0x0000000186CBA4B0
		private void DoTweens() {} // 0x0000000186CBA4B0-0x0000000186CBAA50
		private void GoBackwards() {} // 0x0000000186CBAA50-0x0000000186CBB020
		public override void InternalUpdate() {} // 0x0000000186CBB020-0x0000000186CBB2E0
		private void UpdateVelocity() {} // 0x0000000186CBB2E0-0x0000000186CBB330
		private void CheckForBeamOverlap() {} // 0x0000000186CBB330-0x0000000186CBB460
		private void SetTrailAlpha(SpriteTrail trail, float alpha) {} // 0x0000000186CBB460-0x0000000186CBB7B0
		private void PlaySfx() {} // 0x0000000186CBB7B0-0x0000000186CBB890
		private void Bounce(Body b, bool up, bool down, bool left, bool right) {} // 0x0000000186CBB890-0x0000000186CBB9F0
		protected override void OnHasHitAnotherPlayerObject(IDamageable other) {} // 0x0000000186CBB9F0-0x0000000186CBBBC0
		private void CheckForDespawn() {} // 0x0000000186CBBBC0-0x0000000186CBBD10
		public override void Despawn() {} // 0x0000000186CBBD10-0x0000000186CBBDB0
	}
}
