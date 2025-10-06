/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class CharacterControllerSpaceDude : CharacterController // TypeDefIndex: 16976
	{
		// Fields
		private float _paradoxHazeDelay; // 0x3F0
		private float _paradoxHazeTime; // 0x3F4
		private VampireSurvivors.Framework.TimerSystem.Timer _activationTimer; // 0x3F8
		private PhaserSprite _highlight; // 0x400
		private PhaserSprite _rainbow; // 0x408
		private MultiTargetTween _highlightTween; // 0x410
		private MultiTargetTween _rainbowTween; // 0x418
		private MultiTargetTween _highlightTween2; // 0x420
		private MultiTargetTween _rainbowTween2; // 0x428
	
		// Constructors
		public CharacterControllerSpaceDude() {} // 0x000000018712D9E0-0x000000018712DA00
	
		// Methods
		public float ParadoxHazeInterval() => default; // 0x000000018712C990-0x000000018712C9D0
		public override void OnWeaponFired(Weapon weapon) {} // 0x000000018712C9D0-0x000000018712CBE0
		protected void ActivateAllWeapons() {} // 0x000000018712CBE0-0x000000018712CEB0
		protected override void OnUpdate() {} // 0x000000018712CEB0-0x000000018712CF00
		public void ShowHighlightAt(float x, float y) {} // 0x000000018712CF00-0x000000018712D9E0
	}
}
