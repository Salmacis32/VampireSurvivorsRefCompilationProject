/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using I2.Loc;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Achievements;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Items;
using VampireSurvivors.Data.Weapons;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Signals;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class ItemFoundPage : BaseUIPage // TypeDefIndex: 14813
	{
		// Fields
		[SerializeField]
		private Localize _ItemName; // 0xE0
		[SerializeField]
		private Localize _ItemDescription; // 0xE8
		[SerializeField]
		private Localize _Title; // 0xF0
		[SerializeField]
		private RectTransform _ContentPanel; // 0xF8
		[SerializeField]
		private Image _Icon; // 0x100
		[SerializeField]
		private GameObject _GetButton; // 0x108
		[SerializeField]
		private GameObject _DiscardButton; // 0x110
		[SerializeField]
		private YellowSignManager _YellowSign; // 0x118
		[SerializeField]
		private UISpriteAnimation _BurstVFX; // 0x120
		[SerializeField]
		private ParticleEmitterManager _ParticleEmitter; // 0x128
		[SerializeField]
		private RectTransform _Panel; // 0x130
		[SerializeField]
		private GospelManager _Gospel; // 0x138
		[SerializeField]
		private RectTransform _ScrollView; // 0x140
		[SerializeField]
		private GameObject _New; // 0x148
		[SerializeField]
		private TextMeshProUGUI _LevelText; // 0x150
		private SignalBus _signalBus; // 0x158
		private VampireSurvivors.Data.ItemType _item; // 0x160
		private ItemData _itemData; // 0x168
		private DataManager _dataManager; // 0x170
		private WeaponType _weapon; // 0x178
		private WeaponData _weaponData; // 0x180
		private WeaponData _baseWeaponData; // 0x188
		private PlayerOptions _playerOptions; // 0x190
		private AchievementManager _achievementManager; // 0x198
		private VampireSurvivors.Objects.Characters.CharacterController _playerWhoFoundIt; // 0x1A0
		private bool _axisReset; // 0x1A8
		private bool _canDiscard; // 0x1A9
		private bool _discarded; // 0x1AA
		private bool _hasReceived; // 0x1AB
		private ParticleSystem _colorParticles; // 0x1B0
		private bool _shouldTime; // 0x1B8
		private float _autoAcceptCurrentTime; // 0x1BC
		private float _autoAcceptTimeLimit; // 0x1C0
	
		// Constructors
		public ItemFoundPage() {} // 0x00000001868B7020-0x00000001868B7080
	
		// Methods
		[Inject]
		private void Construct(SignalBus signalBus, DataManager data, PlayerOptions playerOptions, AchievementManager achievementManager) {} // 0x00000001868B24B0-0x00000001868B29E0
		private void OnClosePage(OnlineSignals.OnlineCloseItemFoundPage close) {} // 0x00000001868B29E0-0x00000001868B2A20
		protected override void Update() {} // 0x00000001868B2A20-0x00000001868B2EC0
		private void FixedUpdate() {} // 0x00000001868B2EC0-0x00000001868B2F40
		public void Receive() {} // 0x00000001868B2F40-0x00000001868B3050
		public void Discard() {} // 0x00000001868B3050-0x00000001868B3110
		private void DiscardItem() {} // 0x00000001868B3110-0x00000001868B3140
		private void ReceiveItem() {} // 0x00000001868B3140-0x00000001868B3BA0
		private void OnDestroy() {} // 0x00000001868B3BA0-0x00000001868B3DD0
		protected override void OnShowStart(GameObject g) {} // 0x00000001868B3DD0-0x00000001868B4640
		protected override VampireSurvivors.Objects.Characters.CharacterController GetCharacterControllingUi() => default; // 0x0000000181971880-0x0000000181971890
		protected override void OnHideFinish(GameObject g) {} // 0x00000001868B4640-0x00000001868B4AC0
		private void CacheItem(GameplaySignals.PlayerPickedUpNewItemSignal sig) {} // 0x00000001868B4AC0-0x00000001868B5250
		private void SetItemDisplay() {} // 0x00000001868B5250-0x00000001868B5570
		private void SetWeaponDisplay(int level) {} // 0x00000001868B5570-0x00000001868B5AF0
		private void SetRelicDisplay() {} // 0x00000001868B5AF0-0x00000001868B5F60
		private void MakeColorParticles() {} // 0x00000001868B5F60-0x00000001868B6C20
		private void SetIconSize() {} // 0x00000001868B6C20-0x00000001868B7020
	}
}
