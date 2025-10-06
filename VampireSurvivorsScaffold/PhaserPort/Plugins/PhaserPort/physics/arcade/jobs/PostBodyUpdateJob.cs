/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine.Jobs;

// Image 43: PhaserPort.dll - Assembly: PhaserPort, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 38095-38187

namespace Plugins.PhaserPort.physics.arcade.jobs
{
	[BurstCompile]
	public struct PostBodyUpdateJob : IJobParallelForTransform // TypeDefIndex: 38173
	{
		// Fields
		[ReadOnly]
		public NativeArray<bool> _enabledArray; // 0x00
		[ReadOnly]
		public NativeArray<float2> _positionArray; // 0x10
		[ReadOnly]
		public NativeArray<float2> _previousFrameArray; // 0x20
		[ReadOnly]
		public NativeArray<float2> _deltaMaxArray; // 0x30
		[ReadOnly]
		public NativeArray<bool> _movesArray; // 0x40
		public NativeArray<int> _facingArray; // 0x50
		[ReadOnly]
		public NativeArray<bool> _allowRotationArray; // 0x60
		[ReadOnly]
		public NativeArray<float> _deltaZArray; // 0x70
	
		// Methods
		public void Execute(int index, TransformAccess transform) {} // 0x0000000184C6DDC0-0x0000000184C6E150
	}
}
