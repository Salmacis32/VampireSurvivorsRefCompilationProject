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
	public class ParticleEmitterManager : GameMonoBehaviour // TypeDefIndex: 18229
	{
		// Fields
		[SerializeField]
		public string _GlobalClockKey; // 0x28
		private readonly List<ParticleSystem> _particleSystems; // 0x30
		private List<GravityWell> _gravityWells; // 0x38
		private float _defaultDepth; // 0x40
	
		// Properties
		private bool UsePauseSystem { get => default; } // 0x0000000186707950-0x00000001867079D0 
	
		// Constructors
		public ParticleEmitterManager() {} // 0x000000018670A400-0x000000018670A610
	
		// Methods
		protected void Start() {} // 0x00000001867079D0-0x0000000186707AA0
		public ParticleSystem CreateEmitter(ParticleSystemConfig config, Transform parent = null, string psName = null) => default; // 0x0000000186707AA0-0x0000000186707DA0
		public ParticleSystem CreateUIEmitter(ParticleSystemConfig config, string layer, int order, Transform parent = null, string psName = null, bool isAdditive = true /* Metadata: 0x019788D2 */, bool requiresMasking = false /* Metadata: 0x019788D3 */) => default; // 0x0000000186707DA0-0x0000000186708790
		public GravityWell CreateGravityWell(GravityWellConfig config, Transform parent = null, string gravityWellName = null) => default; // 0x0000000186708790-0x0000000186708BB0
		public void AddGravityWellParticleSystems(GravityWell gravityWell) {} // 0x0000000186708BB0-0x0000000186708D20
		public void RemoveGravityWell(GravityWell gc) {} // 0x0000000186708D20-0x0000000186708DF0
		public void UpdateGravityWellConfig(GravityWellConfig gc) {} // 0x0000000186708DF0-0x0000000186709020
		public float GetRemainingLifetime() => default; // 0x0000000186709020-0x00000001867091D0
		public ParticleEmitterManager SetDepth(int depth) => default; // 0x00000001867091D0-0x0000000186709370
		public void SetDepthMultiplied(float depth, float mul = 100f /* Metadata: 0x019788D4 */) {} // 0x0000000186709370-0x0000000186709510
		public void EmitParticleAt(Vector2 pos, int count = 1 /* Metadata: 0x019788D8 */) {} // 0x0000000186709510-0x00000001867097B0
		public void EmitParticleTowards(Vector2 pos, Vector3 direction, int count = 1 /* Metadata: 0x019788D9 */) {} // 0x00000001867097B0-0x0000000186709A90
		public void RemoveEmitter(ParticleSystem sys) {} // 0x0000000186709A90-0x0000000186709C70
		public void StartAllEmitters() {} // 0x0000000186709C70-0x0000000186709DE0
		public void StopAllEmitters() {} // 0x0000000186709DE0-0x000000018670A010
		public void DestroyAllOwnedSystems() {} // 0x000000018670A010-0x000000018670A400
	}
}
