/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

public class RenderCameraToTextures : MonoBehaviour // TypeDefIndex: 13863
{
	// Fields
	[Header("Capture Settings")]
	public Camera captureCamera; // 0x20
	public int frameCount; // 0x28
	public string outputFolder; // 0x30
	public string baseFileName; // 0x38
	private int currentFrame; // 0x40
	private bool capturing; // 0x44
	private Vector2 ScreenRes; // 0x48

	// Constructors
	public RenderCameraToTextures() {} // 0x00000001865B08F0-0x00000001865B0A40

	// Methods
	private void Start() {} // 0x00000001865B0010-0x00000001865B0140
	private static Vector2 GetMainGameViewSize() => default; // 0x00000001865B0140-0x00000001865B02E0
	public void StartCapture() {} // 0x00000001865B02E0-0x00000001865B0590
	[IteratorStateMachine(typeof(_CaptureFrames_d__10))]
	private IEnumerator CaptureFrames() => default; // 0x00000001865B0590-0x00000001865B0630
	public void ValidateAndCreateOutputFolder() {} // 0x00000001865B0630-0x00000001865B07E0
	public void OpenOutputFolderInExplorer() {} // 0x00000001865B07E0-0x00000001865B08F0
}

