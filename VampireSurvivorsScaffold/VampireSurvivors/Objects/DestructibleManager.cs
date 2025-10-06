/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using QFSW.MOP2;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects
{
	[UsedImplicitly]
	public class DestructibleManager : IInitializable, IDisposable // TypeDefIndex: 15061
	{
		// Fields
		private static DestructibleFactory _factory; // 0x00
	
		// Constructors
		public DestructibleManager() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		[Inject]
		private void Construct(DestructibleFactory factory) {} // 0x00000001869D26F0-0x00000001869D2790
		public void Initialize() {} // 0x00000001869D2790-0x00000001869D2800
		public void Dispose() {} // 0x00000001869D2800-0x00000001869D2870
		public static ObjectPool GetPool(PropType type) => default; // 0x00000001869D2870-0x00000001869D28E0
		public static List<Destructible> AllActiveDestructibles() => default; // 0x00000001869D28E0-0x00000001869D2BD0
	}
}
