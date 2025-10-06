/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

[RequireComponent(typeof(VerticalLayoutGroup))]
public class MultipleLineHorizontalList : MonoBehaviour // TypeDefIndex: 13869
{
	// Fields
	[SerializeField]
	private float _LineHeight; // 0x20
	[SerializeField]
	private float _MaxWidth; // 0x24
	[SerializeField]
	private float _PortraitMaxWidth; // 0x28
	private List<GameObject> _lines; // 0x30
	private RectTransform _activeLine; // 0x38
	private List<GameObject> _spawned; // 0x40

	// Constructors
	public MultipleLineHorizontalList() {} // 0x00000001865B6050-0x00000001865B61E0

	// Methods
	private void Start() {} // 0x00000001865B5560-0x00000001865B55A0
	public void AddNewItem(RectTransform t) {} // 0x00000001865B55A0-0x00000001865B5800
	public void Clear() {} // 0x00000001865B5800-0x00000001865B5C50
	public void CreateNewLine() {} // 0x00000001865B5C50-0x00000001865B6050
	public void SetMaxWidth(float w) {} // 0x0000000184C5EF90-0x0000000184C5EFA0
}

