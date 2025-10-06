/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

public class TextSize // TypeDefIndex: 13864
{
	// Fields
	private Hashtable dict; // 0x10
	private TextMesh textMesh; // 0x18
	private UnityEngine.Renderer renderer; // 0x20

	// Properties
	public float width { get => default; } // 0x00000001865B14C0-0x00000001865B1500 

	// Constructors
	public TextSize() {} // Dummy constructor
	public TextSize(TextMesh tm) {} // 0x00000001865B1500-0x00000001865B16A0

	// Methods
	private void getSpace() {} // 0x00000001865B16A0-0x00000001865B1C10
	private float GetTextWidth(string s) => default; // 0x00000001865B1C10-0x00000001865B20F0
	public void FitToWidth(float wantedWidth, int maxLines = -1 /* Metadata: 0x01976A4D */) {} // 0x00000001865B20F0-0x00000001865B2320
	private string wrapLine(string s, float w, int maxLines = -1 /* Metadata: 0x01976A4E */) => default; // 0x00000001865B2320-0x00000001865B29E0
}

