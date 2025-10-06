/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
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
	public class VFXManager : IInitializable // TypeDefIndex: 14541
	{
		// Fields
		[Inject]
		private SignalBus _signalBus; // 0x10
		private static HitVFXData[] Config; // 0x00
		private static Material[] VfxTypeMaterialsCache; // 0x08
	
		// Constructors
		public VFXManager() {} // 0x0000000180B15170-0x0000000180B15180
		static VFXManager() {} // 0x00000001871AB950-0x00000001871ABAA0
	
		// Methods
		public void Initialize() {} // 0x00000001871AA650-0x00000001871AAD70
		private static Sprite GetVfxSprite(string frameName) => default; // 0x00000001871AAD70-0x00000001871AADF0
		public static HitVFXData GetData(HitVfxType vfxType) => default; // 0x00000001871AADF0-0x00000001871AAE70
		public static Material GetMaterial(HitVfxType type) => default; // 0x00000001871AAE70-0x00000001871AAEF0
		private static void AddData(HitVfxType t, bool hasTintFill, string color, string hitFrameName, string impactFrameName, float duration, Shader baseSpriteShader) {} // 0x00000001871AAEF0-0x00000001871AB110
		public static void SpawnImpactVFX(HitVfxType type, Vector2 worldPos) {} // 0x00000001871AB110-0x00000001871AB3D0
		private static void TryCacheVfxHitMaterial(HitVfxType t, bool hasTintFill, HitVFXData dat, Shader baseSpriteShader) {} // 0x00000001871AB3D0-0x00000001871AB950
	}
}
