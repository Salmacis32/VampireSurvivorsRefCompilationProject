/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using VampireSurvivors.Data;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Graphics
{
	[UsedImplicitly]
	public class MaterialManager : IInitializable // TypeDefIndex: 14526
	{
		// Fields
		private static readonly Dictionary<MaterialType, Material> MaterialsCache; // 0x00
	
		// Constructors
		public MaterialManager() {} // 0x0000000180B15170-0x0000000180B15180
		static MaterialManager() {} // 0x00000001870584F0-0x00000001870585D0
	
		// Methods
		public void Initialize() {} // 0x0000000187057860-0x00000001870578B0
		public static Material GetMaterial(MaterialType type) => default; // 0x00000001870578B0-0x00000001870579A0
		private static void LoadAllMaterials() {} // 0x00000001870579A0-0x00000001870584F0
	}
}
