/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class Unused_TP_AlchemyWhipBasic_Weapon : Weapon // TypeDefIndex: 16533
	{
		// Fields
		public List<float> indexDegreeList; // 0x158
		public float offsetPhysicsPos; // 0x160
		public float offsetSpritePos; // 0x164
		public List<float2> indexPosList; // 0x168
		public List<alchemyWhipData> _whipData; // 0x170
	
		// Nested types
		public class alchemyWhipData // TypeDefIndex: 16531
		{
			// Fields
			public bool active; // 0x10
			public PhaserSprite sprite; // 0x18
			public MultiTargetTween spriteTweenIn; // 0x20
			public MultiTargetTween spriteTweenOut; // 0x28
	
			// Constructors
			public alchemyWhipData() {} // 0x0000000180B15170-0x0000000180B15180
		}
	
		// Constructors
		public Unused_TP_AlchemyWhipBasic_Weapon() {} // 0x0000000187002C80-0x0000000187003410
	
		// Methods
		private alchemyWhipData nextWhipSprite() => default; // 0x0000000187002140-0x0000000187002450
		public void addWhipSprite(float2 pos, int rotationIndex) {} // 0x0000000187002450-0x0000000187002C80
		public override void CheckArcanas() {} // 0x0000000186F8E930-0x0000000186F8E9F0
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B209C0-0x0000000180B209D0
	}
}
