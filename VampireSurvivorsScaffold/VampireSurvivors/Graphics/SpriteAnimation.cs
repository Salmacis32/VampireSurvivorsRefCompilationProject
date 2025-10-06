/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Graphics
{
	[RequireComponent(typeof(SpriteRenderer))]
	public class SpriteAnimation : BaseSpriteAnimation // TypeDefIndex: 14533
	{
		// Fields
		private SpriteRenderer _spriteRenderer; // 0x58
		private ArcadeSprite _arcadeSpriteToUpdate; // 0x60
		private float2 _originalSpriteSize; // 0x68
	
		// Constructors
		public SpriteAnimation() {} // 0x000000018705E920-0x000000018705E970
	
		// Methods
		protected override void Awake() {} // 0x000000018705E190-0x000000018705E3B0
		public void ForceInit() {} // 0x000000018705E3B0-0x000000018705E5C0
		protected override void ApplySpriteFrame(Sprite sprite) {} // 0x000000018705E5C0-0x000000018705E670
		public void SetOriginalSpriteSize(float2 spriteSize) {} // 0x0000000184235400-0x0000000184235410
		public void AddAnimation(string animName, SpriteAnimationData spriteAnimation, int fps, bool shouldLoop, bool startRandomFrame = false /* Metadata: 0x01977157 */, Action onComplete = null, bool autoSetAnimation = true /* Metadata: 0x01977158 */) {} // 0x000000018705E670-0x000000018705E920
	}
}
