/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Tools
{
	public class Shake : MonoBehaviour // TypeDefIndex: 14280
	{
		// Fields
		private Transform _target; // 0x20
		private bool _isRunning; // 0x28
		private float _duration; // 0x2C
		private Vector2 _intensity; // 0x30
		private float _progress; // 0x38
		private float _elapsed; // 0x3C
		private float _offsetX; // 0x40
		private float _offsetY; // 0x44
		private bool _force; // 0x48
		private Vector2 _basePosition; // 0x4C
		private Action updateCallback; // 0x58
	
		// Constructors
		public Shake() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		public void StartShake(float duration, Vector2 intensity, bool force = false /* Metadata: 0x0197712E */, Action callback = null) {} // 0x0000000187049990-0x0000000187049BA0
		private void Update() {} // 0x0000000187049BA0-0x0000000187049E80
		private void Complete() {} // 0x0000000187049E80-0x0000000187049FA0
	}
}
