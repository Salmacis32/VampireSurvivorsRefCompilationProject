/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_DualSwordsProjectile_Torrent : Projectile // TypeDefIndex: 15767
	{
		// Fields
		[SerializeField]
		private ParticleSystem FX; // 0xD0
		private const float Radius = 25f; // Metadata: 0x019777F6
		private float _spinRadiusX; // 0xD8
		private float _spinRadiusY; // 0xDC
		private float _spinSpeed; // 0xE0
		private MultiTargetTween _tween; // 0xE8
		private MultiTargetTween _tween2; // 0xF0
		private EME_DualSwordsWeapon _trueWeapon; // 0xF8
		private bool _initialisedParticles; // 0x100
		private static readonly int _ScrollSpeedX; // 0x00
		private static readonly int _ScrollSpeedY; // 0x04
		private static readonly int _AlphaMul; // 0x08
		private VampireSurvivors.Framework.TimerSystem.Timer _DespawnTimer; // 0x108
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x110
		private bool isMoving; // 0x118
		private float _elapsedSpinTime; // 0x11C
		private float2 _originalPosition; // 0x120
	
		// Properties
		public float SpinSpeed { get => default; } // 0x0000000186D7EED0-0x0000000186D7EF90 
	
		// Constructors
		public EME_DualSwordsProjectile_Torrent() {} // 0x0000000186D803D0-0x0000000186D80440
		static EME_DualSwordsProjectile_Torrent() {} // 0x0000000186D80440-0x0000000186D80500
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D7EF90-0x0000000186D7F090
		private void InitializeSelf() {} // 0x0000000186D7F090-0x0000000186D7F170
		private void OnRecycleSelf() {} // 0x0000000186D7F170-0x0000000186D7FD80
		private void StartDespawn() {} // 0x0000000186D7FD80-0x0000000186D800C0
		public override void Despawn() {} // 0x0000000186D800C0-0x0000000186D80150
		public override void InternalUpdate() {} // 0x0000000186D80150-0x0000000186D803D0
	}
}
