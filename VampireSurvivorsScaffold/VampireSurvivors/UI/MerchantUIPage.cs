/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors;
using VampireSurvivors.App.Scripts.Framework.Adventures;
using VampireSurvivors.App.UI;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Items;
using VampireSurvivors.Data.PowerUp;
using VampireSurvivors.Data.Weapons;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Items;
using VampireSurvivors.Signals;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class MerchantUIPage : GameWindowedUIPage // TypeDefIndex: 14866
	{
		// Fields
		[SerializeField]
		private ShopItemUI _ShopItemPrefab; // 0x158
		[SerializeField]
		private RectTransform _ItemContainer; // 0x160
		[SerializeField]
		private GameObject _EggResultPrefab; // 0x168
		[SerializeField]
		private RectTransform _Panel; // 0x170
		[SerializeField]
		private UISpriteAnimation _BurstVFX; // 0x178
		[SerializeField]
		private GridLayoutGroup _Grid; // 0x180
		[SerializeField]
		private ContentSizeFitter _GridFitter; // 0x188
		[SerializeField]
		private RectTransform _CurrencyPanel; // 0x190
		[SerializeField]
		private Image _Mask; // 0x198
		private SignalBus _signalBus; // 0x1A0
		private DataManager _data; // 0x1A8
		private PlayerOptions _playerOptions; // 0x1B0
		private EggManager _egg; // 0x1B8
		private AdventureManager _adventureManager; // 0x1C0
		private ShopFactory _shopFactory; // 0x1C8
		private Dictionary<VampireSurvivors.Data.ItemType, ItemData> _items; // 0x1D0
		private Dictionary<WeaponType, List<WeaponData>> _weapons; // 0x1D8
		private Dictionary<PowerUpType, List<PowerUpData>> _powerUps; // 0x1E0
		private Coroutine _maxEggsPurchasedRoutine; // 0x1E8
		private string[] _textColors; // 0x1F0
		private float _SpamPressTimer; // 0x1F8
		private bool _SpamPressFirst; // 0x1FC
		protected bool hideBackgroundMask; // 0x1FD
		private List<string> _itemSprites; // 0x200
		private int _goldenEggSoundIndex; // 0x208
		private int[] _goldenEggSFXDetune; // 0x210
		private ShopItemUI _selected; // 0x218
		private VampireSurvivors.Objects.Characters.CharacterController _currentCharacter; // 0x220
		private TutorialPopup _spawnedTutorialPopup; // 0x228
	
		// Constructors
		public MerchantUIPage() {} // 0x00000001868EF520-0x00000001868EFEE0
	
		// Methods
		[Inject]
		private void Construct(SignalBus signalBus, DataManager data, PlayerOptions playerOptions, GameSessionData session, EggManager egg, AdventureManager adventureManager, ShopFactory shopFactory) {} // 0x00000001868E62C0-0x00000001868E68B0
		protected override void Awake() {} // 0x00000001868E68B0-0x00000001868E6970
		private void OnRemotePurchase(OnlineSignals.OnlinePurchase purchase) {} // 0x00000001868E6970-0x00000001868E6E10
		private void OnDestroy() {} // 0x00000001868E6E10-0x00000001868E7050
		public void Close() {} // 0x00000001868E7050-0x00000001868E71D0
		public override float GetCurrency() => default; // 0x00000001868E71D0-0x00000001868E7200
		public override void SetSelected(ShopItemUI item) {} // 0x00000001868E7200-0x00000001868E72E0
		public override void Purchase(WeaponType t, WeaponData d, float price, ShopItemUI shopItemUI) {} // 0x00000001868E72E0-0x00000001868E7420
		public override void OnUserConfirmInput() {} // 0x00000001868E7420-0x00000001868E7430
		public override void Purchase(VampireSurvivors.Data.ItemType t, ItemData d, ShopItemUI item, float price, RectTransform sender) {} // 0x00000001868E7430-0x00000001868E7570
		public void PurchaseSelected() {} // 0x00000001868E7570-0x00000001868E7CD0
		private void InvokeCustomPurchaseActionAndClose(ShopItemUI item) {} // 0x00000001868E7CD0-0x00000001868E7D40
		protected override void OnHideStart(GameObject g) {} // 0x00000001868E7D40-0x00000001868E8040
		protected override void OnShowStart(GameObject g) {} // 0x00000001868E8040-0x00000001868E8F10
		protected override void OnHideFinish(GameObject g) {} // 0x00000001868E8F10-0x00000001868E93E0
		private void EditorShowTutorial() {} // 0x00000001868E93E0-0x00000001868E9540
		private void OnMerchantTutorialClosed() {} // 0x00000001868E9540-0x00000001868E9610
		protected override void Update() {} // 0x00000001868E9610-0x00000001868E9850
		protected void OnMerchantEnterPressed() {} // 0x00000001868E9850-0x00000001868E9930
		protected override VampireSurvivors.Objects.Characters.CharacterController GetCharacterControllingUi() => default; // 0x0000000186753440-0x0000000186753450
		protected override void OnCancelPressed() {} // 0x00000001868E9930-0x00000001868E9B60
		private void ProcessWeaponPurchase(WeaponType t, int price, ShopItemUI shopItemUI) {} // 0x00000001868E9B60-0x00000001868E9E30
		private void ProcessItemPurchase(VampireSurvivors.Data.ItemType t, ShopItemUI item, RectTransform sender) {} // 0x00000001868E9E30-0x00000001868EA750
		private void SetCurrentCharacter(UISignals.OpenMerchantSignal sig) {} // 0x00000001868EA750-0x00000001868EA7C0
		[IteratorStateMachine(typeof(_BuyAllRoutine_d__53))]
		private IEnumerator BuyAllRoutine(float count, RectTransform sender) => default; // 0x00000001868EA7C0-0x00000001868EA8E0
		private static void MakeEggNoise(int sfxIndex, int delay) {} // 0x00000001868EA8E0-0x00000001868EAAB0
		private string RandomFrame() => default; // 0x00000001868EAAB0-0x00000001868EAB80
		private void Populate() {} // 0x00000001868EAB80-0x00000001868EB5F0
		private void RecenterGridGroup() {} // 0x00000001868EB5F0-0x00000001868EBAB0
		public static List<WeaponType> GetValidAdventureWeaponsForMerchant(List<WeaponType> merchantInventory, PlayerOptions playerOptions) => default; // 0x00000001868EBAB0-0x00000001868EBDB0
		public static List<WeaponType> GetValidCustomMerchantWeapons(List<WeaponType> merchantInventory, PlayerOptions playerOptions) => default; // 0x00000001868EBDB0-0x00000001868EC130
		public static List<VampireSurvivors.Data.ItemType> GetValidCustomMerchantItems(List<VampireSurvivors.Data.ItemType> merchantInventoryItems, PlayerOptions playerOptions) => default; // 0x00000001868EC130-0x00000001868EC470
		private void ShowEggResult(RectTransform sender, string att, float val) {} // 0x00000001868EC470-0x00000001868ECB70
		private void ShowEggResultSprite(RectTransform sender) {} // 0x00000001868ECB70-0x00000001868ED270
		private string LookUpFrame(string name) => default; // 0x00000001868ED270-0x00000001868EDC30
		private bool DoesPlayerAlreadyHaveWeapon(WeaponType t) => default; // 0x00000001868EDC30-0x00000001868EDF60
		private GameObject AddWeapon(WeaponType t, int index, bool useWeaponDataPrice = false /* Metadata: 0x01977237 */) => default; // 0x00000001868EDF60-0x00000001868EE2F0
		private void AddItem(VampireSurvivors.Data.ItemType t, int index) {} // 0x00000001868EE2F0-0x00000001868EE640
		private ShopItemUI AddCustomActionShopItem(CustomActionInventoryItem inventoryItem) => default; // 0x00000001868EE640-0x00000001868EE760
		private float GetAdventureMerchantPriceMarkupMultiplier() => default; // 0x00000001868EE760-0x00000001868EE920
		private void ClearSpawned() {} // 0x00000001868EE920-0x00000001868EEB20
		private void IntroAnimation() {} // 0x00000001868EEB20-0x00000001868EF200
		[IteratorStateMachine(typeof(_WaitAndTween_d__71))]
		private IEnumerator WaitAndTween() => default; // 0x00000001868EF200-0x00000001868EF2A0
		private void DisableWeaponPanels() {} // 0x00000001868EF2A0-0x00000001868EF520
	}
}
