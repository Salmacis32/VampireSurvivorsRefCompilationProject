/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class TP_Chaos_Character : TP_Character // TypeDefIndex: 17043
	{
		// Fields
		private PhaserSprite _spriteRing0; // 0x3F0
		private PhaserSprite _spriteRing1; // 0x3F8
		private PhaserSprite _spriteRing2; // 0x400
		private PhaserSprite _spriteStatue1; // 0x408
		private PhaserSprite _spriteStatue2; // 0x410
		private PhaserSprite _spriteStatue3; // 0x418
		private PhaserSprite _spriteBackground; // 0x420
		private float _radius; // 0x428
		private List<ArcanaType> arcanas; // 0x430
	
		// Constructors
		public TP_Chaos_Character() {} // 0x0000000187157010-0x0000000187157800
	
		// Methods
		protected override void MakeLevelOne(bool dontGetCharacterDataForCurrentLevel = false /* Metadata: 0x01977FE7 */) {} // 0x0000000187154C30-0x0000000187154C60
		public override bool ShouldCollideWithWalls() => default; // 0x0000000180B15290-0x0000000180B152A0
		public override void AfterFullInitialization() {} // 0x0000000187154C60-0x0000000187156BA0
		protected override void OnUpdate() {} // 0x0000000187156BA0-0x0000000187157010
	}
}
