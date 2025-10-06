/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class ParticleManager : IInitializable, IDisposable, ITickable // TypeDefIndex: 13911
	{
		// Fields
		[Inject]
		private SignalBus _signalBus; // 0x10
		private List<ParticleSystem> _registeredParticleSystems; // 0x18
		private List<ParticleSystem> _pausedParticleSystems; // 0x20
		private bool _wasPaused; // 0x28
		private float _time; // 0x2C
		private int _shaderParam; // 0x30
	
		// Constructors
		public ParticleManager() {} // 0x00000001865C1EA0-0x00000001865C1FE0
	
		// Methods
		private void UnpauseGame() {} // 0x00000001865C1720-0x00000001865C18B0
		private void PauseGame() {} // 0x00000001865C18B0-0x00000001865C1B50
		public void RegisterParticleSystem(ParticleSystem particleSystem) {} // 0x00000001865C1B50-0x00000001865C1BD0
		public void RegisterParticleSystem(ParticleSystem[] particleSystems) {} // 0x00000001865C1BD0-0x00000001865C1C90
		public void Initialize() {} // 0x00000001865C1C90-0x00000001865C1CF0
		public void Dispose() {} // 0x00000001865C1CF0-0x00000001865C1D30
		public void Tick() {} // 0x00000001865C1D30-0x00000001865C1EA0
	}
}
