/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class SilfWeapon : Weapon // TypeDefIndex: 16773
	{
		// Fields
		[SerializeField]
		protected SpriteRenderer _TargetZone; // 0x158
		public List<Vector2> _Targets; // 0x160
		public int _EnemyIndex; // 0x168
		public SpriteRenderer _Bird; // 0x170
		public float _RayDuration; // 0x178
		public float _TotalTime; // 0x17C
		public float _AngleTime; // 0x180
		protected float _damageZoneDistance; // 0x184
		protected float _damageZoneDefaultRadius; // 0x188
		protected bool _blockFire; // 0x18C
		protected float _delayBasedOnDuration; // 0x190
		protected Vector2 _currentDirection; // 0x194
		protected float _runSpeed; // 0x19C
		protected Circle _damageZone; // 0x1A0
		protected float _targetZoneAngle; // 0x1A8
		protected float _damageZoneAngle; // 0x1AC
		private const bool IsPortrait = false; // Metadata: 0x01977E31
		private const float GameplayPixelWidth = 3.42f; // Metadata: 0x01977E32
		private const float GameplayPixelHeight = 4.56f; // Metadata: 0x01977E36
		protected Color _targetZoneCol; // 0x1B0
		protected float _targetZoneStroke; // 0x1C0
		protected float _targetZoneAlphaOn; // 0x1C4
		protected float _targetZoneAlphaOff; // 0x1C8
		protected float _offsetY; // 0x1CC
		protected string _birdSprite; // 0x1D0
		protected string _birdAnimPrefix; // 0x1D8
		protected int _birdAnimStartFrame; // 0x1E0
		protected int _birdAnimFrameCount; // 0x1E4
		private static readonly int ColorId; // 0x00
		private static readonly int ThicknessId; // 0x04
		protected WeaponType _counterWeaponType; // 0x1E8
		protected Weapon _counterWeapon; // 0x1F0
	
		// Constructors
		public SilfWeapon() {} // 0x00000001870B8460-0x00000001870B8740
		static SilfWeapon() {} // 0x00000001870B8740-0x00000001870B87D0
	
		// Methods
		public override void CheckArcanas() {} // 0x00000001870B5BD0-0x00000001870B5FC0
		public override bool LevelUp() => default; // 0x00000001870B5FC0-0x00000001870B60E0
		public override bool ApplyLimitBreak(WeightedLimitBreak weightedLimitBreak) => default; // 0x00000001870B60E0-0x00000001870B6200
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x00000001870B6200-0x00000001870B6310
		public override void InternalUpdate() {} // 0x00000001870B6310-0x00000001870B6C90
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977E30 */) {} // 0x00000001870B6C90-0x00000001870B6D90
		public override void Cleanup() {} // 0x00000001870B6D90-0x00000001870B7000
		public override void HandlePlayerTeleport(float2 destinationPos) {} // 0x00000001870B7000-0x00000001870B7310
		protected virtual float OffsetX() => default; // 0x00000001870B7310-0x00000001870B7350
		protected virtual void AddTargets() {} // 0x00000001870B7350-0x00000001870B7450
		protected virtual void BlockFire() {} // 0x00000001870B7450-0x00000001870B75A0
		protected virtual void UnblockFire() {} // 0x00000001870B75A0-0x00000001870B7620
		protected virtual void UpdateTargetZonePos(SpriteRenderer targetZone, float angle) {} // 0x00000001870B7620-0x00000001870B7AE0
		protected virtual void UpdateDamageZonePos(Circle damageZone, float angle) {} // 0x00000001870B58E0-0x00000001870B5A10
		private void MakeBirb() {} // 0x00000001870B7AE0-0x00000001870B7F60
		private float DistanceSquared(Vector2 vec1, Vector2 vec2) => default; // 0x00000001869EF240-0x00000001869EF280
		protected void SetupTargetZone(SpriteRenderer targetZone) {} // 0x00000001870B7F60-0x00000001870B8210
		public override void SetVisible(bool visible) {} // 0x00000001870B8210-0x00000001870B8460
	}
}
