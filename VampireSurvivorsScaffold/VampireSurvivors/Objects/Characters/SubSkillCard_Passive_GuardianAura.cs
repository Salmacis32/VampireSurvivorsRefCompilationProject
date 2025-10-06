/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class SubSkillCard_Passive_GuardianAura : CharacterSkillCard_Base // TypeDefIndex: 16904
	{
		// Fields
		private List<CharacterController> _charactersAffectedByAura; // 0x70
		private ParticleSystem _guardianParticleSystem; // 0x78
		private float _timer; // 0x80
	
		// Constructors
		public SubSkillCard_Passive_GuardianAura() {} // Dummy constructor
		public SubSkillCard_Passive_GuardianAura(ArcanaType type) {} // 0x00000001870D5D20-0x00000001870D5D30
	
		// Methods
		public override void InitialActivate() {} // 0x00000001870EC590-0x00000001870ECFB0
		public override void Update() {} // 0x00000001870ECFB0-0x00000001870ED530
		private void ApplyAuraToPlayer(CharacterController character) {} // 0x00000001870ED530-0x00000001870ED700
		private void RemoveAuraFromPlayer(CharacterController character) {} // 0x00000001870ED700-0x00000001870ED8D0
	}
}
