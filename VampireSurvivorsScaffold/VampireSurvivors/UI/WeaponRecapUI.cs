/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class WeaponRecapUI : MonoBehaviour // TypeDefIndex: 15053
	{
		// Fields
		[FormerlySerializedAs("Name")]
		[SerializeField]
		private TextMeshProUGUI _Name; // 0x20
		[FormerlySerializedAs("Level")]
		[SerializeField]
		private TextMeshProUGUI _Level; // 0x28
		[FormerlySerializedAs("Damage")]
		[SerializeField]
		private TextMeshProUGUI _Damage; // 0x30
		[FormerlySerializedAs("Time")]
		[SerializeField]
		private TextMeshProUGUI _Time; // 0x38
		[FormerlySerializedAs("DPS")]
		[SerializeField]
		private TextMeshProUGUI _Dps; // 0x40
		[FormerlySerializedAs("Icon")]
		[SerializeField]
		private Image _Icon; // 0x48
	
		// Constructors
		public WeaponRecapUI() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		public void SetData(RecapPage.StatsDisplay statsDisplay) {} // 0x00000001869CE710-0x00000001869CED30
		private string FormatNumberValue(float number, int digits) => default; // 0x00000001869CED30-0x00000001869CF500
	}
}
