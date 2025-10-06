/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Dark2_Projectile : TP_Light1_Projectile // TypeDefIndex: 15530
	{
		// Fields
		[SerializeField]
		private TrailRenderer _trail; // 0x130
		private int _gravityFrameCounter; // 0x138
	
		// Properties
		public override float BodyRadius { get => default; } // 0x0000000186C7DEE0-0x0000000186C7DEF0 
		public override float Scale { get => default; } // 0x0000000186C7DEF0-0x0000000186C7DF00 
		public override float Depth { get => default; } // 0x0000000185C0CCB0-0x0000000185C0CCC0 
		public override bool HasOrbiters { get => default; } // 0x0000000181958370-0x0000000181958380 
		public override int InvertMotion { get => default; } // 0x0000000181EE0060-0x0000000181EE0070 
	
		// Constructors
		public TP_Dark2_Projectile() {} // 0x0000000186C7E5D0-0x0000000186C7E630
	
		// Methods
		public override void MakeSpriteAnimation() {} // 0x0000000186C7EBD0-0x0000000186C7EF70
		protected override void InitAlpha() {} // 0x0000000186C7EF70-0x0000000186C7F050
		protected override void PlayFiringSfx() {} // 0x0000000186C7F050-0x0000000186C7F130
		public void createGravityWell(float2 pos, float radius) {} // 0x0000000186C7F130-0x0000000186C7F380
	}
}
