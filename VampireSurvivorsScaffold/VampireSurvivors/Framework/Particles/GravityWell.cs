/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Particles
{
	public class GravityWell : GameMonoBehaviour // TypeDefIndex: 18227
	{
		// Fields
		private GravityWellConfig _config; // 0x28
		private Transform _cachedTransform; // 0x30
		private readonly List<ParticleSystem> _targets; // 0x38
		private readonly List<ParticleSystem.Particle[]> _particlesCaches; // 0x40
		private float _power; // 0x48
		private float _epsilon; // 0x4C
		private float _gravity; // 0x50
		private bool _requiresLateUpdate; // 0x54
	
		// Properties
		public float Epsilon { get => default; set {} } // 0x00000001867069E0-0x0000000186706A00 0x0000000186706A00-0x0000000186706A10
		public float Power { get => default; set {} } // 0x0000000186706A10-0x0000000186706A20 0x0000000186706A20-0x0000000186706A30
		public float Gravity { get => default; set {} } // 0x0000000183A343D0-0x0000000183A343E0 0x0000000186706A30-0x0000000186706A50
	
		// Constructors
		public GravityWell() {} // 0x0000000186707730-0x00000001867078D0
	
		// Methods
		private new void Awake() {} // 0x0000000186706A50-0x0000000186706AC0
		protected override void OnUpdate() {} // 0x0000000186706AC0-0x0000000186706BD0
		private void LateUpdate() {} // 0x0000000186706BD0-0x0000000186706CE0
		public void Init(GravityWellConfig config) {} // 0x0000000186706CE0-0x0000000186706D80
		public void AddParticleSystem(ParticleSystem ps) {} // 0x0000000186706D80-0x0000000186706F40
		public void RemoveParticleSystem(ParticleSystem ps) {} // 0x0000000186706F40-0x0000000186706FC0
		public void Clear() {} // 0x0000000186706FC0-0x0000000186707060
		private void UpdateSystem(ParticleSystem system, ref ParticleSystem.Particle[] cache) {} // 0x0000000186707060-0x00000001867072F0
		private void UpdateParticle(int index, ParticleSystem.Particle[] cache) {} // 0x00000001867072F0-0x0000000186707730
	}
}
