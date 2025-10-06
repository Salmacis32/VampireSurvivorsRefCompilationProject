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
using VampireSurvivors.Data;
using VampireSurvivors.Data.PowerUp;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class StatItemUI : MonoBehaviour // TypeDefIndex: 14991
	{
		// Fields
		[SerializeField]
		private string _Format; // 0x20
		[FormerlySerializedAs("Type")]
		[SerializeField]
		public PowerUpType _Type; // 0x28
		[FormerlySerializedAs("DefaultValue")]
		[SerializeField]
		private float _DefaultValue; // 0x2C
		[FormerlySerializedAs("UsePlus")]
		[SerializeField]
		private bool _UsePlus; // 0x30
		[FormerlySerializedAs("Name")]
		[SerializeField]
		private TextMeshProUGUI _Name; // 0x38
		[FormerlySerializedAs("Value")]
		[SerializeField]
		private TextMeshProUGUI _Value; // 0x40
		[FormerlySerializedAs("Icon")]
		[SerializeField]
		private Image _Icon; // 0x48
		[FormerlySerializedAs("IsPercentage")]
		[SerializeField]
		private bool _IsPercentage; // 0x50
		[SerializeField]
		private bool _RoundToInt; // 0x51
		[SerializeField]
		private bool _MultiplyPowerUpByCharacterValue; // 0x52
	
		// Constructors
		public StatItemUI() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		public void SetData(PowerUpData data, PowerUpType t) {} // 0x00000001869982B0-0x00000001869983E0
		public TextMeshProUGUI GetNameText() => default; // 0x0000000180B15560-0x0000000180B15570
		public void SetValue(float finalvalue, bool hasPowerUp) {} // 0x00000001869983E0-0x0000000186998480
		public float GetDefaultValue() => default; // 0x0000000181949670-0x0000000181949680
		public void SetValue(float finalValue) {} // 0x0000000180B15170-0x0000000180B15180
		public void SetFormat(string s) {} // 0x0000000180B1C120-0x0000000180B1C180
		private string GetText(float value) => default; // 0x0000000186998480-0x0000000186998930
	}
}
