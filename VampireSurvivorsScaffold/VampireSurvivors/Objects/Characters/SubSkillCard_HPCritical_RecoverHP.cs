/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class SubSkillCard_HPCritical_RecoverHP : CharacterSkillCard_Base // TypeDefIndex: 16879
	{
		// Fields
		private PhaserSprite _highlight; // 0x70
		private PhaserSprite _rainbow; // 0x78
		private MultiTargetTween _highlightTween; // 0x80
		private MultiTargetTween _rainbowTween; // 0x88
		private MultiTargetTween _highlightTween2; // 0x90
		private MultiTargetTween _rainbowTween2; // 0x98
	
		// Constructors
		public SubSkillCard_HPCritical_RecoverHP() {} // Dummy constructor
		public SubSkillCard_HPCritical_RecoverHP(ArcanaType type) {} // 0x00000001870D5D20-0x00000001870D5D30
	
		// Methods
		public override void InitialActivate() {} // 0x00000001870E58B0-0x00000001870E58F0
		public override void OnOwnerCriticalHPTreshold(float rawDamage) {} // 0x00000001870E5F30-0x00000001870E6190
		private void CriticalAnim() {} // 0x00000001870E6190-0x00000001870E62A0
		public void ShowHighlightAt(float x, float y) {} // 0x00000001870E62A0-0x00000001870E6D70
	}
}
