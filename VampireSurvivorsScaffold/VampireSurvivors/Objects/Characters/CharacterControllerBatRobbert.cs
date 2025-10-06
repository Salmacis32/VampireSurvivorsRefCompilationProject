/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class CharacterControllerBatRobbert : CharacterController // TypeDefIndex: 16932
	{
		// Fields
		private int MaxHealthMaxBonus; // 0x3F0
		private int CurrentMaxHPBonus; // 0x3F4
		private PhaserSprite _highlight; // 0x3F8
		private PhaserSprite _rainbow; // 0x400
		private MultiTargetTween _highlightTween; // 0x408
		private MultiTargetTween _rainbowTween; // 0x410
		private MultiTargetTween _highlightTween2; // 0x418
		private MultiTargetTween _rainbowTween2; // 0x420
	
		// Constructors
		public CharacterControllerBatRobbert() {} // 0x00000001871095A0-0x00000001871095C0
	
		// Methods
		public override void AfterFullInitialization() {} // 0x00000001871084D0-0x00000001871085A0
		private void CriticalHP() {} // 0x00000001871085A0-0x0000000187108840
		private void CriticalAnim() {} // 0x0000000187108840-0x0000000187108950
		public void ShowHighlightAt(float x, float y) {} // 0x0000000187108950-0x0000000187109430
		private void AddMaxHPBonus(int value) {} // 0x0000000187109430-0x00000001871095A0
	}
}
