/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	public class EME_BiomeBounds : MonoBehaviour // TypeDefIndex: 15340
	{
		// Fields
		[SerializeField]
		private List<EmeraldsBiomeBounds> _biomeBoundsList; // 0x20
		[SerializeField]
		private float _invertedBoundsYOffset; // 0x28
	
		// Properties
		private bool IsStageInverted { get => default; } // 0x0000000186B8CB30-0x0000000186B8CD30 
	
		// Nested types
		[Serializable]
		public struct EmeraldsBiomeBounds // TypeDefIndex: 15339
		{
			// Fields
			public Color BoundsColor; // 0x00
			public float UpperLimit; // 0x10
			public float LowerLimit; // 0x14
		}
	
		// Constructors
		public EME_BiomeBounds() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		public EmeraldsBiomeBounds GetBoundsForBiome(BackgroundEmerald.EmeraldsBiomes biome) => default; // 0x0000000186B8CD30-0x0000000186B8CE80
		public float GetBiomeCentreY(BackgroundEmerald.EmeraldsBiomes biome) => default; // 0x0000000186B8CE80-0x0000000186B8CEC0
		public bool TryGetBiomePositionIsInside(Vector2 position, out BackgroundEmerald.EmeraldsBiomes biome) {
			biome = default;
			return default;
		} // 0x0000000186B8CEC0-0x0000000186B8CF90
	}
}
