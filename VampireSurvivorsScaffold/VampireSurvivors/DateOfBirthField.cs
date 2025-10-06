/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class DateOfBirthField : MonoBehaviour, ISelectableUI // TypeDefIndex: 14192
	{
		// Fields
		[SerializeField]
		private TextMeshProUGUI _Label; // 0x20
		[SerializeField]
		private TextMeshProUGUI _ErrorLabel; // 0x28
		[SerializeField]
		private CustomDropDown _Date; // 0x30
		[SerializeField]
		private CustomDropDown _Month; // 0x38
		[SerializeField]
		private CustomDropDown _Year; // 0x40
		private DateTime _date; // 0x60
		private List<int> _days; // 0x68
		private List<string> _months; // 0x70
		private List<int> _years; // 0x78
		private int _selectedDayIndex; // 0x80
		private int _selectedMonthIndex; // 0x84
		private int _selectedYearIndex; // 0x88
		private bool _hasSetDate; // 0x8C
		private bool _hasSetMonth; // 0x8D
		private bool _hasSetYear; // 0x8E
	
		// Events
		public event OnValueChanged DayChanged;
		public event OnValueChanged MonthChanged;
		public event OnValueChanged YearChanged;
	
		// Nested types
		public delegate void OnValueChanged(int val); // TypeDefIndex: 14191; 0x000000018196C5F0-0x000000018196C600
	
		// Constructors
		public DateOfBirthField() {} // 0x0000000186DAC660-0x0000000186DAC860
	
		// Methods
		public void Initialize() {} // 0x0000000186DAB690-0x0000000186DAC2F0
		public void SetLabel(string label) {} // 0x00000001867F5B20-0x00000001867F5B50
		public void SetError(string label) {} // 0x0000000186932A40-0x0000000186932A70
		private void SetDate(int i) {} // 0x0000000186DAC2F0-0x0000000186DAC380
		private void SetMonth(int i) {} // 0x0000000186DAC380-0x0000000186DAC3A0
		private void SetYear(int i) {} // 0x0000000186DAC3A0-0x0000000186DAC430
		public GameObject GetGameObject() => default; // 0x0000000182774DD0-0x0000000182774DE0
		public Selectable GetSelectable() => default; // 0x0000000185D5D2D0-0x0000000185D5D2F0
		public void UpdateNavigation(Selectable above, Selectable below, Selectable left, Selectable right) {} // 0x0000000186DAC430-0x0000000186DAC600
		private void SetNavigationMode(Selectable s) {} // 0x0000000186DAC600-0x0000000186DAC660
	}
}
