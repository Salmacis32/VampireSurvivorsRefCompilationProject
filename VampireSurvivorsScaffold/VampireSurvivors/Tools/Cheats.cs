/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using VampireSurvivors.Framework;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Tools
{
	public class Cheats : GameMonoBehaviour // TypeDefIndex: 14267
	{
		// Fields
		private SignalBus _signalBus; // 0x28
		private GameSessionData _gameSessionData; // 0x30
		private LevelUpFactory _levelUpFactory; // 0x38
		private GameManager _gameManager; // 0x40
		[SerializeField]
		private GameObject _automationCancel; // 0x48
		[SerializeField]
		private TextMeshProUGUI _spawnedEnemyCount; // 0x50
		[SerializeField]
		private TextMeshProUGUI _temporaryEnemyCount; // 0x58
		[SerializeField]
		private TextMeshProUGUI _permanentEnemyCount; // 0x60
		[SerializeField]
		private TextMeshProUGUI _currentTimeText; // 0x68
	
		// Constructors
		public Cheats() {} // 0x0000000184C44C90-0x0000000184C44CE0
	
		// Methods
		[Inject]
		private void Construct(SignalBus signalBus, GameSessionData gameSessionData, LevelUpFactory levelUpFactory, GameManager gameManager) {} // 0x0000000187044B80-0x0000000187044CD0
		protected override void OnUpdate() {} // 0x0000000187044CD0-0x00000001870451E0
		public void ForceTreasure(int level) {} // 0x00000001870451E0-0x0000000187045AA0
		public void FindRelic() {} // 0x0000000187045AA0-0x0000000187045B20
		public void FindItem() {} // 0x0000000180B15170-0x0000000180B15180
		public void ForceLevelUp() {} // 0x0000000187045B20-0x0000000187045C20
		public void Pause() {} // 0x0000000187045C20-0x0000000187045D00
		public void KillPlayer() {} // 0x0000000187045D00-0x0000000187045DF0
		public void AddRandomExperience() {} // 0x0000000187045DF0-0x0000000187045EA0
		public void PickupCoinBag() {} // 0x0000000187045EA0-0x0000000187045F20
		public void CancelAutomation() {} // 0x0000000187045F20-0x0000000187046050
	}
}
