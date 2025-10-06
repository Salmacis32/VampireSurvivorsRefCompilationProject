/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Phaser
{
	public class BitmapText : GameMonoBehaviour // TypeDefIndex: 18217
	{
		// Fields
		private TextMesh _textRenderer; // 0x28
		public float _originX; // 0x30
		public float _originY; // 0x34
	
		// Properties
		public TextMesh TextRenderer { get => default; } // 0x0000000180B15540-0x0000000180B15550 
	
		// Constructors
		public BitmapText() {} // 0x0000000184C44C90-0x0000000184C44CE0
	
		// Methods
		private void Start() {} // 0x00000001866FF460-0x00000001866FF470
		public void InternalForceInit() {} // 0x00000001866FF460-0x00000001866FF470
		public BitmapText setName(string newName) => default; // 0x00000001866FF470-0x00000001866FF4B0
		public BitmapText SetText(string text) => default; // 0x00000001866FF4B0-0x00000001866FF4E0
		public BitmapText SetAlpha(float alpha) => default; // 0x00000001866FF4E0-0x00000001866FF6A0
		public BitmapText SetColor(Color color) => default; // 0x00000001866FF6A0-0x00000001866FF760
		public BitmapText SetTint(uint tint) => default; // 0x00000001866FF760-0x00000001866FF7D0
		public BitmapText SetFontSize(int fontSize) => default; // 0x00000001866FF7D0-0x00000001866FF890
		public BitmapText SetDepth(int depth) => default; // 0x00000001866FF890-0x00000001866FF940
		public BitmapText SetFont(string fontPath) => default; // 0x00000001866FF940-0x00000001866FFB80
		public BitmapText setOrigin(float2 origin) => default; // 0x00000001866FFB80-0x00000001866FFBF0
		public BitmapText setOrigin(float originX = 0.5f /* Metadata: 0x019788BE */, float? originY = default) => default; // 0x00000001866FFBF0-0x00000001866FFF10
		public BitmapText SetTextAlignments(TextAlignment textAlignment, TextAnchor textAnchor) => default; // 0x00000001866FFF10-0x00000001866FFFE0
		public void destroy() {} // 0x00000001866FFFE0-0x0000000186700080
		private void EnsureTextRenderer() {} // 0x0000000186700080-0x0000000186700770
	}
}
