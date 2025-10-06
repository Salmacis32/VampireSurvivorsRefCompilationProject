/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using JetBrains.Annotations;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.PhaserTweens
{
	public class TweenConfig // TypeDefIndex: 18132
	{
		// Fields
		public object[] targets; // 0x10
		public float duration; // 0x18
		public float delay; // 0x1C
		public Ease ease; // 0x20
		public int repeat; // 0x24
		public float repeatDelay; // 0x28
		public bool yoyo; // 0x2C
		[CanBeNull]
		public TweenCallback onStart; // 0x30
		[CanBeNull]
		public TweenCallback onComplete; // 0x38
		[CanBeNull]
		public TweenCallback onYoyo; // 0x40
		[CanBeNull]
		public TweenCallback onRepeat; // 0x48
		[CanBeNull]
		public TweenCallback onUpdate; // 0x50
		[CanBeNull]
		public TweenCallback onStop; // 0x58
		public float? x; // 0x60
		public float? y; // 0x68
		public float? localX; // 0x70
		public float? localY; // 0x78
		public float? scale; // 0x80
		public float? scaleX; // 0x88
		public float? scaleY; // 0x90
		public float? tileScaleX; // 0x98
		public float? tileScaleY; // 0xA0
		public float? angle; // 0xA8
		public float? localAngle; // 0xB0
		public RotateMode rotateMode; // 0xB8
		public float? alpha; // 0xBC
		public uint? tint; // 0xC4
		public Dictionary<string, object> custom; // 0xD0
		[CanBeNull]
		public Func<int, float> staggerDuration; // 0xD8
		[CanBeNull]
		public Func<int, float> staggerDelay; // 0xE0
		[CanBeNull]
		public Func<int, float> staggerX; // 0xE8
		[CanBeNull]
		public Func<int, float> staggerY; // 0xF0
		[CanBeNull]
		public Func<int, float> staggerLocalX; // 0xF8
		[CanBeNull]
		public Func<int, float> staggerLocalY; // 0x100
		[CanBeNull]
		public Func<int, float> staggerScale; // 0x108
		[CanBeNull]
		public Func<int, float> staggerScaleX; // 0x110
		[CanBeNull]
		public Func<int, float> staggerScaleY; // 0x118
		[CanBeNull]
		public Func<int, float> staggerAngle; // 0x120
		[CanBeNull]
		public Func<int, float> staggerLocalAngle; // 0x128
		[CanBeNull]
		public Func<int, float> staggerAlpha; // 0x130
	
		// Constructors
		public TweenConfig() {} // 0x00000001866CFCC0-0x00000001866CFD70
	}
}
