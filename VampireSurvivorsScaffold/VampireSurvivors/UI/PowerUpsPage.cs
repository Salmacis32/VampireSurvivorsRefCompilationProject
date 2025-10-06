/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using I2.Loc;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors;
using VampireSurvivors.Data;
using VampireSurvivors.Data.PowerUp;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class PowerUpsPage : BaseUIPage // TypeDefIndex: 14919
	{
		// Fields
		[SerializeField]
		private Localize Name; // 0xE0
		[SerializeField]
		private Localize Description; // 0xE8
		[SerializeField]
		private Image Icon; // 0xF0
		[SerializeField]
		private PriceUI Price; // 0xF8
		[SerializeField]
		private GameObject PowerUpPrefab; // 0x100
		[SerializeField]
		private GameObject BuyButton; // 0x108
		[SerializeField]
		private GameObject CompleteText; // 0x110
		[SerializeField]
		private Image Background; // 0x118
		[SerializeField]
		private Color MaxColor; // 0x120
		[SerializeField]
		private Image _Frame; // 0x130
		[SerializeField]
		private UnityEngine.UI.Button _RefundButton; // 0x138
		[SerializeField]
		private TickBoxUI _ActiveTickBox; // 0x140
		private PlayerOptions _playerOptions; // 0x148
		private DataManager _dataManager; // 0x150
		private PlayerStats _playerStats; // 0x158
		private SignalBus _signalBus; // 0x160
		private PowerUpItemUI _selected; // 0x168
		private List<PowerUpItemUI> _spawned; // 0x170
		private Dictionary<PowerUpType, List<PowerUpData>> rawPowerUpData; // 0x178
		private List<PowerUpType> _shownPowerUps; // 0x180
	
		// Constructors
		public PowerUpsPage() {} // 0x000000018692FB40-0x000000018692FD70
	
		// Methods
		[Inject]
		private void Construct(PlayerOptions playerOptions, DataManager dataManager, PlayerStats playerStats, SignalBus signal) {} // 0x000000018692D5F0-0x000000018692D770
		protected override void OnShowStart(GameObject g) {} // 0x000000018692D770-0x000000018692D790
		private void Populate() {} // 0x000000018692D790-0x000000018692DD30
		private void CreatePowerUp(PowerUpData dat, PowerUpType type, int level, int maxRank) {} // 0x000000018692DD30-0x000000018692DF10
		public bool CheckIfDisabled(PowerUpType type) => default; // 0x000000018692DF10-0x000000018692DF80
		public void Purchase(PowerUpData data, PowerUpType type, PowerUpItemUI item) {} // 0x000000018692DF80-0x000000018692E210
		private bool IsTogglablePowerup(PowerUpType type) => default; // 0x000000018692E210-0x000000018692E230
		public void ToggleActive() {} // 0x000000018692E230-0x000000018692E340
		public void OnActiveToggled(bool b) {} // 0x000000018692E340-0x000000018692E670
		public void PurchaseSelected() {} // 0x000000018692E670-0x000000018692E7D0
		public PowerUpItemUI GetCurrentSelected() => default; // 0x00000001829176E0-0x00000001829176F0
		[IteratorStateMachine(typeof(_WaitAndGenerateNavigation_d__31))]
		private IEnumerator WaitAndGenerateNavigation() => default; // 0x000000018692E7D0-0x000000018692E870
		public void ResetAll() {} // 0x000000018692E870-0x000000018692EA70
		public void SetInfo(PowerUpData data, PowerUpType type, PowerUpItemUI itemUI) {} // 0x000000018692EA70-0x000000018692F3D0
		public void RefundPowerUps() {} // 0x000000018692F3D0-0x000000018692F510
		public void Reset() {} // 0x000000018692F510-0x000000018692F7D0
		protected override void OnEnterPressed() {} // 0x000000018692F7D0-0x000000018692FB40
	}
}
