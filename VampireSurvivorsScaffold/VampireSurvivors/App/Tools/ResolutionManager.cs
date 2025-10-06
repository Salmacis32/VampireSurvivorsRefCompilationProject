/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Tools
{
	public class ResolutionManager : IInitializable, IDisposable, ITickable // TypeDefIndex: 18551
	{
		// Fields
		private static Vector2 _resolution; // 0x10
		private static DeviceOrientation _orientation; // 0x18
		private static float _checkTimer; // 0x1C
		private const float CHECK_DELAY = 0.5f; // Metadata: 0x0197AA4C
	
		// Events
		public static event Action<Vector2> OnResolutionChange;
		public static event Action<DeviceOrientation> OnOrientationChange;
	
		// Constructors
		public ResolutionManager() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public void Initialize() {} // 0x00000001867DDC70-0x00000001867DDDB0
		public void Dispose() {} // 0x0000000180B15170-0x0000000180B15180
		public void Tick() {} // 0x00000001867DDDB0-0x00000001867DE150
	}
}
