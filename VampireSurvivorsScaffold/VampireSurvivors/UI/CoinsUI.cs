/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.App.Scripts.Framework.Adventures;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class CoinsUI : MonoBehaviour // TypeDefIndex: 14735
	{
		// Fields
		[SerializeField]
		private TextMeshProUGUI PriceValue; // 0x20
		[SerializeField]
		private Image _MoneyImage; // 0x28
		[SerializeField]
		private Image _FrameImage; // 0x30
		private PlayerOptions _playerOptions; // 0x38
		private AdventureManager _adventureManager; // 0x40
	
		// Constructors
		public CoinsUI() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		[Inject]
		private void Construct(PlayerOptions playerOptions, AdventureManager adventureManager) {} // 0x000000018686BE80-0x000000018686BF30
		private void Start() {} // 0x000000018686BF30-0x000000018686C460
		private void OnDestroy() {} // 0x000000018686C460-0x000000018686C800
		private void UpdatePrice() {} // 0x000000018686C800-0x000000018686C920
		private void OnAdventureStarted(AdventureType adventureType) {} // 0x000000018686C920-0x000000018686C930
		private void OnAdventureEnded() {} // 0x000000018686C920-0x000000018686C930
		private void SwitchCoinsUI() {} // 0x000000018686C930-0x000000018686CB80
	}
}
