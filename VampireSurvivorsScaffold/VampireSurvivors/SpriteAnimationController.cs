/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Profiling;
using VampireSurvivors.Graphics;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class SpriteAnimationController : GameMonoBehaviour // TypeDefIndex: 13926
	{
		// Fields
		private static readonly HashSet<BaseSpriteAnimation> Animations; // 0x00
		private static readonly HashSet<BaseSpriteAnimation> PendingAdd; // 0x08
		private static readonly HashSet<BaseSpriteAnimation> PendingRemove; // 0x10
		private static ProfilerMarker update; // 0x18
		private static bool iterating; // 0x20
	
		// Constructors
		public SpriteAnimationController() {} // 0x0000000184C44C90-0x0000000184C44CE0
		static SpriteAnimationController() {} // 0x00000001865C7080-0x00000001865C7500
	
		// Methods
		protected override void OnUpdate() {} // 0x00000001865C67A0-0x00000001865C6E10
		public static void Add(BaseSpriteAnimation baseSpriteAnimation) {} // 0x00000001865C6E10-0x00000001865C6F50
		public static void Remove(BaseSpriteAnimation baseSpriteAnimation) {} // 0x00000001865C6F50-0x00000001865C7080
	}
}
