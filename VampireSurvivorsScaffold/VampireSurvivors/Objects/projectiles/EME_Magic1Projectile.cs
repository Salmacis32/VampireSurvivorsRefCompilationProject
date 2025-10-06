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
	public class EME_Magic1Projectile : Projectile // TypeDefIndex: 15803
	{
		// Fields
		[SerializeField]
		protected List<ParticleSystem> _availableSpiritRings; // 0xD0
		[SerializeField]
		[Space]
		private float _defaultOrbitRadius; // 0xD8
		[SerializeField]
		private float _maximumOrbitRadius; // 0xDC
		[SerializeField]
		private float _startingAngleOffset; // 0xE0
		[SerializeField]
		[Space]
		private float _defaultHitboxRadius; // 0xE4
		[SerializeField]
		private float _maximumHitboxRadius; // 0xE8
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0xF0
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xF8
		private Vector3 _chosenSpiritRingScale; // 0x100
		protected bool _activate; // 0x10C
		protected float _positionInCircumference; // 0x110
		protected ParticleSystem _chosenSpiritRing; // 0x118
	
		// Properties
		protected virtual float OrbitSpeed { get => default; } // 0x0000000186DC13D0-0x0000000186DC1420 
	
		// Constructors
		public EME_Magic1Projectile() {} // 0x0000000186DC21C0-0x0000000186DC2230
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DC1420-0x0000000186DC1550
		private void SetupMechanics() {} // 0x0000000186DC1550-0x0000000186DC1670
		private void SetupProjectileScale() {} // 0x0000000186DC1670-0x0000000186DC1760
		private void SetupTimers() {} // 0x0000000186DC1760-0x0000000186DC19A0
		public override void InternalUpdate() {} // 0x0000000186DC19A0-0x0000000186DC1AB0
		protected Vector3 OrbitPositionAroundPlayer(ref float positionInCircumference, float orbitSpeed) => default; // 0x0000000186DC1AB0-0x0000000186DC1C60
		public virtual void SetOffsetPosition(int index) {} // 0x0000000186DC1C60-0x0000000186DC1F60
		public override void Despawn() {} // 0x0000000186DC1F60-0x0000000186DC2120
		[IteratorStateMachine(typeof(_WaitForParticlesToFinish_d__22))]
		private IEnumerator WaitForParticlesToFinish() => default; // 0x0000000186DC2120-0x0000000186DC21C0
	}
}
