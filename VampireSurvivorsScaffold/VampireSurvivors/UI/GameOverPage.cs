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
using VampireSurvivors;
using VampireSurvivors.App.Framework.System;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class GameOverPage : BaseUIPage // TypeDefIndex: 14789
	{
		// Fields
		[FormerlySerializedAs("Pixeler")]
		[SerializeField]
		private PixelationTool _Pixeler; // 0xE0
		[SerializeField]
		private UnityEngine.UI.Button _QuitButton; // 0xE8
		[SerializeField]
		private UnityEngine.UI.Button _ReviveButton; // 0xF0
		[SerializeField]
		private UnityEngine.UI.Button _WatchAdForReviveButton; // 0xF8
		[SerializeField]
		private UnityEngine.UI.Button _ArcadeFreeReviveButton; // 0x100
		[SerializeField]
		private UISpriteAnimation _ReviveAnimation; // 0x108
		[SerializeField]
		private Material _GameOverPixelise; // 0x110
		[SerializeField]
		private Image _WhiteFlash; // 0x118
		[SerializeField]
		private Image _Background; // 0x120
		[SerializeField]
		private Animator _Animator; // 0x128
		[SerializeField]
		private Image _Title; // 0x130
		[SerializeField]
		private Material _BackgroundPixelMat; // 0x138
		[SerializeField]
		private Material _TitlePixelMat; // 0x140
		[SerializeField]
		private Image _StageCompleted; // 0x148
		[SerializeField]
		private Image _MoneyPile; // 0x150
		[SerializeField]
		private TextMeshProUGUI _BonusCoins; // 0x158
		[SerializeField]
		private TextMeshProUGUI _CoinReward; // 0x160
		[SerializeField]
		private TextMeshProUGUI _ReviveCoins; // 0x168
		[SerializeField]
		private TextMeshProUGUI _QuitText; // 0x170
		[SerializeField]
		private TextMeshProUGUI _ReviveText; // 0x178
		private SignalBus _signalBus; // 0x180
		private GameSessionData _gameSessionData; // 0x188
		private ArcanaManager _arcanaManager; // 0x190
		private PlayerOptions _playerOptions; // 0x198
		private DataManager _data; // 0x1A0
		private UnityServicesManager _unityServicesManager; // 0x1A8
		private int _awardGivenXTimes; // 0x1B0
		private int _totalCoins; // 0x1B4
		private bool _hasRevives; // 0x1B8
		private bool _stageComplete; // 0x1B9
		private static readonly int CellSizeX; // 0x00
		private static readonly int CellSizeY; // 0x04
		private static readonly int PixelSize; // 0x08
		private static readonly int TexSize; // 0x0C
	
		// Constructors
		public GameOverPage() {} // 0x000000018689EDA0-0x000000018689EDF0
		static GameOverPage() {} // 0x000000018689EDF0-0x000000018689EEE0
	
		// Methods
		[Inject]
		private void Construct(SignalBus signal, GameSessionData gameSessionData, ArcanaManager arcanaManager, PlayerOptions player, DataManager data, UnityServicesManager unityServicesManager) {} // 0x000000018689B770-0x000000018689B9B0
		private void Start() {} // 0x000000018689B9B0-0x000000018689BA60
		private void OnDestroy() {} // 0x000000018689BA60-0x000000018689BB30
		public void AnimateText() {} // 0x000000018689BB30-0x000000018689BB80
		public void Revive() {} // 0x000000018689BB80-0x000000018689BF30
		public void Quit() {} // 0x000000018689BF30-0x000000018689C0A0
		public void WatchAdForRevive() {} // 0x000000018689C0A0-0x000000018689C0D0
		public void ArcadeFreeRevive() {} // 0x000000018689C0A0-0x000000018689C0D0
		protected override void OnShowStart(GameObject g) {} // 0x000000018689C0D0-0x000000018689D5D0
		private bool CanShowAdvertReviveButton() => default; // 0x000000018689D5D0-0x000000018689D640
		private bool CanShowArcadeFreeReviveButton() => default; // 0x000000018689D640-0x000000018689D6B0
		private bool IsAppleArcade() => default; // 0x0000000180B15290-0x0000000180B152A0
		private int ReviveCashAmount() => default; // 0x000000018689D6B0-0x000000018689D7F0
		private void OnIntroEnded() {} // 0x000000018689D7F0-0x000000018689DAA0
		private void EnterStageReward() {} // 0x000000018689DAA0-0x000000018689E100
		private void PlayReviveAnimation() {} // 0x000000018689E100-0x000000018689E540
		private void OnReviveAnimComplete() {} // 0x000000018689E540-0x000000018689E550
		private void AnimateButtons() {} // 0x000000018689E550-0x000000018689EB80
		private void ReviveCharacter() {} // 0x000000018689EB80-0x000000018689EDA0
	}
}
