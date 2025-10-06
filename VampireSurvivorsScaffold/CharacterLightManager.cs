/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.Universal;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

public class CharacterLightManager : MonoBehaviour // TypeDefIndex: 13844
{
	// Fields
	[SerializeField]
	private Light2D characterLight; // 0x20
	[SerializeField]
	[Tooltip("This should be set to the intensity of the Map\'s Global Light, found in the Map\'s prefab")]
	private float mapGlobalLightIntensity; // 0x28
	public bool FixedIntensity; // 0x2C

	// Properties
	public Light2D CharacterLight { get => default; } // 0x0000000180B15530-0x0000000180B15540 

	// Constructors
	public CharacterLightManager() {} // 0x000000018659E010-0x000000018659E060

	// Methods
	private void Start() {} // 0x000000018659DE50-0x000000018659DF60
	private void Update() {} // 0x000000018659DF60-0x000000018659E010
}

