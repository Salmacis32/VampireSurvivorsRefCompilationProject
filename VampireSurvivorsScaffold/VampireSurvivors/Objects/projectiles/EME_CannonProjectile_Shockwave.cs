/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_CannonProjectile_Shockwave : Projectile // TypeDefIndex: 15758
	{
		// Fields
		[SerializeField]
		private ParticleSystem _shockwaveVFX; // 0xD0
		private Transform _targetEnemy; // 0xD8
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xE0
		private VampireSurvivors.Framework.TimerSystem.Timer _despawnTimer; // 0xE8
	
		// Constructors
		public EME_CannonProjectile_Shockwave() {} // 0x0000000186D7A4F0-0x0000000186D7A540
	
		// Methods
		protected override void Awake() {} // 0x0000000186BB4A00-0x0000000186BB4A10
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D79E00-0x0000000186D7A2D0
		[IteratorStateMachine(typeof(_DespawnInAFrame_d__6))]
		private IEnumerator DespawnInAFrame() => default; // 0x0000000186D7A2D0-0x0000000186D7A370
		private void StartDespawn() {} // 0x0000000186D7A370-0x0000000186D7A480
		public override void Despawn() {} // 0x0000000186D7A480-0x0000000186D7A4F0
	}
}
