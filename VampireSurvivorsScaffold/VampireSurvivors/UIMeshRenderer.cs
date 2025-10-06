/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	[ExecuteAlways]
	[RequireComponent(typeof(CanvasRenderer))]
	public class UIMeshRenderer : MonoBehaviour // TypeDefIndex: 14254
	{
		// Fields
		public Material Material; // 0x20
		[SerializeField]
		private Mesh mesh; // 0x28
		[SerializeField]
		private bool mask; // 0x30
		[SerializeField]
		private bool showMaskGraphic; // 0x31
		[SerializeField]
		private bool maskable; // 0x32
		[SerializeField]
		private bool preserveAspect; // 0x33
		private CanvasRenderer canvasRenderer; // 0x38
		private Image[] childImage; // 0x40
		private Vector3[] baseVertices; // 0x48
		private RectTransform rect; // 0x50
		private float cachedHeight; // 0x58
		private float cachedWidth; // 0x5C
	
		// Constructors
		public UIMeshRenderer() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		private void Start() {} // 0x0000000186F0F9C0-0x0000000186F0F9D0
		private void SetupMesh() {} // 0x0000000186F0F9D0-0x0000000186F0FD20
		private void Update() {} // 0x0000000186F0FD20-0x0000000186F10020
		private void OnEnable() {} // 0x0000000186F10020-0x0000000186F10050
		private void OnDisable() {} // 0x0000000186F10050-0x0000000186F10110
		private Mesh CreateNewMesh() => default; // 0x0000000186F10110-0x0000000186F10700
		private void SetStencilSelf() {} // 0x0000000186F10700-0x0000000186F10910
		private void SetMaskableSelf() {} // 0x0000000186F10910-0x0000000186F10B30
		private void SetStencilChildren(Image[] images) {} // 0x0000000186F10B30-0x0000000186F10E60
		private void OnValidate() {} // 0x0000000186F10E60-0x0000000186F10F00
	}
}
