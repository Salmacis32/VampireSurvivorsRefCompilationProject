/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework
{
	public class GlimmerTechniqueCarousel : MonoBehaviour // TypeDefIndex: 17493
	{
		// Fields
		[SerializeField]
		private GlimmerTechniqueCarouselItem m_GlimmerTechniqueCarouselItemPrefab; // 0x20
		[SerializeField]
		private Transform m_OffScreenTransform; // 0x28
		private List<GlimmerTechniqueCarouselItem> m_CurrentlyShowingGlimmmerTechniques; // 0x30
		private List<GlimmerTechniqueCarouselItem> m_GlimmmerTechniquesToBeReturnedToPool; // 0x38
		private List<GlimmerTechniqueCarouselItem> m_GlimmmerTechniquePool; // 0x40
		[SerializeField]
		private float m_SlideToFillGapSpeed; // 0x48
		private int m_TechniquePoolSize; // 0x4C
		private float m_GapBetweenTechniques; // 0x50
		private float m_MaximumHeight; // 0x54
		private float m_AgeToEndIntroSwish; // 0x58
		private float m_AgeToStartExit; // 0x5C
		private float m_AgeToDie; // 0x60
	
		// Constructors
		public GlimmerTechniqueCarousel() {} // 0x000000018732B600-0x000000018732B670
	
		// Methods
		private void Start() {} // 0x000000018732A210-0x000000018732A7E0
		private void Update() {} // 0x000000018732A7E0-0x000000018732AF60
		private void ProcessReturningGlimmmerTechniquesToPool() {} // 0x000000018732AF60-0x000000018732B250
		private void SpawnNewTestTechnique() {} // 0x000000018732B250-0x000000018732B2A0
		public void SpawnGlimmerTechnique(string techniqueText) {} // 0x000000018732B2A0-0x000000018732B600
	}
}
