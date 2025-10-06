/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class DualToggleBoolButtonAttribute : Attribute // TypeDefIndex: 13829
{
	// Fields
	private readonly string _buttonOnText; // 0x10
	private readonly string _buttonOffText; // 0x18
	private readonly string _labelText; // 0x20
	private readonly bool _showLabel; // 0x28
	private readonly bool _invertButtons; // 0x29

	// Properties
	public string ButtonOnText { get => default; } // 0x0000000180B15C10-0x0000000180B15C20 
	public string ButtonOffText { get => default; } // 0x0000000180B15520-0x0000000180B15530 
	public string LabelText { get => default; } // 0x0000000180B15530-0x0000000180B15540 
	public bool ShowLabel { get => default; } // 0x000000018195ADB0-0x000000018195ADC0 
	public bool InvertButtons { get => default; } // 0x000000018278EF20-0x000000018278EF30 

	// Constructors
	public DualToggleBoolButtonAttribute() {} // Dummy constructor
	public DualToggleBoolButtonAttribute(string buttonOnText, string buttonOffText, string labelText = null, bool showLabel = true /* Metadata: 0x01976A1B */, bool invertButtons = false /* Metadata: 0x01976A1C */) {} // 0x000000018659B890-0x000000018659B9B0
}

