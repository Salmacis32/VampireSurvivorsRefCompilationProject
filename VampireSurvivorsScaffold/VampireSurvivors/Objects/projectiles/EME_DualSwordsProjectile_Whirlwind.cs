/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_DualSwordsProjectile_Whirlwind : Projectile // TypeDefIndex: 15769
	{
		// Fields
		[SerializeField]
		private ParticleSystem FX; // 0xD0
		private const float Radius = 25f; // Metadata: 0x019777FA
		private MultiTargetTween _tween; // 0xD8
		private MultiTargetTween _tween2; // 0xE0
		private bool _initialisedParticles; // 0xE8
		private static readonly int _AlphaMul; // 0x00
		private VampireSurvivors.Framework.TimerSystem.Timer _DespawnTimer; // 0xF0
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0xF8
		private bool isMoving; // 0x100
	
		// Constructors
		public EME_DualSwordsProjectile_Whirlwind() {} // 0x0000000186D81710-0x0000000186D81760
		static EME_DualSwordsProjectile_Whirlwind() {} // 0x0000000186D81760-0x0000000186D817C0
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D80610-0x0000000186D80650
		private void InitializeSelf() {} // 0x0000000186BC4AB0-0x0000000186BC4AC0
		private void OnRecycleSelf() {} // 0x0000000186D80650-0x0000000186D813B0
		private void StartDespawn() {} // 0x0000000186D813B0-0x0000000186D81680
		public override void Despawn() {} // 0x0000000186D81680-0x0000000186D81710
		public override void InternalUpdate() {} // 0x0000000180B15170-0x0000000180B15180
	}
}
