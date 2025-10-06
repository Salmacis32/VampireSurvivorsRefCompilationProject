/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework
{
	public class ArcanaManager_VFX // TypeDefIndex: 17447
	{
		// Fields
		private GameObject _SapphireMistGO; // 0x10
		private bool _SapphireMist_Ready; // 0x18
		private ParticleEmitterManager _SapphireMist_PFXManager; // 0x20
		private ParticleSystem _SapphireMist_pfxEmitter; // 0x28
		private ParticleSystem _SapphireMist_pfxEmitter2; // 0x30
		private GravityWell _SapphireMist_well; // 0x38
		private VampireSurvivors.Objects.Characters.CharacterController _SapphireMist_LastUser; // 0x40
		private Vector3 _SapphireMist_GravityWellOffset; // 0x48
		private List<float> _sapphireMistDetunes; // 0x58
		private int _sapphireMistDetunesIndex; // 0x60
		public WorldEaterVFX WorldEaterVFX; // 0x68
	
		// Constructors
		public ArcanaManager_VFX() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public void Play_SapphireMist(VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x00000001872CEEB0-0x00000001872CF1F0
		public void Play_WorldEater(VampireSurvivors.Objects.Characters.CharacterController character, bool isCursed = false /* Metadata: 0x019785B2 */) {} // 0x00000001872CF1F0-0x00000001872CF2D0
		public void Update() {} // 0x00000001872CF2D0-0x00000001872CF400
		public static List<float> MakeDetunes(int amount = 100 /* Metadata: 0x019785B3 */, int min = -1000 /* Metadata: 0x019785B5 */, int max = 1000 /* Metadata: 0x019785B7 */, bool shuffle = true /* Metadata: 0x019785B9 */) => default; // 0x00000001872CF400-0x00000001872CF580
		public void Generate_SapphireMist() {} // 0x00000001872CF580-0x00000001872D0C40
	}
}
