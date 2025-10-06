/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using VampireSurvivors.Graphics.RenderPass;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class PixelateEffect : MonoBehaviour // TypeDefIndex: 14913
	{
		// Fields
		[SerializeField]
		private Renderer2DData _forwardRendererData; // 0x20
		private Material _pixelizer; // 0x28
		private static readonly int CellSizeX; // 0x00
		private static readonly int CellSizeY; // 0x04
		private static readonly int PixelSize; // 0x08
		private static readonly int TexSize; // 0x0C
	
		// Constructors
		public PixelateEffect() {} // 0x0000000180B18150-0x0000000180B181A0
		static PixelateEffect() {} // 0x000000018692B6D0-0x000000018692B7C0
	
		// Methods
		public Tween Pixelate(float startSize, float endSize, float duration = 1f /* Metadata: 0x01977262 */, bool disableWhenFinished = true /* Metadata: 0x01977266 */) => default; // 0x000000018692AD90-0x000000018692B6D0
	}
}
