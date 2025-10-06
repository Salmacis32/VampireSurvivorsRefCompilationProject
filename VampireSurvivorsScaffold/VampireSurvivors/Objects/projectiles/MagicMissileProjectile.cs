/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Profiling;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class MagicMissileProjectile : Projectile // TypeDefIndex: 15925
	{
		// Fields
		[SerializeField]
		private float _IndexOffsetScaleFactor; // 0xD0
		private ParticleEmitterManager _pfxManager; // 0xD8
		private ParticleSystem _pfx; // 0xE0
		private MagicMissileWeapon _trueWeapon; // 0xE8
		private static readonly ProfilerMarker _markerInitProjectile; // 0x00
	
		// Constructors
		public MagicMissileProjectile() {} // 0x0000000186E49790-0x0000000186E497F0
		static MagicMissileProjectile() {} // 0x0000000186E497F0-0x0000000186E49860
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E486C0-0x0000000186E48C20
		private void GenerateParticleSystem() {} // 0x0000000186E48C20-0x0000000186E49400
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186E49400-0x0000000186E49410
		protected override void OnHasHitAnotherPlayerObject(IDamageable other) {} // 0x0000000186E49410-0x0000000186E494C0
		private void OnHasHitAnObjectLogic(IDamageable other, bool triggerHit) {} // 0x0000000186E494C0-0x0000000186E495E0
		public override void InternalUpdate() {} // 0x0000000186E495E0-0x0000000186E49790
	}
}
