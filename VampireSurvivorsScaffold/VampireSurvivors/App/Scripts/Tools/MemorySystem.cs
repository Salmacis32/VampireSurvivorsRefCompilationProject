/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Scripts.Tools
{
	public class MemorySystem : IInitializable, IDisposable // TypeDefIndex: 18652
	{
		// Fields
		public static LowOnMemoryEvent OnLowMemoryEvent; // 0x00
	
		// Nested types
		public delegate void LowOnMemoryEvent(); // TypeDefIndex: 18651; 0x000000018196C270-0x000000018196C280
	
		// Constructors
		public MemorySystem() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public void Initialize() {} // 0x000000018680C1F0-0x000000018680C3B0
		public void Dispose() {} // 0x000000018680C3B0-0x000000018680C570
		public static long GetTotalAllocatedMemoryInBytes() => default; // 0x0000000186104F50-0x0000000186104FA0
		public static void LogMemoryStats() {} // 0x000000018680C570-0x000000018680C740
		private void OnApplicationLowOnMemory() {} // 0x000000018680C740-0x000000018680C7E0
	}
}
