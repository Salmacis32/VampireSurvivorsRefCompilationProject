/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class OptionsMultipleChoiceOption : MonoBehaviour // TypeDefIndex: 14905
	{
		// Fields
		[SerializeField]
		private Image _Tick; // 0x20
		[SerializeField]
		private UnityEngine.UI.Button _Button; // 0x28
		[SerializeField]
		private TextMeshProUGUI _Label; // 0x30
		private OptionsMultipleChoice _owner; // 0x38
	
		// Constructors
		public OptionsMultipleChoiceOption() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		public void Select() {} // 0x0000000186926D30-0x0000000186926E10
		public void Deselect() {} // 0x00000001867BEC70-0x00000001867BECA0
		public void Initialize(string text, Action cb, OptionsMultipleChoice owner) {} // 0x0000000186926E10-0x0000000186926F90
	}
}
