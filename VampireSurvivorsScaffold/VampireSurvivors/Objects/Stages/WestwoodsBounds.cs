/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	public class WestwoodsBounds : MonoBehaviour // TypeDefIndex: 15363
	{
		// Fields
		[SerializeField]
		[Tooltip("X coordinate for the right hand side of the stage that will always be the same")]
		private float _staticBoundsLimit; // 0x20
		[SerializeField]
		private float[] _boundsXLimits; // 0x28
		[SerializeField]
		[Space]
		private float _inverseStaticBoundsLimit; // 0x30
		[SerializeField]
		private float[] _inverseBoundsXLimits; // 0x38
		private bool _isStageInverse; // 0x40
	
		// Properties
		public float StaticBoundsLimit { get => default; } // 0x0000000186B998A0-0x0000000186B998C0 
		public float[] BoundsXLimits { get => default; } // 0x0000000186B998C0-0x0000000186B998D0 
	
		// Nested types
		public enum WestwoodsZone // TypeDefIndex: 15362
		{
			One = 0,
			Two = 1,
			Three = 2
		}
	
		// Constructors
		public WestwoodsBounds() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		public void Initialise(bool isStageInverse) {} // 0x0000000182699170-0x0000000182699180
		public void EnableBoundsForZone(WestwoodsZone zone) {} // 0x0000000186B998D0-0x0000000186B99B50
		public bool IsPositionInsidePlayableSpace(float2 position, WestwoodsZone currentUnlockedZone) => default; // 0x0000000186B99B50-0x0000000186B99BD0
	}
}
