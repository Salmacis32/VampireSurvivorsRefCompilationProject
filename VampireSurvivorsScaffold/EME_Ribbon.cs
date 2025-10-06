/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Dreamteck.Splines;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

[ExecuteAlways]
public class EME_Ribbon : MonoBehaviour // TypeDefIndex: 13842
{
	// Fields
	[SerializeField]
	private SplineRenderer _SplineRenderer; // 0x20
	[SerializeField]
	private SplineComputer _SplineComputer; // 0x28
	[SerializeField]
	private Vector2 LerpDistanceMinMax; // 0x30
	[SerializeField]
	private float _SpineRendererMinSize; // 0x38
	[SerializeField]
	private float _SpineRendererMaxSize; // 0x3C
	[Header("Target Settings")]
	public Transform Target; // 0x40
	[Header("Transform References")]
	[SerializeField]
	private Transform ChildTransform; // 0x48
	[SerializeField]
	private Transform MidpointTransform; // 0x50
	[Header("Midpoint Settings")]
	public float AdditionalHeight; // 0x58
	public float LerpDistance; // 0x5C
	[Header("Fade Settings")]
	[Range(0f, 1f)]
	[SerializeField]
	private float FadeIn; // 0x60
	[Range(0f, 1f)]
	[SerializeField]
	private float FadeOut; // 0x64
	private ColorModifier _colorModifier; // 0x68

	// Constructors
	public EME_Ribbon() {} // 0x000000018659D320-0x000000018659D380

	// Methods
	public void SetStartPosition(Vector3 position) {} // 0x000000018659C590-0x000000018659C640
	public void SetEndPosition(Vector3 position) {} // 0x000000018659C640-0x000000018659C6F0
	public void SetFadeIn(float value) {} // 0x000000018659C6F0-0x000000018659C720
	public void SetFadeOut(float value) {} // 0x000000018659C720-0x000000018659C750
	private void Start() {} // 0x000000018659C750-0x000000018659C880
	private void LateUpdate() {} // 0x000000018659C880-0x000000018659CFD0
	private void UpdateMidpointPosition() {} // 0x000000018659CFD0-0x000000018659D320
}

