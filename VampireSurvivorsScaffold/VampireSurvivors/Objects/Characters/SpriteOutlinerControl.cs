/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class SpriteOutlinerControl : MonoBehaviour // TypeDefIndex: 16809
	{
		// Fields
		private static readonly int SpriteRect; // 0x00
		private MeshRenderer _meshRenderer; // 0x20
		private bool _outlineOffsetNegative; // 0x28
	
		// Constructors
		public SpriteOutlinerControl() {} // 0x0000000180B18150-0x0000000180B181A0
		static SpriteOutlinerControl() {} // 0x00000001870D1D50-0x00000001870D1DB0
	
		// Methods
		public void ShowOutline(SpriteRenderer spriteRenderer, Color colour, bool matchRendererPosition = false /* Metadata: 0x01977E7B */) {} // 0x00000001870D1050-0x00000001870D1320
		public void UpdateSprite(SpriteRenderer spriteRenderer, bool matchRendererPosition = false /* Metadata: 0x01977E7C */) {} // 0x00000001870D1320-0x00000001870D1D50
		public void HideOutline() {} // 0x00000001867AD930-0x00000001867AD960
		public void SetOutlineOffsetNegative() {} // 0x0000000183887950-0x0000000183887960
	}
}
