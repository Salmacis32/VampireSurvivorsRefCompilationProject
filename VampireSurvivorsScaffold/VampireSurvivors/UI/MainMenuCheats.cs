/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class MainMenuCheats : MonoBehaviour // TypeDefIndex: 14849
	{
		// Fields
		[SerializeField]
		private GameObject _CheatButtonPrefab; // 0x20
		[SerializeField]
		private RectTransform _CharacterContainer; // 0x28
		[SerializeField]
		private RectTransform _StageContainer; // 0x30
		[SerializeField]
		private RectTransform _RelicContainer; // 0x38
		[SerializeField]
		private RectTransform _PowerUpContainer; // 0x40
		[SerializeField]
		private RectTransform _WeaponContainer; // 0x48
		private PlayerOptions _playerOptions; // 0x50
		private SignalBus _signalBus; // 0x58
		private DataManager _dataManager; // 0x60
	
		// Constructors
		public MainMenuCheats() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		[Inject]
		private void Construct(SignalBus signal, PlayerOptions player, DataManager data) {} // 0x00000001868D17E0-0x00000001868D18F0
		private void Start() {} // 0x00000001868D18F0-0x00000001868D1900
		private void Populate() {} // 0x00000001868D1900-0x00000001868D2B90
		public void AddCoins() {} // 0x00000001868D2B90-0x00000001868D2BC0
	}
}
