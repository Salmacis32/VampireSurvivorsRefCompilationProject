/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using QFSW.MOP2;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.VFX
{
	[UsedImplicitly]
	public class HeroVfxManager : IInitializable, IDisposable // TypeDefIndex: 15188
	{
		// Fields
		private static HeroVfxFactory _factory; // 0x00
	
		// Constructors
		public HeroVfxManager() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		[Inject]
		private void Construct(HeroVfxFactory factory) {} // 0x0000000186A82E90-0x0000000186A82F30
		public void Initialize() {} // 0x0000000186A82F30-0x0000000186A82FA0
		public void Dispose() {} // 0x0000000186A82FA0-0x0000000186A83010
		public static ObjectPool GetPool(HeroVfxType type) => default; // 0x0000000186A83010-0x0000000186A83080
	}
}
