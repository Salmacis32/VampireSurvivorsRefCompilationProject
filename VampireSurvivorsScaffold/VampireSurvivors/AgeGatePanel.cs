/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class AgeGatePanel : BaseAccountPagePanel // TypeDefIndex: 14181
	{
		// Fields
		private LabeledButtonUI _confirmButton; // 0x18
		private DateOfBirthField _dob; // 0x20
		private int _day; // 0x28
		private int _month; // 0x2C
		private int _year; // 0x30
		private bool _madeChange; // 0x34
	
		// Constructors
		public AgeGatePanel() {} // Dummy constructor
		public AgeGatePanel(AccountPage accountPage) {} // 0x0000000186DA6110-0x0000000186DA61E0
	
		// Methods
		public override void Build() {} // 0x0000000186DA61E0-0x0000000186DA68B0
		private void DisableButton() {} // 0x0000000186DA68B0-0x0000000186DA68E0
		private void EnableButton() {} // 0x0000000186DA68E0-0x0000000186DA6910
		private void OnAllFieldsFilled() {} // 0x0000000186DA68E0-0x0000000186DA6910
		private void OnDaySet(int i) {} // 0x0000000186DA6910-0x0000000186DA6920
		private void OnMonthSet(int i) {} // 0x0000000186DA6920-0x0000000186DA6930
		private void OnYearSet(int i) {} // 0x0000000186DA6930-0x0000000186DA6940
		private bool CheckAllSet() => default; // 0x0000000186DA6940-0x0000000186DA6AC0
		private void OnConfirmPressed() {} // 0x0000000186DA6AC0-0x0000000186DA6EB0
	}
}
