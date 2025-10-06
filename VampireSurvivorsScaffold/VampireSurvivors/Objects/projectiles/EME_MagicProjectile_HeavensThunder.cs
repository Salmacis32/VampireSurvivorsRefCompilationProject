/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_MagicProjectile_HeavensThunder : Projectile // TypeDefIndex: 15807
	{
		// Fields
		[SerializeField]
		protected ParticleSystem _particleSystem; // 0xD0
		[SerializeField]
		protected ParticleEventCall _particleEventCall; // 0xD8
		private MultiTargetTween _despawnTween; // 0xE0
		private MultiTargetTween _alphaTween; // 0xE8
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0xF0
		private MultiTargetTween _moveTween; // 0xF8
		private Transform target; // 0x100
		private List<SfxType> _sfxList; // 0x108
		private static int _sfxIndex; // 0x00
		private bool _follow; // 0x110
	
		// Constructors
		public EME_MagicProjectile_HeavensThunder() {} // 0x0000000186DC5290-0x0000000186DC54B0
	
		// Methods
		protected override void Awake() {} // 0x0000000186DC47B0-0x0000000186DC4850
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DC4850-0x0000000186DC4F40
		public override void InternalUpdate() {} // 0x0000000186DC4F40-0x0000000186DC51E0
		public override void Despawn() {} // 0x0000000186DC51E0-0x0000000186DC5290
		private void DespawnAfterParticlesToFinish() {} // 0x0000000186DC3540-0x0000000186DC3570
	}
}
