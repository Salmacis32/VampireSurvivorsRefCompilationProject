/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Achievements;
using VampireSurvivors.App.Scripts.Framework.Adventures;
using VampireSurvivors.App.UI;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class AdventureCompletedPopup : BasePopup // TypeDefIndex: 14656
	{
		// Fields
		[SerializeField]
		private CanvasGroup _BackgroundFader; // 0x48
		[SerializeField]
		private GameObject _Ray; // 0x50
		[SerializeField]
		private RectTransform _RayContainer; // 0x58
		[SerializeField]
		private RectTransform _IconContainer; // 0x60
		[SerializeField]
		private List<ParticleSystem> _particles; // 0x68
		[SerializeField]
		private RectTransform _TitleGroup; // 0x70
		[SerializeField]
		private TextMeshProUGUI _MainTitle; // 0x78
		[SerializeField]
		private TextMeshProUGUI _TitleFade1; // 0x80
		[SerializeField]
		private TextMeshProUGUI _TitleFade2; // 0x88
		[SerializeField]
		private CanvasGroup _IconCG; // 0x90
		[SerializeField]
		private Image _DarkOverlay; // 0x98
		[SerializeField]
		private CanvasGroup _Panel; // 0xA0
		[SerializeField]
		private TextMeshProUGUI _AdventureNameText; // 0xA8
		[SerializeField]
		private TextMeshProUGUI _RewardsText; // 0xB0
		[SerializeField]
		private RectTransform _RewardsPanel; // 0xB8
		[SerializeField]
		private CanvasGroup _RewardContent; // 0xC0
		[SerializeField]
		private CanvasGroup _CoinRewardGroup; // 0xC8
		[SerializeField]
		private CanvasGroup _StarRewardGroup; // 0xD0
		[SerializeField]
		private CanvasGroup _SkinRewardGroup; // 0xD8
		[SerializeField]
		private TextMeshProUGUI _CoinRewardText; // 0xE0
		[SerializeField]
		private TextMeshProUGUI _StarRewardText; // 0xE8
		[SerializeField]
		private UnityEngine.UI.Button _DoneButton; // 0xF0
		[SerializeField]
		private ParticleEmitterManager _ParticleEmitter; // 0xF8
		[SerializeField]
		private Image _SubtitleImage; // 0x100
		[SerializeField]
		private RectTransform _SkinCarousel; // 0x108
		private MainMenuBackgroundFactory _mainMenuFactory; // 0x110
		private AdventureManager _adventureManager; // 0x118
		private ParticleSystem _colorParticles; // 0x120
		private List<GameObject> _rays; // 0x128
		private List<Tween> _tweens; // 0x130
		private GameObject _spawnedBackground; // 0x138
		private AdventureType _currentAdventure; // 0x140
		private DataManager _dataManager; // 0x148
		private PlayerOptions _playerOptions; // 0x150
		private List<SkinToUnlock> _skinsToUnlock; // 0x158
	
		// Constructors
		public AdventureCompletedPopup() {} // 0x000000018731E430-0x000000018731E630
	
		// Methods
		[Inject]
		private void Construct(MainMenuBackgroundFactory menu, AdventureManager adventure, DataManager dataManager, PlayerOptions playerOptions) {} // 0x0000000187318650-0x00000001873187D0
		private void DoShow() {} // 0x00000001873187D0-0x0000000187319560
		private void MakeColorParticles() {} // 0x0000000187319560-0x000000018731A1B0
		[IteratorStateMachine(typeof(_WaitAndShow_d__38))]
		private IEnumerator WaitAndShow() => default; // 0x000000018731A1B0-0x000000018731A250
		public override void Show() {} // 0x000000018731A250-0x000000018731A6E0
		private void Reset() {} // 0x000000018731A6E0-0x000000018731ADA0
		public override void Hide() {} // 0x000000018731ADA0-0x000000018731B010
		public void Initialize(string id) {} // 0x0000000180B1D4C0-0x0000000180B1D520
		private void SetAdventureBackground() {} // 0x000000018731B010-0x000000018731B1A0
		private void PlayParticles(bool b) {} // 0x000000018731B1A0-0x000000018731B610
		private void AddRays() {} // 0x000000018731B610-0x000000018731BF40
		private void ClearRays() {} // 0x000000018731BF40-0x000000018731C2F0
		private GameObject CreateRay(string color) => default; // 0x000000018731C2F0-0x000000018731C420
		public static string colorToHex(Color32 color) => default; // 0x000000018731C420-0x000000018731C4B0
		private static Color hexToColor(string hex) => default; // 0x000000018731C4B0-0x000000018731CB00
		private Texture2D DuplicateTexture(Texture2D source) => default; // 0x000000018731CB00-0x000000018731CF30
		public void SetSkins() {} // 0x000000018731CF30-0x000000018731E170
		private new void LateUpdate() {} // 0x000000018731E170-0x000000018731E430
	}
}
