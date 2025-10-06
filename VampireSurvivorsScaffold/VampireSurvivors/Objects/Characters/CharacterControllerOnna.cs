/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class CharacterControllerOnna : CharacterController // TypeDefIndex: 16956
	{
		// Fields
		private SpriteRenderer _sparkSprite; // 0x3F0
		private SpriteRenderer _ringSprite; // 0x3F8
		private MultiTargetTween _ringTween; // 0x400
		private MultiTargetTween _sparkTween; // 0x408
		private int _firingIndex; // 0x410
	
		// Constructors
		public CharacterControllerOnna() {} // 0x0000000187107F90-0x0000000187107FA0
	
		// Methods
		protected override void MakeLevelOne(bool dontGetCharacterDataForCurrentLevel = false /* Metadata: 0x01977F46 */) {} // 0x000000018711EEF0-0x000000018711F460
		private void PlaySparkle() {} // 0x000000018711F460-0x000000018711FB70
		private void FireWeapons() {} // 0x000000018711FB70-0x000000018711FF90
		public override void LevelUp() {} // 0x000000018711FF90-0x00000001871200C0
	}
}
