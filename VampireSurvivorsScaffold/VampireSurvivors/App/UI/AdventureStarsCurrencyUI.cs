/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.UI
{
	public class AdventureStarsCurrencyUI : MonoBehaviour // TypeDefIndex: 18506
	{
		// Fields
		[SerializeField]
		private TextMeshProUGUI _StarsCurrencyText; // 0x20
		private PlayerOptions _playerOptions; // 0x28
	
		// Constructors
		public AdventureStarsCurrencyUI() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		[Inject]
		private void Construct(PlayerOptions playerOptions) {} // 0x0000000180B1D4C0-0x0000000180B1D520
		private void Awake() {} // 0x00000001867AD930-0x00000001867AD960
		private void Start() {} // 0x00000001867BBF70-0x00000001867BC150
		private void OnEnable() {} // 0x00000001867BC150-0x00000001867BC160
		private void OnDestroy() {} // 0x00000001867BC160-0x00000001867BC320
		private void UpdateStarsText() {} // 0x00000001867BC320-0x00000001867BC440
	}
}
