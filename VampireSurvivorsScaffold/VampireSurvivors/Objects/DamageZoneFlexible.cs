/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects
{
	public class DamageZoneFlexible : PoolablePhaserSprite // TypeDefIndex: 15068
	{
		// Fields
		private Transform _cachedTransform; // 0x48
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x50
		private VampireSurvivors.Framework.TimerSystem.Timer _despawnTimer; // 0x58
		private VampireSurvivors.Framework.TimerSystem.Timer _particleDespawnTimer; // 0x60
		private MultiTargetTween _activateDamageZoneTween; // 0x68
		private MultiTargetTween _enableDamageTween; // 0x70
		private MultiTargetTween _warningTween; // 0x78
		private float _damage; // 0x80
		private float _activatonDelay; // 0x84
		private float _durationMillis; // 0x88
		private float _hitDelayMillis; // 0x8C
		private bool _haveWarningMark; // 0x90
		private float _warningTimeMillis; // 0x94
		private PhaserSprite _exclamationMark; // 0x98
		protected bool _isCircle; // 0xA0
		protected Circle _circleCollider; // 0xA8
		protected bool _activateDamage; // 0xB0
		protected bool _hasHit; // 0xB1
		private bool _follow; // 0xB2
		private float _followSpeed; // 0xB4
		private bool _lockX; // 0xB8
		private bool _lockY; // 0xB9
		private Transform _targetTransform; // 0xC0
		private bool _visibleWarningZone; // 0xC8
		protected PhaserSprite _groundFx; // 0xD0
		private float2 _offsetPosition; // 0xD8
		private PhaserSprite _damageSprite; // 0xE0
		private bool _usingParticles; // 0xE8
		private ParticleEmitterManager _particlesManager; // 0xF0
		private ZoneAlignment _zoneAlignment; // 0xF8
		private ParticleSystem _currentEmitter; // 0x100
		private ParticleSystem _pfxEmitter; // 0x108
		private GravityWell _well; // 0x110
	
		// Nested types
		public enum ZoneAlignment // TypeDefIndex: 15067
		{
			Center = 0,
			Left = 1,
			Right = 2,
			Top = 3,
			Bottom = 4
		}
	
		// Constructors
		public DamageZoneFlexible() {} // 0x00000001869DC940-0x00000001869DC9C0
	
		// Methods
		protected override void Awake() {} // 0x00000001869D7270-0x00000001869D72E0
		public static DamageZoneFlexible CreateZone(Camera targetCamera) => default; // 0x00000001869D72E0-0x00000001869D7550
		public static ParticleSystemConfig BaseConfig(Vector3 pos, List<string> frames, string textureName = "items" /* Metadata: 0x019772A0 */) => default; // 0x00000001869D7550-0x00000001869D7C70
		public void InitDamageZone(float damage, float durationMillis, float activationDelay, float hitDelayMillis, float2 spawnLocation) {} // 0x00000001869D7C70-0x00000001869D7FB0
		public void InitDamageZoneCircle(float radius, bool enableGroundVisuals = true /* Metadata: 0x019772A6 */) {} // 0x00000001869D7FB0-0x00000001869D8350
		private void SetCircleDamageZone(float radius) {} // 0x00000001869D8350-0x00000001869D86D0
		public void InitDamageZoneRectangle(float width, float height, bool enableGroundVisuals = true /* Metadata: 0x019772A7 */) {} // 0x00000001869D86D0-0x00000001869D8B90
		private void SetRectangleDamageZone(float2 size) {} // 0x00000001869D8B90-0x00000001869D8D50
		public void InitWarningBehaviour(bool haveWarningMark, float warningTimeMillis = 600f /* Metadata: 0x019772A8 */) {} // 0x00000001869D8D50-0x00000001869D8D60
		public void InitDamageZoneBehaviour(bool lockX, bool lockY, bool following, Transform targetTransform = null, float followSpeed = 1f /* Metadata: 0x019772AC */) {} // 0x00000001869D8D60-0x00000001869D8E00
		public void InitParticleVisuals(ParticleSystemConfig newConfig, ZoneAlignment newAlignment) {} // 0x00000001869D8E00-0x00000001869D8F10
		public void InitSpriteVisuals(List<Sprite> newAnimFrames, int fps, float offsetX, float offsetY, float frameScale) {} // 0x00000001869D8F10-0x00000001869D9290
		public void EnableZone() {} // 0x00000001869D9290-0x00000001869D9DF0
		private void ActivateDamage() {} // 0x00000001869D9DF0-0x00000001869DA760
		protected override void OnUpdate() {} // 0x00000001869DA760-0x00000001869DAE00
		protected virtual Vector3 UpdatePosition(Vector3 currentPosition) => default; // 0x00000001869DAE00-0x00000001869DB000
		protected virtual void UpdatePlayerEffects() {} // 0x00000001869DB000-0x00000001869DB290
		private void TriggerDespawnDelayed() {} // 0x00000001869DB290-0x00000001869DB530
		protected virtual void Despawn() {} // 0x00000001869DB530-0x00000001869DB7E0
		private Vector3 GetZoneAlignmentPosition(Vector3 pos) => default; // 0x00000001869DB7E0-0x00000001869DBA60
		private void SetEmitterLocation(Vector3 newPos) {} // 0x00000001869DBA60-0x00000001869DBC90
		private void SetEmitterBounds() {} // 0x00000001869DBC90-0x00000001869DBDD0
		private void MakeEmitterManager() {} // 0x00000001869DBDD0-0x00000001869DC1F0
		private void MakeEmitters(ParticleSystemConfig config1, ParticleSystemConfig config2) {} // 0x00000001869DC1F0-0x00000001869DC490
		private GameObject CreateEmitterGameObject(string childName) => default; // 0x00000001869DC490-0x00000001869DC6C0
		private void StopAllEmitters() {} // 0x00000001869DC6C0-0x00000001869DC720
		private void ToggleParentAllEmitters(bool shouldParent) {} // 0x00000001869DC720-0x00000001869DC850
		private static void SetParentAndScale(Transform trans, Transform parent) {} // 0x00000001869DC850-0x00000001869DC940
	}
}
