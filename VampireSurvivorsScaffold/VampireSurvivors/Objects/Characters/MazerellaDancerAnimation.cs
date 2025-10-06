/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Characters.Enemies;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class MazerellaDancerAnimation // TypeDefIndex: 17202
	{
		// Fields
		private const string TarantellaTextureName = "character_tarantella"; // Metadata: 0x019781B8
		private const string CharacterCacheGroupName = "CharacterTextures"; // Metadata: 0x019781CD
		private const string FemaleCharacterName = "Tarantella_F_"; // Metadata: 0x019781DF
		private const string MaleCharacterName = "Tarantella_M_"; // Metadata: 0x019781ED
		private const string KickAnimName = "kick_i0"; // Metadata: 0x019781FB
		private const string SpinAnimName = "spin_i0"; // Metadata: 0x01978203
		private const string FemaleTambourineAnimName = "tamborine_i0"; // Metadata: 0x0197820B
		private const string MaleTambourineAnimName = "tamborin_i0"; // Metadata: 0x01978218
		private const string MaleKick = "Tarantella_M_kick_i0"; // Metadata: 0x01978224
		private const string MaleSpin = "Tarantella_M_spin_i0"; // Metadata: 0x01978239
		private const string MaleTambourine = "Tarantella_M_tamborin_i0"; // Metadata: 0x0197824E
		private const string FemaleKick = "Tarantella_F_kick_i0"; // Metadata: 0x01978267
		private const string FemaleSpin = "Tarantella_F_spin_i0"; // Metadata: 0x0197827C
		private const string FemaleTambourine = "Tarantella_F_tamborine_i0"; // Metadata: 0x01978291
		private SpriteRenderer _spriteRenderer; // 0x10
		private SpriteAnimation _spriteAnimation; // 0x18
		private int _currentAnimationStageIndex; // 0x20
		private readonly List<DanceAnimationStage> _danceAnimationStages; // 0x28
	
		// Nested types
		private struct DanceAnimationStage // TypeDefIndex: 17200
		{
			// Fields
			public readonly string AnimationName; // 0x00
			public readonly bool FlipX; // 0x08
	
			// Constructors
			public DanceAnimationStage(string animationName, bool flipX) {
				AnimationName = default;
				FlipX = default;
			} // 0x00000001819596F0-0x0000000181959750
		}
	
		// Constructors
		public MazerellaDancerAnimation() {} // 0x00000001871DF2B0-0x00000001871DF370
	
		// Methods
		private static string KickAnimationName(EnemyMazerellaDancer.DancerSide dancerSide) => default; // 0x00000001871DE8B0-0x00000001871DE910
		private static string SpinAnimationName(EnemyMazerellaDancer.DancerSide dancerSide) => default; // 0x00000001871DE910-0x00000001871DE970
		private static string TambourineAnimationName(EnemyMazerellaDancer.DancerSide dancerSide) => default; // 0x00000001871DE970-0x00000001871DE9D0
		public void InitAnims(SpriteRenderer spriteRenderer, SpriteAnimation spriteAnimation, EnemyMazerellaDancer.DancerSide dancerSide) {} // 0x00000001871DE9D0-0x00000001871DED80
		private void AddDanceAnim(string animName, string textureName, int frameCount, int fps) {} // 0x00000001871DED80-0x00000001871DF010
		private void PlayNextAnimationStage() {} // 0x00000001871DF010-0x00000001871DF070
		private void PlayAnimationStage(int stageIndex) {} // 0x00000001871DF070-0x00000001871DF120
		private List<string> MakeAnimFrameList(string animName, int frameCount) => default; // 0x00000001871DF120-0x00000001871DF2B0
	}
}
