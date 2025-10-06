/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine.Jobs;

// Image 43: PhaserPort.dll - Assembly: PhaserPort, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 38095-38187

namespace Plugins.PhaserPort.physics.arcade.jobs
{
	public struct PostSpriteOffsetUpdateJob : IJobParallelForTransform // TypeDefIndex: 38174
	{
		// Fields
		[ReadOnly]
		public NativeArray<bool> _enabledArray; // 0x00
		[ReadOnly]
		public NativeArray<bool> _movesArray; // 0x10
		[ReadOnly]
		public NativeArray<bool> _validArray; // 0x20
		[ReadOnly]
		public NativeArray<SpriteOffsetData> _spriteOffsetDataArray; // 0x30
	
		// Methods
		public void Execute(int index, TransformAccess transform) {} // 0x0000000184C6E150-0x0000000184C6E270
	}
}
