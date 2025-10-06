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
	public class CharacterControllerNara : CharacterController // TypeDefIndex: 16955
	{
		// Fields
		private SpriteRenderer _sparkSprite; // 0x3F0
		private SpriteRenderer _ringSprite; // 0x3F8
		private MultiTargetTween _ringTween; // 0x400
		private MultiTargetTween _sparkTween; // 0x408
		private int _firingIndex; // 0x410
	
		// Constructors
		public CharacterControllerNara() {} // 0x0000000187107F90-0x0000000187107FA0
	
		// Methods
		protected override void MakeLevelOne(bool dontGetCharacterDataForCurrentLevel = false /* Metadata: 0x01977F45 */) {} // 0x000000018711D330-0x000000018711DAC0
		private void PlaySparkle() {} // 0x000000018711DAC0-0x000000018711E1D0
		private void FireWeapons() {} // 0x000000018711E1D0-0x000000018711E5F0
		public override void LevelUp() {} // 0x000000018711E5F0-0x000000018711E830
	}
}
