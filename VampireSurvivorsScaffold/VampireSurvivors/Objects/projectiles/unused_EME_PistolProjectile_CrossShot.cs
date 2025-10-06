/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class unused_EME_PistolProjectile_CrossShot : Projectile // TypeDefIndex: 15854
	{
		// Fields
		[SerializeField]
		private ParticleSystem crossshotVFX; // 0xD0
		[SerializeField]
		private ParticleEventCall crossshotParticleEventCall; // 0xD8
		[SerializeField]
		private float hitboxWidth; // 0xE0
		[SerializeField]
		private float hitboxHeight; // 0xE4
		[SerializeField]
		private float centralOffset; // 0xE8
		private EnemyController _targetEnemyController; // 0xF0
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xF8
	
		// Constructors
		public unused_EME_PistolProjectile_CrossShot() {} // 0x0000000186DF26D0-0x0000000186DF2740
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DF1860-0x0000000186DF1A30
		private void SetupMechanics(int index) {} // 0x0000000186DF1A30-0x0000000186DF25C0
		private void SetupVisuals() {} // 0x0000000186DD4710-0x0000000186DD4730
		[IteratorStateMachine(typeof(_DespawnInAFrame_d__10))]
		private IEnumerator DespawnInAFrame() => default; // 0x0000000186DF25C0-0x0000000186DF2660
		public override void Despawn() {} // 0x0000000186DF2660-0x0000000186DF26D0
		private void DespawnAfterParticlesStopped() {} // 0x0000000186DD8C60-0x0000000186DD8CA0
		private void FinishDespawn() {} // 0x0000000186DD8C60-0x0000000186DD8CA0
	}
}
