/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects
{
	public class MorphVFX // TypeDefIndex: 15170
	{
		// Fields
		private PhaserSprite _sparkSprite; // 0x10
		private PhaserSprite _ringSprite; // 0x18
		private MultiTargetTween _ringTween; // 0x20
		private MultiTargetTween _sparkTween; // 0x28
		private PhaserSprite _burstSprite; // 0x30
		private PhaserSprite _darkSprite; // 0x38
		private MultiTargetTween _darkTween; // 0x40
		private float _x; // 0x48
		private float _y; // 0x4C
		public uint[] _burstTint; // 0x50
		public string _sparkName; // 0x58
		public string _diskName; // 0x60
	
		// Constructors
		public MorphVFX() {} // 0x0000000186A76050-0x0000000186A76200
	
		// Methods
		public void Make() {} // 0x0000000186A74A10-0x0000000186A75710
		public void PlaySparkle(CharacterController character) {} // 0x0000000186A75710-0x0000000186A76050
	}
}
