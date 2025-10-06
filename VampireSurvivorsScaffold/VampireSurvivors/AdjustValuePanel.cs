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

namespace VampireSurvivors
{
	public class AdjustValuePanel : MonoBehaviour // TypeDefIndex: 14184
	{
		// Fields
		[SerializeField]
		private Image _Icon; // 0x20
		[SerializeField]
		private TextMeshProUGUI _ValueText; // 0x28
		[SerializeField]
		private UnityEngine.UI.Button _UpButton; // 0x30
		[SerializeField]
		private UnityEngine.UI.Button _DownButton; // 0x38
		[SerializeField]
		private float _IncrementAmount; // 0x40
		[SerializeField]
		private string _Suffix; // 0x48
		[SerializeField]
		private bool CanGoNegative; // 0x50
		private float _displayValue; // 0x60
		private bool _canGoUp; // 0x64
		private bool _canGoDown; // 0x65
		private int _pointsAssigned; // 0x68
		private Color _inactiveColor; // 0x6C
		private Selectable _selectOnRight; // 0x80
	
		// Events
		public event OnValueChange ValueChanged;
	
		// Nested types
		public delegate void OnValueChange(AdjustValuePanel panel, bool positive); // TypeDefIndex: 14183; 0x000000018196C8D0-0x000000018196C8E0
	
		// Constructors
		public AdjustValuePanel() {} // 0x0000000186DA8DB0-0x0000000186DA8E80
	
		// Methods
		private void Start() {} // 0x0000000186DA8720-0x0000000186DA8860
		public void Initialize(int pointsAssigned) {} // 0x0000000186DA8860-0x0000000186DA88F0
		public void IncrementUp() {} // 0x0000000186DA88F0-0x0000000186DA8940
		public void SetValue(int v) {} // 0x0000000186DA8940-0x0000000186DA8960
		public void IncrementDown() {} // 0x0000000186DA8960-0x0000000186DA89B0
		public float GetValue() => default; // 0x00000001832F7340-0x00000001832F7350
		public int GetIncrementValue() => default; // 0x0000000182A74C20-0x0000000182A74C30
		public void SetCanIncrementUp(bool enabled) {} // 0x0000000186DA89B0-0x0000000186DA89C0
		public void SetCanIncrementDown(bool enabled) {} // 0x0000000186DA89C0-0x0000000186DA89D0
		private void Refresh() {} // 0x0000000186DA89D0-0x0000000186DA8D90
		private bool CanDecrease() => default; // 0x0000000186DA8D90-0x0000000186DA8DB0
		private bool CanIncrease() => default; // 0x0000000182926A40-0x0000000182926A50
		public Selectable GetUpButton() => default; // 0x0000000180B15550-0x0000000180B15560
		public Selectable GetDownButton() => default; // 0x0000000180B15560-0x0000000180B15570
	}
}
