/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Com.LuisPedroFonseca.ProCamera2D;
using UnityEngine;
using UnityEngine.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Graphics
{
	public class RenderTextureResizer : MonoBehaviour // TypeDefIndex: 18579
	{
		// Fields
		[SerializeField]
		private AspectRatioFitter _AspectRatioFitter; // 0x20
		private ProCamera2DPixelPerfect _ppCam; // 0x28
		private int _prevScreenHeight; // 0x30
		private int _prevScreenWidth; // 0x34
		private Camera _mainCam; // 0x38
		private RawImage _rawImage; // 0x40
		private RenderTexture _currentRT; // 0x48
		private ProCamera2DPixelPerfect _proCamera2DPixelPerfect; // 0x50
	
		// Constructors
		public RenderTextureResizer() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		private void Awake() {} // 0x00000001867E84F0-0x00000001867E8670
		private void Update() {} // 0x00000001867E8670-0x00000001867E8680
		public void UpdateRT(bool force = false /* Metadata: 0x0197AD80 */) {} // 0x00000001867E8680-0x00000001867E8A90
	}
}
