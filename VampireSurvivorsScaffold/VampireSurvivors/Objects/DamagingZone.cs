/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.TimerSystem;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects
{
	public class DamagingZone : PoolablePhaserSprite // TypeDefIndex: 15069
	{
		// Fields
		private Transform _cachedTransform; // 0x48
		private bool _activateDamage; // 0x50
		private bool _hasHit; // 0x51
		private bool _follow; // 0x52
		private string _skin; // 0x58
		private float _damage; // 0x60
		private float _durationMillis; // 0x64
		private float _hitDelayMillis; // 0x68
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x70
		private VampireSurvivors.Framework.TimerSystem.Timer _despawnTimer; // 0x78
		private PhaserSprite _groundFx; // 0x80
		private ParticleSystem _currentEmitter1; // 0x88
		private ParticleSystem _currentEmitter2; // 0x90
		private ParticleEmitterManager _particlesManagerWeapons; // 0x98
		private ParticleSystem _pfxEmitterW1; // 0xA0
		private ParticleSystem _pfxEmitterW2; // 0xA8
		private GravityWell _wellW; // 0xB0
		private ParticleEmitterManager _particlesManagerTrainees; // 0xB8
		private ParticleSystem _pfxEmitterT1; // 0xC0
		private ParticleSystem _pfxEmitterT2; // 0xC8
		private GravityWell _wellT; // 0xD0
		private ParticleEmitterManager _particlesManagerExplosions; // 0xD8
		private ParticleSystem _pfxEmitterE1; // 0xE0
		private ParticleSystem _pfxEmitterE2; // 0xE8
		private GravityWell _wellE; // 0xF0
		private ParticleEmitterManager _particlesManagerCoffins; // 0xF8
		private ParticleSystem _pfxEmitterC1; // 0x100
		private ParticleSystem _pfxEmitterC2; // 0x108
		private GravityWell _wellC; // 0x110
		private const string SkinWeapons = "Weapons"; // Metadata: 0x019772B5
		private const string SkinCoffins = "Coffins"; // Metadata: 0x019772BD
		private const string SkinTrainees = "Trainees"; // Metadata: 0x019772C5
		private const string SkinExplosions = "Explosions"; // Metadata: 0x019772CE
		private Transform _targetTransform; // 0x118
	
		// Properties
		public bool LockX { get; set; } // 0x0000000182917530-0x0000000182917540 0x0000000184BB63B0-0x0000000184BB63C0
		public bool LockY { get; set; } // 0x00000001867531D0-0x00000001867531E0 0x00000001867531E0-0x00000001867531F0
	
		// Constructors
		public DamagingZone() {} // 0x00000001869E6360-0x00000001869E6440
	
		// Methods
		protected override void Awake() {} // 0x00000001869D7270-0x00000001869D72E0
		protected override void OnUpdate() {} // 0x00000001869DCD80-0x00000001869DD5B0
		public void Init(float w, float h, float damage, float durationMillis, float hitBoxDelayMillis, string skinType, bool follow, Transform targetTransform) {} // 0x00000001869DD5B0-0x00000001869DE150
		public void TriggerDespawnDelayed() {} // 0x00000001869DE150-0x00000001869DE340
		private void Despawn() {} // 0x00000001869DE340-0x00000001869DE470
		private void SetExplosionSize(float x, float y, float width, float height) {} // 0x00000001869DE470-0x00000001869DE7A0
		private void SetExplosionDamage(float damage, float durationMillis, float hitDelayMillis) {} // 0x00000001869DE7A0-0x00000001869DE7B0
		private void Shoot() {} // 0x00000001869DE7B0-0x00000001869DF580
		private float Approach(float start, float end, float shift) => default; // 0x00000001869DF580-0x00000001869DF5A0
		private void SetEmitterInCenter() {} // 0x00000001869DF5A0-0x00000001869DF7F0
		private void SetEmitterOnTheRight() {} // 0x00000001869DF7F0-0x00000001869DFAA0
		private void SetEmitterOnTheLeft() {} // 0x00000001869DFAA0-0x00000001869DFD50
		private void SetEmitterOnTheTop() {} // 0x00000001869DFD50-0x00000001869E0000
		private void SetEmitterBounds() {} // 0x00000001869E0000-0x00000001869E0200
		private void MakeParticleSystems() {} // 0x00000001869E0200-0x00000001869E0240
		private void MakeEmitters_Weapons() {} // 0x00000001869E0240-0x00000001869E1B10
		private void MakeEmitters_Coffins() {} // 0x00000001869E1B10-0x00000001869E30C0
		private void MakeEmitters_Trainees() {} // 0x00000001869E30C0-0x00000001869E47C0
		private void MakeEmitters_Explosions() {} // 0x00000001869E47C0-0x00000001869E5F80
		private GameObject CreateEmitterGameObject(string childName) => default; // 0x00000001869E5F80-0x00000001869E61B0
		private void StopAllEmitters() {} // 0x00000001869E61B0-0x00000001869E6270
		private void ToggleParentAllEmitters(bool shouldParent) {} // 0x00000001869E6270-0x00000001869E6360
		private static void SetParentAndScale(Transform trans, Transform parent) {} // 0x00000001869DC850-0x00000001869DC940
	}
}
