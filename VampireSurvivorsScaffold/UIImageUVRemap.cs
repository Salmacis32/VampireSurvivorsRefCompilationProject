/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

[ExecuteAlways]
[RequireComponent(typeof(Image))]
public class UIImageUVRemap : BaseMeshEffect, IMaterialModifier // TypeDefIndex: 13843
{
	// Fields
	private static readonly int UVRemapID; // 0x00
	private static readonly int RainbowOffsetID; // 0x04
	[SerializeField]
	private float Seed; // 0x28
	private Vector4 uvRemap; // 0x2C
	private int rotMode; // 0x3C
	private Image _img; // 0x40

	// Constructors
	public UIImageUVRemap() {} // 0x0000000180B18150-0x0000000180B181A0
	static UIImageUVRemap() {} // 0x000000018659DDC0-0x000000018659DE50

	// Methods
	protected override void Awake() {} // 0x000000018659D380-0x000000018659D460
	private void RegenerateSeed() {} // 0x000000018659D460-0x000000018659D4C0
	private void TryUpdate() {} // 0x000000018659D4C0-0x000000018659D8E0
	protected override void OnEnable() {} // 0x000000018659D8E0-0x000000018659DA60
	protected override void OnDisable() {} // 0x000000018659DA60-0x000000018659DB80
	public override void ModifyMesh(VertexHelper vh) {} // 0x0000000180B15170-0x0000000180B15180
	public Material GetModifiedMaterial(Material baseMat) => default; // 0x000000018659DB80-0x000000018659DDC0
}

