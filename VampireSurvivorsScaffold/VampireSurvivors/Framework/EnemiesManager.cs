/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework
{
	[UsedImplicitly]
	public class EnemiesManager : GameTickable, IInitializable, IDisposable // TypeDefIndex: 17461
	{
		// Fields
		[Inject]
		private GameManager _gameManager; // 0x10
		private static readonly ProfilerMarker s_onTickMarker; // 0x00
	
		// Nested types
		[BurstCompile]
		private struct EnemyVelocityCalcJob : IJobParallelFor // TypeDefIndex: 17460
		{
			// Fields
			public NativeArray<float3> _positionArray; // 0x00
			public NativeArray<float3> _velocityArray; // 0x10
			public NativeArray<float> _speedArray; // 0x20
			public NativeArray<bool> _fixedDirectionArray; // 0x30
			public NativeArray<float3> _currentDirectionArray; // 0x40
			public NativeArray<float3> _targetArray; // 0x50
			public bool _isPaused; // 0x60
	
			// Methods
			public void Execute(int index) {} // 0x0000000187323350-0x0000000187323360
			private void HandleTargetVelocityCalc(int index) {} // 0x0000000187323360-0x00000001873235A0
		}
	
		// Constructors
		public EnemiesManager() {} // 0x0000000180B15170-0x0000000180B15180
		static EnemiesManager() {} // 0x00000001873232E0-0x0000000187323350
	
		// Methods
		public void Initialize() {} // 0x0000000180B15170-0x0000000180B15180
		public void Dispose() {} // 0x0000000180B15170-0x0000000180B15180
		protected override void OnTick() {} // 0x00000001873224E0-0x00000001873227A0
		private void RunMovementJob() {} // 0x00000001873227A0-0x00000001873232E0
	}
}
