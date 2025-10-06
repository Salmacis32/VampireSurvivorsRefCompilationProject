/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class HolyWaterProjectile : Projectile // TypeDefIndex: 15899
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _GroundFx; // 0xD0
		private Camera _camera; // 0xD8
		private Tween _angleTween; // 0xE0
		private Tween _positionTween; // 0xE8
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0xF0
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xF8
		private VampireSurvivors.Framework.TimerSystem.Timer _DespawnTimer; // 0x100
		private ParticleSystem _pfx1; // 0x108
		private ParticleSystem _pfx2; // 0x110
		private ParticleSystem _explosionPfx1; // 0x118
		private ParticleSystem _explosionPfx2; // 0x120
		private Circle _explosionCircle; // 0x128
		private const float Radius = 16f; // Metadata: 0x01977942
		private const float ExploRadius = 8f; // Metadata: 0x01977946
		private bool _isBroken; // 0x130
		private bool _isDespawning; // 0x131
	
		// Properties
		private HolyWaterWeapon HolyWater { get => default; } // 0x0000000186E30670-0x0000000186E30700 
	
		// Constructors
		public HolyWaterProjectile() {} // 0x0000000186E34390-0x0000000186E343E0
	
		// Methods
		protected override void Awake() {} // 0x0000000186E30700-0x0000000186E30720
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E30720-0x0000000186E31660
		public override void InternalUpdate() {} // 0x0000000186E31660-0x0000000186E319B0
		private void Break() {} // 0x0000000186E319B0-0x0000000186E32510
		private void StartDespawn() {} // 0x0000000186E32510-0x0000000186E327C0
		public override void Despawn() {} // 0x0000000186E327C0-0x0000000186E32880
		private void GetComponents() {} // 0x0000000186E32880-0x0000000186E329B0
		private void GenerateParticleSystems() {} // 0x0000000186E329B0-0x0000000186E34390
	}
}
