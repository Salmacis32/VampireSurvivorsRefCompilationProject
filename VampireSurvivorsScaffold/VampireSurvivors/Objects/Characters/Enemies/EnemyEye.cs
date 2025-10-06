/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyEye : EnemyController // TypeDefIndex: 17314
	{
		// Fields
		private Circle _explosionCircle; // 0x270
		private ParticleEmitterManager _particleEmitterManager; // 0x278
		private ParticleSystem _emitter1; // 0x280
		private ParticleSystem _emitter2; // 0x288
		private float _totalTime; // 0x290
		private const float Radius = 16f; // Metadata: 0x01978437
		private const float EmitInterval = 0.030000001f; // Metadata: 0x0197843B
	
		// Constructors
		public EnemyEye() {} // 0x0000000187262680-0x00000001872626D0
	
		// Methods
		protected override void Awake() {} // 0x0000000187260AA0-0x0000000187260AC0
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x0000000187260AC0-0x0000000187260E50
		protected override void OnUpdate() {} // 0x0000000187260E50-0x00000001872612B0
		protected override void Die() {} // 0x00000001872188E0-0x00000001872188F0
		private void GenerateParticleSystems() {} // 0x00000001872612B0-0x0000000187262680
	}
}
