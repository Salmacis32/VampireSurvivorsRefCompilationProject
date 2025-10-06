/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.UI.Twitch
{
	public class TwitchLevelUpOption : MonoBehaviour // TypeDefIndex: 18534
	{
		// Fields
		[SerializeField]
		private TextMeshProUGUI _OptionText; // 0x20
		private Action _callback; // 0x28
	
		// Properties
		public TextMeshProUGUI OptionText { get => default; } // 0x0000000180B15530-0x0000000180B15540 
	
		// Constructors
		public TwitchLevelUpOption() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		private void Awake() {} // 0x0000000180B15170-0x0000000180B15180
		public void SetOptionCallback(Action callback) {} // 0x0000000180B1D4C0-0x0000000180B1D520
		public void TriggerCallback() {} // 0x0000000181997910-0x0000000181997930
	}
}
