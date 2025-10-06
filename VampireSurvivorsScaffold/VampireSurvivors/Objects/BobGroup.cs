/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;
using VampireSurvivors.Graphics.Blitters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects
{
	public class BobGroup : IDisposable // TypeDefIndex: 15063
	{
		// Fields
		private const int GrowAmount = 64; // Metadata: 0x01977295
		private static Stack<BobGroup> emptyGroups; // 0x00
		public TweenState tweenState; // 0x10
		private List<Bob> _bobs; // 0x18
		private Vector2 _basePosition; // 0x20
		private Vector2 _raisedPosition; // 0x28
		private Vector2 _baseScale; // 0x30
		private Vector2 _raisedScale; // 0x38
		private Vector2 _currentScale; // 0x40
		private float _progress; // 0x48
		private float _currentTime; // 0x4C
		private float _targetTime; // 0x50
		private float _showDuration; // 0x54
		private float _holdDuration; // 0x58
		private float _hideDuration; // 0x5C
		private int _intCount; // 0x60
		private float _characterWidth; // 0x64
		private readonly List<float> _baseXPositions; // 0x68
		private readonly List<float> _xDifferences; // 0x70
		private bool _disposed; // 0x78
	
		// Nested types
		public enum TweenState // TypeDefIndex: 15062
		{
			Showing = 0,
			Holding = 1,
			Hiding = 2,
			Completed = 3
		}
	
		// Constructors
		private BobGroup() {} // 0x00000001869D2BD0-0x00000001869D2FD0
		static BobGroup() {} // 0x00000001869D3E40-0x00000001869D3F20
	
		// Methods
		private void Reset() {} // 0x00000001869D2FD0-0x00000001869D3140
		public static BobGroup Create() => default; // 0x00000001869D3140-0x00000001869D3350
		public void SetIntCount(int num) {} // 0x0000000181C2C000-0x0000000181C2C010
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public void Update(float deltaTime) {} // 0x00000001869D3350-0x00000001869D37C0
		public void Start(Vector2 basePos, float raise = 2f /* Metadata: 0x01977291 */) {} // 0x00000001869D37C0-0x00000001869D3A70
		private void Show() {} // 0x00000001869D3A70-0x00000001869D3A80
		private void Hold() {} // 0x00000001869D3A80-0x00000001869D3AA0
		private void Hide() {} // 0x00000001869D3AA0-0x00000001869D3AC0
		private void Complete() {} // 0x00000001869D3AC0-0x00000001869D3AD0
		public void Dispose() {} // 0x00000001869D3AD0-0x00000001869D3B70
		public void RemoveBobs(Blitter blitter) {} // 0x00000001869D3B70-0x00000001869D3DE0
		public void AddBob(Bob bob) {} // 0x00000001869D3DE0-0x00000001869D3E40
	}
}
