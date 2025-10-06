/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.Mathematics;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Phaser
{
	public class PhaserText : GameMonoBehaviour // TypeDefIndex: 18219
	{
		// Fields
		private TextMeshPro _textRenderer; // 0x28
		public float _originX; // 0x30
		public float _originY; // 0x34
	
		// Properties
		public TextMeshPro TextRenderer { get => default; } // 0x0000000180B15540-0x0000000180B15550 
	
		// Constructors
		public PhaserText() {} // 0x0000000184C44C90-0x0000000184C44CE0
	
		// Methods
		private void Start() {} // 0x0000000186704250-0x0000000186704260
		public void InternalForceInit() {} // 0x0000000186704260-0x00000001867042B0
		public PhaserText SetText(string text) => default; // 0x00000001867042B0-0x0000000186704350
		public PhaserText UpdateDisplaySize() => default; // 0x0000000186704350-0x00000001867044C0
		public PhaserText SetAlpha(float alpha) => default; // 0x00000001867044C0-0x00000001867045A0
		public PhaserText SetColor(Color color) => default; // 0x00000001867045A0-0x00000001867045E0
		public PhaserText SetTint(uint tint) => default; // 0x00000001867045E0-0x0000000186704650
		public PhaserText SetFont(string fontPath) => default; // 0x0000000186704650-0x0000000186704920
		public PhaserText SetFontSize(float fontSize) => default; // 0x0000000186704920-0x0000000186704950
		public PhaserText SetDepth(int depth) => default; // 0x0000000186704950-0x00000001867049D0
		public PhaserText setOrigin(float2 origin) => default; // 0x00000001867049D0-0x0000000186704A40
		public PhaserText setOrigin(float originX = 0.5f /* Metadata: 0x019788C9 */, float? originY = default) => default; // 0x0000000186704A40-0x0000000186704D00
		public PhaserText SetTextAlignments(HorizontalAlignmentOptions x, VerticalAlignmentOptions y) => default; // 0x0000000186704D00-0x0000000186704D80
		public PhaserText setName(string newName) => default; // 0x00000001866FF470-0x00000001866FF4B0
		public PhaserText setVisible(bool visible) => default; // 0x0000000186704D80-0x0000000186704E80
		public void destroy() {} // 0x0000000186704E80-0x0000000186704F20
		private void EnsureTextRenderer() {} // 0x0000000186704F20-0x0000000186705640
		private void AssignDefaultFont() {} // 0x0000000186705640-0x0000000186705690
	}
}
