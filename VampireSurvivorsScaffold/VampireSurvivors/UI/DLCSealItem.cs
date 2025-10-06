/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class DLCSealItem : MonoBehaviour // TypeDefIndex: 14753
	{
		// Fields
		[SerializeField]
		private TextMeshProUGUI _Name; // 0x20
		[SerializeField]
		private Image _ToggleIcon; // 0x28
		private bool _isBanished; // 0x30
		private MegaSealPanel _megaSealPanel; // 0x38
		private ContentGroupType _type; // 0x40
	
		// Constructors
		public DLCSealItem() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		public void SetDLCData(MegaSealPanel seal, ContentGroupType t, bool isBanished) {} // 0x0000000186880E80-0x0000000186880FE0
		public void RefreshText() {} // 0x0000000186880FE0-0x0000000186881020
		private void Toggle() {} // 0x0000000186881020-0x0000000186881040
		private void ApplySetting() {} // 0x0000000186881040-0x0000000186881140
		public void SetUnBanished() {} // 0x0000000186881140-0x0000000186881150
	}
}
