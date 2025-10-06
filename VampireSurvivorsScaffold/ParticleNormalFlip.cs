/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

[ExecuteInEditMode]
[RequireComponent(typeof(ParticleSystem))]
public class ParticleNormalFlip : MonoBehaviour // TypeDefIndex: 13834
{
	// Fields
	[SerializeField]
	private bool DefaultIsFrontFaceCulling; // 0x20
	[Header("Debug")]
	[SerializeField]
	private bool hasFlippedNormal; // 0x21
	private UnityEngine.Renderer ren; // 0x28
	private float defaultCull; // 0x30
	private float negativeCull; // 0x34

	// Constructors
	public ParticleNormalFlip() {} // 0x000000018289FCF0-0x000000018289FD40

	// Methods
	private void Start() {} // 0x000000018659B9C0-0x000000018659BAB0
	private void Update() {} // 0x000000018659BAB0-0x000000018659BCC0
}

