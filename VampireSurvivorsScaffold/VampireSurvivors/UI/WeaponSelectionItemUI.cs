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
using VampireSurvivors.Data.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class WeaponSelectionItemUI : SelectableUI // TypeDefIndex: 15054
	{
		// Fields
		[SerializeField]
		private TextMeshProUGUI _Name; // 0xA0
		[SerializeField]
		private Image _Icon; // 0xA8
		[SerializeField]
		private Image _BanishedIcon; // 0xB0
		[SerializeField]
		private Image _BackgroundImage; // 0xB8
		private WeaponType _type; // 0xC0
		private WeaponData _data; // 0xC8
		private BaseWeaponSelectionPage _page; // 0xD0
		private UnityEngine.UI.Button _button; // 0xD8
	
		// Constructors
		public WeaponSelectionItemUI() {} // 0x00000001865B2B50-0x00000001865B2BB0
	
		// Methods
		public void SetData(BaseWeaponSelectionPage page, WeaponType t, WeaponData d) {} // 0x00000001869CF500-0x00000001869CF950
		protected override void OnSelected() {} // 0x00000001869CF950-0x00000001869CF980
		public WeaponType GetWeaponType() => default; // 0x00000001831C30C0-0x00000001831C30D0
		public void DisableButton() {} // 0x00000001869CF980-0x00000001869CF9B0
		private void SelectButton() {} // 0x00000001869CF9B0-0x00000001869CF9E0
		private void SetIconSize() {} // 0x00000001869CF9E0-0x00000001869CFDE0
	}
}
